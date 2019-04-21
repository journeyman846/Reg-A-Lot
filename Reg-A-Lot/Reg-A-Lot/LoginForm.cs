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
                DataTable dt = new DataTable();
                Database database = new Database();
                dt = database.Read("Select Role from Users Where Username='" + unameBox.Text + "' and Password='" + pwdBox.Text + "'");

                if (dt.Rows.Count == 1)
                {

                    var role = dt.Rows[0][0].ToString();

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
                    else if (role == "Administrator")
                    {
                        AdminForm login = new AdminForm();
                        this.Hide();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password not found. Please try again.");
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
