using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reg_A_Lot
{
    class Login

    {
        LoginForm newForm;
        SqlConnection connection = new SqlConnection("datasource=localhost;port=3306;Initial Catalog='test';username=root;password=");
        
        public void Logon()
        {
            SqlCommand cmd = new SqlCommand("Select * from login Where username=@username and password=@password", connection);
            // SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            cmd.Parameters.AddWithValue("@username", newForm.newUsername);
            cmd.Parameters.AddWithValue("@password", newForm.newPassword);

            connection.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            connection.Close();
            MessageBox.Show(newForm.newUsername);
            MessageBox.Show(newForm.newPassword);
            
        }

        public void Logoff()
        {

        }
    }
}
