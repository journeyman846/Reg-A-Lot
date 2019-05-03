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
        DataTable registerCoursesTable = new DataTable();
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
            studentsTable = database.Read("SELECT * FROM Students WHERE ID='" + userID + "'");

            txtFirstName.Text = studentsTable.Rows[0][1].ToString();
            txtLastName.Text = studentsTable.Rows[0][2].ToString();
            txtAge.Text = studentsTable.Rows[0][3].ToString();
            txtEmail.Text = studentsTable.Rows[0][4].ToString();
            txtAddress.Text = studentsTable.Rows[0][5].ToString();
            txtPhoneNumber.Text = studentsTable.Rows[0][6].ToString();

        }

        private void btnEditStudentInfo_Click(object sender, EventArgs e)
        {
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
        }

        private void btnSaveStudentInfo_Click(object sender, EventArgs e)
        {
            database.UpdateStudent(int.Parse(userID), txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text), txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            MessageBox.Show("Information updated!");
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtAge.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
        }


        private void btnLoadGrades_Click(object sender, EventArgs e)
        {
            gradesTable = database.Read("Select Grades From Courses where StudentID=" + userID);
            dgvStudentViewRegisteredCourses.DataSource = gradesTable;
            dgvStudentViewRegisteredCourses.DataSource = gradesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;
            
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            coursesTable = database.Read("Select Courses From Registration where StudentID=" + "5000");
            dgvViewFinalGrades.DataSource = coursesTable;
            dgvViewFinalGrades.DataSource = coursesTable;
            dgvViewFinalGrades.RowHeadersVisible = false;
        }

        private void btnLoadCoursesAvailable_Click(object sender, EventArgs e)
        {
            registerCoursesTable = database.Read("Select * From Courses");
            dgvCourseRegisterOrDrop.DataSource = registerCoursesTable;
            dgvCourseRegisterOrDrop.RowHeadersVisible = false;
        }
    }
}
