﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Reg_A_Lot
{
    public partial class StudentViewForm : Form
    {
        // Making all objects needed for the class
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Database database = new Database();
        Student studentConnect = new Student();
        StudentForm studentRegistrationForm = new StudentForm();
        DataTable coursesTable = new DataTable();
        DataTable coursesFilledTable = new DataTable();
        DataTable duplicateRegister = new DataTable();
        DataTable registerCoursesTable = new DataTable();
        DataTable registeringCourses = new DataTable();
        DataTable courseIDtransfer = new DataTable();
        DataTable dropCourses = new DataTable();
        DataTable courseIDValues = new DataTable();
        DataTable studentsTable = new DataTable();
        DataTable gradesTable = new DataTable();


        public string userID { get; set; }
        public string userName { get; set; }





        public StudentViewForm()
        {
            InitializeComponent();
        }



        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = userID;
            studentsTable = database.Read("SELECT * FROM Students WHERE ID=" + userID);

            txtFirstName.Text = studentsTable.Rows[0][1].ToString();
            txtLastName.Text = studentsTable.Rows[0][2].ToString();
            txtAge.Text = studentsTable.Rows[0][3].ToString();
            txtEmail.Text = studentsTable.Rows[0][4].ToString();
            txtAddress.Text = studentsTable.Rows[0][5].ToString();
            txtPhoneNumber.Text = studentsTable.Rows[0][6].ToString();

            // Loads Courses into the referred Course table
            registerCoursesTable = database.Read("SELECT * FROM Courses");
            dgvCourseRegisterOrDrop.DataSource = registerCoursesTable;
            dgvCourseRegisterOrDrop.RowHeadersVisible = false;

            // Loads Grades into the grade table
            gradesTable = database.Read("SELECT Grade FROM Registrations WHERE StudentID=" + userID);
            dgvViewFinalGrades.DataSource = gradesTable;
            dgvViewFinalGrades.RowHeadersVisible = false;

            // Loads Registered Courses into the registered Courses table
            coursesTable = database.Read("Select * from Courses where ID in (SELECT CourseID FROM Registrations WHERE StudentID=" + userID + " AND IsActive=1)");
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;

            // Reading the CourseID from the SQL table and using a List to 
            // populate the CourseID values to the combobox and display them 
            // to the student
            courseIDValues = database.Read("SELECT ID FROM Courses");
            List<string> cpv = new List<string>();
            for (int y = 0; y <= 6; y++)
            {

                cpv.Add(courseIDValues.Rows[y][0].ToString());

            }

            foreach (string ID in cpv)
            {
                cbSelectCourse.Items.Add(ID.ToString());
                cbDropCourse.Items.Add(ID.ToString());
            }


        }

        private void btnEditStudentInfo_Click(object sender, EventArgs e)
        {
            // Making it to where students can edit their information
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
        }

        private void btnSaveStudentInfo_Click(object sender, EventArgs e)
        {
            // Updating the Students demographics to the Student table
            database.UpdateStudent(int.Parse(userID), txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text), txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            MessageBox.Show("Information updated!");

            // Declaring the textbox values to be read-only so they can not make changes unless promping to
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
        }


        private void btnRefreshGrades_Click(object sender, EventArgs e)
        {
            // Refreshing the Students Grades
            gradesTable = database.Read("SELECT Grade FROM Registrations WHERE StudentID=" + userID);
            dgvViewFinalGrades.DataSource = gradesTable;
            dgvViewFinalGrades.RowHeadersVisible = false;

        }

        private void btnRefreshCourses_Click(object sender, EventArgs e)
        {
            // Refreshing the Students Registered Courses
            coursesTable = database.Read("Select * from Courses where ID in (SELECT CourseID FROM Registrations WHERE StudentID=" + userID + " AND IsActive=1)");
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;
        }

        // Students Register for a Course
        private void btnRegisterForCourses_Click(object sender, EventArgs e)
        {
            duplicateRegister = database.Read("SELECT CourseID FROM Registrations WHERE StudentID=" + userID);
            coursesFilledTable = database.Read("SELECT SeatsFilled FROM Courses");
            if (coursesFilledTable.Rows[0][0].ToString() == "20" || coursesFilledTable.Rows[1][0].ToString() == "15" ||
                coursesFilledTable.Rows[2][0].ToString() == "33" || coursesFilledTable.Rows[3][0].ToString() == "20" ||
                coursesFilledTable.Rows[4][0].ToString() == "15" || coursesFilledTable.Rows[5][0].ToString() == "19" || 
                coursesFilledTable.Rows[6][0].ToString() == "20")
            {

                // Displaying if seats are full
                MessageBox.Show("You cannot register for this course, the seats are filled.");


                for (int i = 0; i <= 6; i++)
                {
                    string duplicates = duplicateRegister.Rows[i][0].ToString();

                    // checking for potential duplicates
                    if(duplicates == "230" || duplicates == "260" || duplicates == "270" || 
                       duplicates == "280" || duplicates == "290" || duplicates == "300" ||
                       duplicates == "320")
                    {
                        // Displaying if they've registered that course already
                        MessageBox.Show("You have already registered for this course.");
                    }
                }
            }
            else
            {
                var newUserID = int.Parse(userID);
                var newCourseID = int.Parse(cbSelectCourse.Text);
                database.InsertRegistration(newUserID, newCourseID, "", true);
            }
        }

        // Students Drop a Course
        private void btnDropCourses_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to drop this course?",
                                  "Drop Course", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (cbDropCourse.SelectedItem.ToString() != null)
                {
                    int courseID = int.Parse(cbDropCourse.SelectedItem.ToString());
                    database.DeleteRegistration(courseID);
                }
            }
            else if (dialog == DialogResult.No)
            {
                // No changes
            }
        }
    }
}
