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
        DataTable professorTable = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public string userID { get; set; }
        public string userName { get; set; }
        LoginForm loginForm = new LoginForm();


        public AdminForm()
        {
           
            InitializeComponent();
            RefreshDataGrid();
            // The below code populates the drop down for the courses form
            CourseProfessorBox.DataSource = professorTable;
            CourseProfessorBox.ValueMember = "ID";
            CourseProfessorBox.DisplayMember = "LastName";

        }
        private void RefreshDataGrid()
        {
            // Read from the database and fill the datagrids for each table
            // Calls to this method will refresh the grids
            userTable = database.Read("Select * From Users");
            courseTable = database.Read("Select * From Courses");
            studentTable = database.Read("Select * From Students");
            professorTable = database.Read("Select * From Professors");
            userGridView.DataSource = userTable;
            userGridView.RowHeadersVisible = false;
            courseGridView.DataSource = courseTable;
            courseGridView.RowHeadersVisible = false;
            studentGridView.DataSource = studentTable;
            studentGridView.RowHeadersVisible = false;
            professorGridView.DataSource = professorTable;
            professorGridView.RowHeadersVisible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Search for user

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
        
        private void button1_Click(object sender, EventArgs e)
        {
            database.InsertUser(usernameBox.Text, passwordBox.Text, roleBox.Text, 0 , 0);
            MessageBox.Show("User added successfully!");
            RefreshDataGrid();
            usernameBox.Clear();
            passwordBox.Clear();
            roleBox.Items.Clear();
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
                        usernameBox.Clear();
                        passwordBox.Clear();
                        roleBox.Items.Clear();
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
            var userID = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                if (int.TryParse(UserIDBox.Text, out userID))
                {
                    try
                    {
                        database.UpdateUser(usernameBox.Text, passwordBox.Text, roleBox.Text, userID, id);
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
                    MessageBox.Show("Please enter a valid  User ID number.");
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
                MessageBox.Show("Course added successfully!");
                CourseIDBox1.Clear();
                CoursePrefixBox.Clear();
                CourseNumberBox.Clear();
                CourseNameBox.Clear();
                CourseTimesBox.Clear();
                CourseSeatsBox.Clear();
                // CourseProfessorBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }





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
                        CourseIDBox1.Clear();
                        CoursePrefixBox.Clear();
                        CourseNumberBox.Clear();
                        CourseNameBox.Clear();
                        CourseTimesBox.Clear();
                        CourseSeatsBox.Clear();
                        // CourseProfessorBox.Items.Clear();
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
                        MessageBox.Show("Course " + id + " deleted successfully!");
                        RefreshDataGrid();
                        CourseIDBox1.Clear();
                        CoursePrefixBox.Clear();
                        CourseNumberBox.Clear();
                        CourseNameBox.Clear();
                        CourseTimesBox.Clear();
                        CourseSeatsBox.Clear();
                        // CourseProfessorBox.Items.Clear();
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

            RefreshDataGrid();
        }

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
                    CourseProfessorBox.Text = courseTable.Rows[0][6].ToString();
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

        private void button11_Click(object sender, EventArgs e)
        {
            // Insert Student
            var age = 0;

            if (int.TryParse(StudentAgeBox.Text, out age))
            {
                database.InsertStudent(StudentFirstNameBox.Text, StudentLastNameBox.Text, age, StudentEmailBox.Text, StudentAddressBox.Text, StudentPhoneBox.Text);
                StudentFirstNameBox.Clear();
                StudentLastNameBox.Clear();
                StudentAgeBox.Clear();
                StudentEmailBox.Clear();
                StudentAddressBox.Clear();
                StudentPhoneBox.Clear();



                MessageBox.Show("Student added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
            RefreshDataGrid();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Update Student
            var id = 0;
            var age = 0;
            if (int.TryParse(StudentIDBox.Text, out id))
            {
                if (int.TryParse(StudentAgeBox.Text, out age))
                {
                    try
                    {
                        database.UpdateStudent(id, StudentFirstNameBox.Text, StudentLastNameBox.Text, age, StudentEmailBox.Text, StudentAddressBox.Text, StudentPhoneBox.Text);
                        MessageBox.Show("Student " + id + " Updated!");
                        RefreshDataGrid();
                        StudentFirstNameBox.Clear();
                        StudentLastNameBox.Clear();
                        StudentAgeBox.Clear();
                        StudentEmailBox.Clear();
                        StudentAddressBox.Clear();
                        StudentPhoneBox.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid age or phone number, check your information and try again.");
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Student search 
            var id = 0;
            if (int.TryParse(StudentIDBox.Text, out id))
            {
                try
                {
                    studentTable = database.Read("Select * From students where ID='" + id + "'");
                    StudentIDBox.Text = studentTable.Rows[0][0].ToString();
                    StudentFirstNameBox.Text = studentTable.Rows[0][1].ToString();
                    StudentLastNameBox.Text = studentTable.Rows[0][2].ToString();
                    StudentAgeBox.Text = studentTable.Rows[0][3].ToString();
                    StudentEmailBox.Text = studentTable.Rows[0][4].ToString();
                    StudentAddressBox.Text = studentTable.Rows[0][5].ToString();
                    StudentPhoneBox.Text = studentTable.Rows[0][6].ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(StudentIDBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete student " + id + "?", "Delete Student", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteStudent(id);
                        MessageBox.Show("Student " + id + " deleted successfully!");
                        RefreshDataGrid();
                        StudentFirstNameBox.Clear();
                        StudentLastNameBox.Clear();
                        StudentAgeBox.Clear();
                        StudentEmailBox.Clear();
                        StudentAddressBox.Clear();
                        StudentPhoneBox.Clear();
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

            RefreshDataGrid();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Add professor
            database.InsertProfessor(ProfessorFirstNameBox.Text, ProfessorLastNameBox.Text, ProfessorEmailBox.Text, ProfessorFaxBox.Text, ProfessorAddressBox.Text, ProfessorPhoneBox.Text);
            MessageBox.Show("Professor added successfully");
            RefreshDataGrid();
            ProfessorFirstNameBox.Clear();
            ProfessorLastNameBox.Clear();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // This just updates the username on the status strip at the bottom
            toolStripStatusLabel.Text = "UserID: " + userID + " Username: " + userName;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When the form is closed redirect to the main form--final product should go back to login
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Search for professor
            var id = 0;
            if (int.TryParse(ProfessorIDBox.Text, out id))
            {
                try
                {
                    professorTable = database.Read("Select * From professors where ID='" + id + "'");
                   
                    ProfessorFirstNameBox.Text = professorTable.Rows[0][1].ToString();
                    ProfessorLastNameBox.Text = professorTable.Rows[0][2].ToString();
                    ProfessorEmailBox.Text = professorTable.Rows[0][3].ToString();
                    ProfessorFaxBox.Text = professorTable.Rows[0][4].ToString();                    
                    ProfessorAddressBox.Text = professorTable.Rows[0][5].ToString();
                    ProfessorPhoneBox.Text = professorTable.Rows[0][6].ToString();
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

        private void button13_Click(object sender, EventArgs e)
        {
            // Update professor
            var id = 0;

            if (int.TryParse(ProfessorIDBox.Text, out id))
            {
                
                    try
                    {
                        database.UpdateProfessor(id, ProfessorFirstNameBox.Text, ProfessorLastNameBox.Text, ProfessorEmailBox.Text, ProfessorFaxBox.Text, ProfessorAddressBox.Text, ProfessorPhoneBox.Text);
                        MessageBox.Show("Professor " + id + " Updated!");
                        RefreshDataGrid();
                        ProfessorFirstNameBox.Clear();
                        ProfessorLastNameBox.Clear();
                        ProfessorFaxBox.Clear();
                        ProfessorEmailBox.Clear();
                        ProfessorAddressBox.Clear();
                        ProfessorPhoneBox.Clear();
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

        private void button12_Click(object sender, EventArgs e)
        {
            // Delete professor
            var id = 0;
            if (int.TryParse(ProfessorIDBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete professor " + id + "?", "Delete Professor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteProfessor(id);
                        MessageBox.Show("Professor " + id + " deleted successfully!");
                        RefreshDataGrid();
                        ProfessorFirstNameBox.Clear();
                        ProfessorLastNameBox.Clear();
                        ProfessorFaxBox.Clear();
                        ProfessorEmailBox.Clear();
                        ProfessorAddressBox.Clear();
                        ProfessorPhoneBox.Clear();
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

            RefreshDataGrid();
        }
    }
}



