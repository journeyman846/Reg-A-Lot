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
        public void InsertCourse(int courseID, string coursePrefix, int courseNumber, string courseName, string courseTimes, string courseSeats, string professor)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT into Courses Values (@CourseID, @CoursePrefix, @CourseNumber, @CourseName, @CourseTimes, @CourseSeats, @Professor)", connection);
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@CourseID", courseID);
            sqlCommand.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
            sqlCommand.Parameters.AddWithValue("@CourseNumber", courseNumber);
            sqlCommand.Parameters.AddWithValue("@CourseName", courseName);
            sqlCommand.Parameters.AddWithValue("@CourseTimes", courseTimes);
            sqlCommand.Parameters.AddWithValue("@CourseSeats", courseSeats);
            sqlCommand.Parameters.AddWithValue("@Professor", professor);
            sqlCommand.ExecuteScalar();

        }

    }



}
 