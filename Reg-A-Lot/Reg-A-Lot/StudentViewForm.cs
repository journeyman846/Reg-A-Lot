using System;
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
        DataTable studentsTable = new DataTable();
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
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();



        }

        private void btnSaveStudentInfo_Click(object sender, EventArgs e)
        {
            database.UpdateStudent(int.Parse(txtStudentID.Text), txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text), txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
        }

        private void btnLoadGrades_Click(object sender, EventArgs e)
        {
            coursesTable = database.Read("Select Grades From Courses where StudentID=" + userID);
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;
            
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            studentsTable = database.Read("Select Courses From Registration where StudentID=" + userID);
            dgvViewFinalGrades.DataSource = studentsTable;
            dgvViewFinalGrades.DataSource = studentsTable;
            dgvViewFinalGrades.RowHeadersVisible = false;
        }
    }
}
