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
            // SqlCommand sda = new SqlCommand(query, connection);
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            var result = "";
            sda.Fill(dt);
            /*
            

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    result = row[0].ToString();

                }
            }*/
            return dt;
        }
        public void InsertUser(string username, string password, string role)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\reg_db.mdf;Integrated Security=True");
            List<Registrar> registrars = new List<Registrar>();
            // Registrar registrar = new Registrar();
            registrars.Add(new Registrar { Username = username, Password = password, Role = role });
            
        }

    }



}
