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
        public void InsertUser(string username, string password, string role)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Users Values (@Username, @Password, @Role)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters.AddWithValue("@Role", role);
            sqlCommand.ExecuteScalar();
            
        }

        public void UpdateUser(string username, string password, string role, int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE Users Set Username='" + username + "', Password='" + password + "', Role='" + role + "' where ID=" + id, connection);
            connection.Open();
            sqlCommand.ExecuteScalar();
        }
        public void DeleteUser(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Users where ID=" + id, connection);
            connection.Open();
            sqlCommand.ExecuteScalar();
            
        }
        public void InsertCourse( string coursePrefix, int courseNumber, string courseName, string courseTimes, string courseSeats, string professor)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Courses Values (@CoursePrefix, @CourseNumber, @CourseName, @Times, @CourseSeats, @Professor)", connection);
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
            SqlCommand sqlCommand = new SqlCommand("UPDATE Courses Set CoursePrefix='" + coursePrefix + "', CourseNumber='" + courseNumber + "', CourseName='" + courseName + "', Times='" + courseTimes + "', Seats='" + courseSeats + "', Professor='" + professor + "' where ID=" + id, connection);
            connection.Open();
            sqlCommand.ExecuteScalar();
        }
        public void DeleteCourse(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE from Courses where ID=" + id, connection);
            connection.Open();
            sqlCommand.ExecuteScalar();
        }

    }



}
 