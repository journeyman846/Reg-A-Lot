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
        // Declaring any variables, Datatables, and objects needed for the class
        Database database = new Database();
        DataTable userTable = new DataTable();
        DataTable courseTable = new DataTable();
        DataTable studentTable = new DataTable();
        DataTable professorTable = new DataTable();
        DataTable registrationTable = new DataTable();
        SqlCommand cmd = new SqlCommand();
        public string userID { get; set; }
        public string userName { get; set; }
        LoginForm loginForm = new LoginForm();


        public AdminForm()
        {

            InitializeComponent();
            RefreshDataGrid();
            // The below code populates the drop down for the courses form
            courseProfessorBox.DataSource = professorTable;
            courseProfessorBox.ValueMember = "ID";
            courseProfessorBox.DisplayMember = "LastName";

        }
        private void RefreshDataGrid()
        {
            // Read from the database and fill the datagrids for each table
            // Calls to this method will refresh the grids
            userTable = database.Read("Select * From Users");
            courseTable = database.Read("Select * From Courses");
            studentTable = database.Read("Select * From Students");
            professorTable = database.Read("Select * From Professors");
            registrationTable = database.Read("Select * From Registrations");

            userGridView.DataSource = userTable;
            userGridView.RowHeadersVisible = false;
            courseGridView.DataSource = courseTable;
            courseGridView.RowHeadersVisible = false;
            studentGridView.DataSource = studentTable;
            studentGridView.RowHeadersVisible = false;
            professorGridView.DataSource = professorTable;
            professorGridView.RowHeadersVisible = false;
            regGridView.DataSource = registrationTable;
            regGridView.RowHeadersVisible = false;
        }

        private void searchUserButton_Click(object sender, EventArgs e)
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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // Add a user
            database.InsertUser(usernameBox.Text, passwordBox.Text, roleBox.Text, 0, 0);
            MessageBox.Show("User added successfully!");
            RefreshDataGrid();
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Delete a user
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

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            // Update user
            var id = 0;
            var userID = 0;



            if (int.TryParse(idBox.Text, out id))
            {
                if (roleBox.Text != "Administrator")
                {
                    if (int.TryParse(userIDBox.Text, out userID))
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
                        MessageBox.Show("Please enter a valid User ID number.");
                    }
                }
                else
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

            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }

        }

        

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            // add course
            var courseNumber = 0;
            var coursePrice = 0.0;
            var isActive = false;
            if (yesRadioButton.Checked)
            {
                isActive = true;
            }
            else if (noRadioButton.Checked)
            {
                isActive = false;
            }

            if (int.TryParse(courseNumberBox.Text, out courseNumber))
            {
                if (double.TryParse(coursePriceBox.Text, out coursePrice))
                {
                    database.InsertCourse(coursePrefixBox.Text, courseNumber, courseNameBox.Text, courseTimesBox.Text, courseSeatsBox.Text, courseProfessorBox.Text, coursePrice, isActive);
                    MessageBox.Show("Course added successfully!");
                    courseIDBox2.Clear();
                    coursePrefixBox.Clear();
                    courseNumberBox.Clear();
                    courseNameBox.Clear();
                    courseTimesBox.Clear();
                    courseSeatsBox.Clear();
                    // CourseProfessorBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Course Price");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.");
            }





            RefreshDataGrid();

        }

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            // update course 
            var id = 0;
            var courseNumber = 0;
            var coursePrice = 0.0;
            var isActive = false;
            if (yesRadioButton.Checked)
            {
                isActive = true;
            }
            else if (noRadioButton.Checked)
            {
                isActive = false;
            }
            if (int.TryParse(courseIDBox1.Text, out id))
            {
                if (int.TryParse(courseNumberBox.Text, out courseNumber))
                {
                    if (double.TryParse(coursePriceBox.Text, out coursePrice))
                    {
                        try
                        {
                            database.UpdateCourse(id, coursePrefixBox.Text, courseNumber, courseNameBox.Text, courseTimesBox.Text, courseSeatsBox.Text, courseProfessorBox.Text, coursePrice, isActive);
                            MessageBox.Show("Course " + id + " Updated!");
                            RefreshDataGrid();
                            courseIDBox2.Clear();
                            coursePrefixBox.Clear();
                            courseNumberBox.Clear();
                            courseNameBox.Clear();
                            courseTimesBox.Clear();
                            courseSeatsBox.Clear();
                            coursePriceBox.Clear();
                        // CourseProfessorBox.Items.Clear();
                    }
                        catch
                    {
                        MessageBox.Show("ID not found.");
                    }
                }
                    else
                    {
                        MessageBox.Show("Invalid Course Price");
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

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {
            // delete course
            var id = 0;
            if (int.TryParse(courseIDBox1.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete course " + id + "?", "Delete Course", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteCourse(id);
                        MessageBox.Show("Course " + id + " deleted successfully!");
                        RefreshDataGrid();
                        courseIDBox2.Clear();
                        coursePrefixBox.Clear();
                        courseNumberBox.Clear();
                        courseNameBox.Clear();
                        courseTimesBox.Clear();
                        courseSeatsBox.Clear();
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

        private void searchCourseButton_Click(object sender, EventArgs e)
        {
            // search courses
            var id = 0;
            if (int.TryParse(courseIDBox1.Text, out id))
            {
                try
                {
                    courseTable = database.Read("Select * From courses where ID='" + id + "'");
                    courseIDBox2.Text = courseTable.Rows[0][0].ToString();
                    coursePrefixBox.Text = courseTable.Rows[0][1].ToString();
                    courseNumberBox.Text = courseTable.Rows[0][2].ToString();
                    courseNameBox.Text = courseTable.Rows[0][3].ToString();
                    courseTimesBox.Text = courseTable.Rows[0][4].ToString();
                    courseSeatsBox.Text = courseTable.Rows[0][5].ToString();
                    courseProfessorBox.Text = courseTable.Rows[0][6].ToString();
                    coursePriceBox.Text = courseTable.Rows[0][7].ToString();
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

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            // Insert Student
            var age = 0;

            if (int.TryParse(studentAgeBox.Text, out age))
            {
                database.InsertStudent(studentFirstNameBox.Text, studentLastNameBox.Text, age, studentEmailBox.Text, studentAddressBox.Text, studentPhoneBox.Text);
                studentFirstNameBox.Clear();
                studentLastNameBox.Clear();
                studentAgeBox.Clear();
                studentEmailBox.Clear();
                studentAddressBox.Clear();
                studentPhoneBox.Clear();



                MessageBox.Show("Student added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
            RefreshDataGrid();

        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            // Update Student
            var id = 0;
            var age = 0;
            if (int.TryParse(studentIDBox.Text, out id))
            {
                if (int.TryParse(studentAgeBox.Text, out age))
                {
                    try
                    {
                        database.UpdateStudent(id, studentFirstNameBox.Text, studentLastNameBox.Text, age, studentEmailBox.Text, studentAddressBox.Text, studentPhoneBox.Text);
                        MessageBox.Show("Student " + id + " Updated!");
                        RefreshDataGrid();
                        studentFirstNameBox.Clear();
                        studentLastNameBox.Clear();
                        studentAgeBox.Clear();
                        studentEmailBox.Clear();
                        studentAddressBox.Clear();
                        studentPhoneBox.Clear();
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

        private void studentSearchButton_Click(object sender, EventArgs e)
        {
            // Student search 
            var id = 0;
            if (int.TryParse(studentIDBox.Text, out id))
            {
                try
                {
                    studentTable = database.Read("Select * From students where ID='" + id + "'");
                    studentIDBox.Text = studentTable.Rows[0][0].ToString();
                    studentFirstNameBox.Text = studentTable.Rows[0][1].ToString();
                    studentLastNameBox.Text = studentTable.Rows[0][2].ToString();
                    studentAgeBox.Text = studentTable.Rows[0][3].ToString();
                    studentEmailBox.Text = studentTable.Rows[0][4].ToString();
                    studentAddressBox.Text = studentTable.Rows[0][5].ToString();
                    studentPhoneBox.Text = studentTable.Rows[0][6].ToString();
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

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            // delete student 
            var id = 0;
            if (int.TryParse(studentIDBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete student " + id + "?", "Delete Student", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteStudent(id);
                        MessageBox.Show("Student " + id + " deleted successfully!");
                        RefreshDataGrid();
                        studentFirstNameBox.Clear();
                        studentLastNameBox.Clear();
                        studentAgeBox.Clear();
                        studentEmailBox.Clear();
                        studentAddressBox.Clear();
                        studentPhoneBox.Clear();
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

        private void addProfessorButton_Click(object sender, EventArgs e)
        {
            // Add professor
            database.InsertProfessor(professorFirstNameBox.Text, professorLastNameBox.Text, professorEmailBox.Text, professorFaxBox.Text, professorAddressBox.Text, professorPhoneBox.Text);
            MessageBox.Show("Professor added successfully");
            RefreshDataGrid();
            professorFirstNameBox.Clear();
            professorLastNameBox.Clear();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // This just updates the username on the status strip at the bottom
            toolStripStatusLabel.Text = "UserID: " + userID + " Username: " + userName;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When the form is closed redirect to the main form--final product should go back to login
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void searchProfessorButton_Click(object sender, EventArgs e)
        {
            //Search for professor
            var id = 0;
            if (int.TryParse(professorIDBox.Text, out id))
            {
                try
                {
                    professorTable = database.Read("Select * From professors where ID='" + id + "'");

                    professorFirstNameBox.Text = professorTable.Rows[0][1].ToString();
                    professorLastNameBox.Text = professorTable.Rows[0][2].ToString();
                    professorEmailBox.Text = professorTable.Rows[0][3].ToString();
                    professorFaxBox.Text = professorTable.Rows[0][4].ToString();
                    professorAddressBox.Text = professorTable.Rows[0][5].ToString();
                    professorPhoneBox.Text = professorTable.Rows[0][6].ToString();
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

        private void updateProfessorButton_Click(object sender, EventArgs e)
        {
            // Update professor
            var id = 0;

            if (int.TryParse(professorIDBox.Text, out id))
            {

                try
                {
                    database.UpdateProfessor(id, professorFirstNameBox.Text, professorLastNameBox.Text, professorEmailBox.Text, professorFaxBox.Text, professorAddressBox.Text, professorPhoneBox.Text);
                    MessageBox.Show("Professor " + id + " Updated!");
                    RefreshDataGrid();
                    professorFirstNameBox.Clear();
                    professorLastNameBox.Clear();
                    professorFaxBox.Clear();
                    professorEmailBox.Clear();
                    professorAddressBox.Clear();
                    professorPhoneBox.Clear();
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

        private void deleteProfessorButton_Click(object sender, EventArgs e)
        {
            // Delete professor
            var id = 0;
            if (int.TryParse(professorIDBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete professor " + id + "?", "Delete Professor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteProfessor(id);
                        MessageBox.Show("Professor " + id + " deleted successfully!");
                        RefreshDataGrid();
                        professorFirstNameBox.Clear();
                        professorLastNameBox.Clear();
                        professorFaxBox.Clear();
                        professorEmailBox.Clear();
                        professorAddressBox.Clear();
                        professorPhoneBox.Clear();
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

        private void addRegistrationButton_Click(object sender, EventArgs e)
        {
            // Add Registration
            var studentID = 0;
            var courseID = 0;
            if (int.TryParse(regStudentIDBox.Text, out studentID))
            {
                if (int.TryParse(regCourseIDBox.Text, out courseID))
                {
                    database.InsertRegistration(studentID, courseID, regGradeBox.Text);

                    MessageBox.Show("Registration added successfully");
                }
                else
                {
                    MessageBox.Show("Course ID was invalid. Try Again.");
                }
            }
            else
            {
                MessageBox.Show("Student ID was invalid. Try Again.");
            }
            RefreshDataGrid();
            regStudentIDBox.Clear();
            regCourseIDBox.Clear();
        }

        private void updateRegistrationButton_Click(object sender, EventArgs e)
        {
            // update registration
            var id = 0;
            var studentID = 0;
            var courseID = 0;
            

            if (int.TryParse(regIDBox.Text, out id))
            {
                if (int.TryParse(regStudentIDBox.Text, out studentID))
                {
                    if (int.TryParse(regCourseIDBox.Text, out courseID))
                    {
                        database.UpdateRegistration(studentID, courseID, regGradeBox.Text, id);
                        MessageBox.Show("Registration updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Course ID was invalid. Try Again.");
                    }
                }
                else
                {
                    MessageBox.Show("Student ID was invalid. Try Again.");
                }
                RefreshDataGrid();
                regStudentIDBox.Clear();
                regCourseIDBox.Clear();
            }
        }


        private void deleteRegistrationButton_Click(object sender, EventArgs e)
        {
            // Delete Registration
            var id = 0;
            if (int.TryParse(regIDBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete registration " + id + "?", "Delete Professor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteRegistration(id);
                        MessageBox.Show("Registraion " + id + " deleted successfully!");
                        RefreshDataGrid();
                        regIDBox.Clear();
                        regStudentIDBox.Clear();
                        regCourseIDBox.Clear();
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

        private void button18_Click(object sender, EventArgs e)
        {
            // Registraion search 
            var id = 0;
            if (int.TryParse(regIDBox.Text, out id))
            {
                try
                {
                    studentTable = database.Read("Select * From Registrations where ID='" + id + "'");
                    regStudentIDBox.Text = registrationTable.Rows[0][1].ToString();
                    regCourseIDBox.Text = registrationTable.Rows[0][2].ToString();
                    regGradeBox.Text = registrationTable.Rows[0][3].ToString();
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



