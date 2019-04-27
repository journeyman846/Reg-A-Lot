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
    public partial class AdminForm : Form
    {
        Database database = new Database();
        DataTable userTable = new DataTable();
        DataTable courseTable = new DataTable();
        DataTable studentTable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public AdminForm()
        {
            InitializeComponent();
            RefreshDataGrid();


        }
             
                private void searchButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    userTable = database.Read("Select * From Users where ID='" + id + "'");
                    usernameBox.Text = userTable.Rows[0][1].ToString();
                    passwordBox.Text = userTable.Rows[0][2].ToString();
                    roleBox.Text = userTable.Rows[0][3].ToString();
                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }


        }
        private void RefreshDataGrid()
        {
            userTable = database.Read("Select * From Users");
            courseTable = database.Read("Select * From Courses");
            studentTable = database.Read("Select * From Students");
            dataGridView1.DataSource = userTable;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.DataSource = courseTable;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.DataSource = studentTable;
            dataGridView3.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.InsertUser(usernameBox.Text, passwordBox.Text, roleBox.Text);
            MessageBox.Show("User added successfully!");
            RefreshDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete user " + id + "?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteUser(id);
                        MessageBox.Show("User " + id + " Deleted!");
                        RefreshDataGrid();
                    }


                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    database.UpdateUser(usernameBox.Text, passwordBox.Text, roleBox.Text, id);
                    MessageBox.Show("User " + id + " Updated!");
                    RefreshDataGrid();
                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            var courseNumber = 0;
                            
                if (int.TryParse(CourseNumberBox.Text, out courseNumber))
                {
                    database.InsertCourse(CoursePrefixBox.Text, courseNumber, CourseNameBox.Text, CourseTimesBox.Text, CourseSeatsBox.Text, CourseProfessorBox.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID number.");
                }
                   
            
          

            MessageBox.Show("Course added successfully!");
            RefreshDataGrid();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var id = 0;
            var courseNumber = 0;
            if (int.TryParse(CourseIDBox.Text, out id))
            {
                if (int.TryParse(CourseNumberBox.Text, out courseNumber))
                {
                    try
                  {
                        database.UpdateCourse(id, CoursePrefixBox.Text, courseNumber, CourseNameBox.Text, CourseTimesBox.Text, CourseSeatsBox.Text, CourseProfessorBox.Text);
                        MessageBox.Show("User " + id + " Updated!");
                        RefreshDataGrid();
                    }
                    catch
                    {
                        MessageBox.Show("ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID number.");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
            {
                var id = 0;
                if (int.TryParse(CourseIDBox.Text, out id))
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete course " + id + "?", "Delete Course", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            database.DeleteCourse(id);
                            MessageBox.Show("Course " + id + " Deleted!");
                            RefreshDataGrid();
                        }


                    }
                    catch
                    {
                        MessageBox.Show("ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID number.");
                }


                MessageBox.Show("Course deleted successfully!");
                RefreshDataGrid(); }

        private void button6_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(CourseIDBox.Text, out id))
            {
                try
                {
                    courseTable = database.Read("Select * From courses where ID='" + id + "'");
                    CourseIDBox1.Text = courseTable.Rows[0][0].ToString();
                    CoursePrefixBox.Text = courseTable.Rows[0][1].ToString();
                    CourseNumberBox.Text = courseTable.Rows[0][2].ToString();
                    CourseNameBox.Text = courseTable.Rows[0][3].ToString();
                    CourseTimesBox.Text = courseTable.Rows[0][4].ToString();
                    CourseSeatsBox.Text = courseTable.Rows[0][5].ToString();
                    CourseProfessorBox.Text = courseTable.Rows[0][5].ToString();
                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }
        }
    }
    }
    

