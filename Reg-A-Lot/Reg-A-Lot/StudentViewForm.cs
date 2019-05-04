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

            registerCoursesTable = database.Read("SELECT * FROM Courses");
            dgvCourseRegisterOrDrop.DataSource = registerCoursesTable;
            dgvCourseRegisterOrDrop.RowHeadersVisible = false;


            courseIDValues = database.Read("SELECT ID FROM Courses");
            List<string> cpv = new List<string>();
            for (int y = 0; y <= 6; y++)
            {
                
                cpv.Add(courseIDValues.Rows[y][0].ToString());
                
            }
            
            foreach (string ID in cpv)
            {
                cbSelectCourse.Items.Add(ID.ToString());
                cbDropCourses.Items.Add(ID.ToString());
            }


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
            gradesTable = database.Read("SELECT Grade FROM Registrations WHERE StudentID=" + userID);
            dgvViewFinalGrades.DataSource = gradesTable;
            dgvViewFinalGrades.RowHeadersVisible = false;
            
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            // coursesTable = database.Read("SELECT CourseID FROM Registrations WHERE StudentID=" + userID);
            coursesTable = database.Read("Select * from Courses where ID in (SELECT CourseID FROM Registrations WHERE StudentID=" + userID+ " AND IsActive='Y')");
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;
        }

        private void btnRegisterForCourses_Click(object sender, EventArgs e)
        {
            registeringCourses = database.Read("SELECT ID FROM Courses");
            courseIDtransfer = database.Read("SELECT CourseID FROM Registration");

            if(cbSelectCourse.Text == "230")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[1][0];
            }
            else if(cbSelectCourse.Text == "260")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[2][0];
            }
            else if (cbSelectCourse.Text == "270")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[3][0];
            }
            else if (cbSelectCourse.Text == "280")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[4][0];
            }
            else if (cbSelectCourse.Text == "290")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[5][0];
            }
            else if (cbSelectCourse.Text == "300")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[6][0];
            }
            else if(cbSelectCourse.Text == "320")
            {
                courseIDtransfer.Rows[1][0] = registeringCourses.Rows[7][0];
            }
        }
    }
}
