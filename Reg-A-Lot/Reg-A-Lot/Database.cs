using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Reg_A_Lot
{
    class Database
    {

        public DataTable Read(string query)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dt);
            return dt;
        }
        public void InsertUser(string username, string password, string role, int studentID, int professorID)
        {
            // Insert user will take the StudentID created when registering and insert it into the user table. 

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Users Values (@Username, @Password, @Role, @StudentID, @ProfessorID)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters.AddWithValue("@Role", role);
            // Check if studentID or professorID will be null
            if(studentID > 0)
            {
                sqlCommand.Parameters.AddWithValue("@StudentID", studentID);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@StudentID", DBNull.Value);
            }
            if(professorID > 0)
            {
                sqlCommand.Parameters.AddWithValue("@ProfessorID", professorID);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@ProfessorID", DBNull.Value);
            }
            sqlCommand.ExecuteScalar();

        }

        public void UpdateUser(string username, string password, string role, int userID, int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Users Set Username=@Username, Password=@Password, Role=@Role, StudentID=@StudentID where ID=@ID", connection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters.AddWithValue("@Role", role);
            if(role == "Student")
            {
                sqlCommand.Parameters.AddWithValue("@StudentID", userID);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@StudentID", DBNull.Value);
            }
            if (role == "Professor")
            {
                sqlCommand.Parameters.AddWithValue("@ProfessorID", userID);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@ProfessorID", DBNull.Value);
            }
            if (role == "Admistrator")
            {
                sqlCommand.Parameters.AddWithValue("@StudentID", DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@ProfessorID", DBNull.Value);
            }

            connection.Open();
            sqlCommand.ExecuteScalar();
        }
        public void DeleteUser(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Users where ID=@ID", connection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            connection.Open();
            sqlCommand.ExecuteScalar();
            
        }
        public void InsertCourse( string coursePrefix, int courseNumber, string courseName, string courseTimes, string courseSeats, string professor)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Courses Values (@CoursePrefix, @CourseNumber, @CourseName, @Times, @Seats, @Professor)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
            sqlCommand.Parameters.AddWithValue("@CourseNumber", courseNumber);
            sqlCommand.Parameters.AddWithValue("@CourseName", courseName);
            sqlCommand.Parameters.AddWithValue("@Times", courseTimes);
            sqlCommand.Parameters.AddWithValue("@Seats", courseSeats);
            sqlCommand.Parameters.AddWithValue("@Professor", professor);
            sqlCommand.ExecuteScalar();

        }
        public void UpdateCourse(int id, string coursePrefix, int courseNumber, string courseName, string courseTimes, string courseSeats, string professor)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Courses Set CoursePrefix=@CoursePrefix, CourseNumber=@CourseNumber, CourseName=@CourseName, Times=@Times, Seats=@Seats, Professor=@Professor where ID=@ID", connection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
            sqlCommand.Parameters.AddWithValue("@CourseNumber", courseNumber);
            sqlCommand.Parameters.AddWithValue("@CourseName", courseName);
            sqlCommand.Parameters.AddWithValue("@Times", courseTimes);
            sqlCommand.Parameters.AddWithValue("@Seats", courseSeats);
            sqlCommand.Parameters.AddWithValue("@Professor", professor);
            connection.Open();
            sqlCommand.ExecuteScalar();
        }
        public void DeleteCourse(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Courses where ID=@ID", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.ExecuteScalar();
        }
        public int InsertStudent(string firstName, string lastName, int age, string email, string address, string phone)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Students OUTPUT INSERTED.ID Values (@FirstName, @LastName, @Age, @Email, @Address, @Phone)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
            sqlCommand.Parameters.AddWithValue("@LastName", lastName);
            sqlCommand.Parameters.AddWithValue("@Age", age);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            var studentID = (int)sqlCommand.ExecuteScalar();
            return studentID;
        }
        public void UpdateStudent(int id, string firstName, string lastName, int age, string email, string address, string phone)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Students Set FirstName=@FirstName, LastName=@LastName, Age=@Age, Email=@Email, Address=@Address, Phone=@Phone where ID=@ID", connection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
            sqlCommand.Parameters.AddWithValue("@LastName", lastName);
            sqlCommand.Parameters.AddWithValue("@Age", age);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);

            connection.Open();
            sqlCommand.ExecuteScalar();
        }
        public void DeleteStudent(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Students where ID=@ID", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.ExecuteScalar();
        }
        public int InsertProfessor(string firstName, string lastName, string email, string fax, string address, string phone)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Professors OUTPUT INSERTED.ID Values (@FirstName, @LastName, @Email, @Fax, @Address, @Phone)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
            sqlCommand.Parameters.AddWithValue("@LastName", lastName);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Fax", fax);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            var professorID = (int)sqlCommand.ExecuteScalar();
            return professorID;

        }
        public void UpdateProfessor(int id, string firstName, string lastName, string email, string fax, string address, string phone)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Professors Set FirstName=@Firstname, LastName=@LastName, Email=@Email, Fax=@Fax, Address=@Address, Phone=@Phone where ID=" + id, connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
            sqlCommand.Parameters.AddWithValue("@LastName", lastName);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Fax", fax);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            sqlCommand.ExecuteScalar();
        }
        public void DeleteProfessor(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Professors where ID=@ID", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.ExecuteScalar();

        }
        public int InsertRegistration(int studentID, int courseID, string grade, bool isActive)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Registrations OUTPUT INSERTED.ID Values (@StudentID, @CourseID, @Grade, @IsActive)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@StudentID", studentID);
            sqlCommand.Parameters.AddWithValue("@CourseID", courseID);
            sqlCommand.Parameters.AddWithValue("@Grade", grade);
            sqlCommand.Parameters.AddWithValue("@IsActive", isActive);
            var registrationID = (int)sqlCommand.ExecuteScalar();
            return registrationID;

        }

        public void UpdateRegistration(int studentID, int courseID, string grade, bool isActive, int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Registrations Set StudentID=@StudentID, CourseID=@CourseID, Grade=@Grade, IsActive=@IsActive where ID=@id", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@StudentID", studentID);
            sqlCommand.Parameters.AddWithValue("@CourseID", courseID);
            sqlCommand.Parameters.AddWithValue("@Grade", grade);
            sqlCommand.Parameters.AddWithValue("@IsActive", isActive);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.ExecuteScalar();
        }
        public void DeleteRegistration(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Registrations where ID=@ID", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@ID", id);
            sqlCommand.ExecuteScalar();

        }
    }
    



}
 