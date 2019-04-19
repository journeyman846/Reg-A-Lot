using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reg_A_Lot
{
    public partial class LoginForm : Form
    {
            
        public LoginForm()
        {
            
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../Resources/college.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            
             }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\James\source\repos\Reg-A-Lot\Reg-A-Lot\Reg-A-Lot\reg_db.mdf;Integrated Security=True");
                Database database = new Database();
                SqlDataAdapter sda = new SqlDataAdapter("Select Role from Users Where Username='" + unameBox.Text + "' and Password='" + pwdBox.Text + "'", connection);
                connection.Open();
                DataTable ds = new DataTable();
                sda.Fill(ds);

                
                if (ds.Rows.Count == 1)
                {
                    MessageBox.Show("You have logged in as " + ds.Rows[0][0].ToString());
                }
                else
                {
                    MessageBox.Show("Username/Password not found. Please try again.");
                }
                connection.Close();
                var role = ds.Rows[0][0].ToString();

                if (role == "Student")
                {
                    StudentForm login = new StudentForm();
                    this.Hide();
                    login.Show();
                }
                else if (role == "Professor")
                {
                    ProfessorForm login = new ProfessorForm();
                    this.Hide();
                    login.Show();
                }
                else if(role == "Administrator")
                {
                    AdminForm login = new AdminForm();
                    this.Hide();
                    login.Show();
                }

            }
            catch
            {
                MessageBox.Show("Could not connect to the database. Try again later.");
            }
            


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
            
                
    }

}
