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

        public string userID { get; set; }
        public LoginForm()
        {

            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../Resources/college.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                Database database = new Database();
                dt = database.Read("Select Role from Users Where Username='" + unameBox.Text + "' and Password='" + pwdBox.Text + "'");

                if (dt.Rows.Count == 1)
                {

                    var role = dt.Rows[0][0].ToString();

                    dt = database.Read("Select " + role + "ID from Users Where Username='" + unameBox.Text + "' and Password='" + pwdBox.Text + "'");

                    var userID = dt.Rows[0][0].ToString();

                    if (role == "Student")
                    {
                        StudentViewForm studentViewForm = new StudentViewForm();

                        studentViewForm.userName = unameBox.Text;
                        studentViewForm.userID = userID;
                        this.Hide();
                        studentViewForm.Show();
                    }
                    else if (role == "Professor")
                    {
                        ProfessorForm professorForm = new ProfessorForm();

                        professorForm.userName = unameBox.Text;
                        professorForm.userID = userID;
                        this.Hide();
                        professorForm.Show();
                    }
                    else if (role == "Administrator")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.userName = unameBox.Text;
                        adminForm.userID = userID;
                        this.Hide();
                        adminForm.Show();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();

        }
    }

   
    }


