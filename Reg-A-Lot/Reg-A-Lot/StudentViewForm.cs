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
        DataTable registeringCoursesTable = new DataTable();
        DataTable coursePrefixValues = new DataTable();
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


            coursePrefixValues = database.Read("SELECT CoursePrefix FROM Courses");
            List<string> cpv = new List<string>();
            for (int y = 0; y <= 6; y++)
            {
                
                cpv.Add(coursePrefixValues.Rows[y][0].ToString());
                
            }
            
            foreach (string prefix in cpv)
            {
                cbSelectCourse.Items.Add(prefix.ToString());
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
            coursesTable = database.Read("SELECT CourseID FROM Registrations WHERE StudentID=" + userID);
            dgvStudentViewRegisteredCourses.DataSource = coursesTable;
            dgvStudentViewRegisteredCourses.RowHeadersVisible = false;
        }

        //private void dgvCourseRegisterOrDrop_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if(e.Button == MouseButtons.Left)
        //    {
        //        DataGridView.HitTestInfo info = dgvCourseRegisterOrDrop.HitTest(e.X, e.Y);
        //        if (info.RowIndex >= 0)
        //        {
        //            if (info.RowIndex >= 0 && info.ColumnIndex >= 0)
        //            {
        //                string text = (string)
        //                    dgvCourseRegisterOrDrop.Rows[info.RowIndex].Cells[info.ColumnIndex].Value;
        //                if (text != null)
        //                    dgvCourseRegisterOrDrop.DoDragDrop(text, DragDropEffects.Copy);
        //            }
        //        }


        //    }


        //}

        //private void dgvRegisteringTable_DragDrop(object sender, DragEventArgs e)
        //{
        //    string cellvalue = e.Data.GetData(typeof(string)) as string;
        //    Point cursorLocation = this.PointToClient(new Point(e.X, e.Y));

        //    System.Windows.Forms.DataGridView.HitTestInfo hittest = dgvRegisteringTable.HitTest(cursorLocation.X, cursorLocation.Y);
        //    if (hittest.ColumnIndex != -1
        //        && hittest.RowIndex != -1)
        //        dgvRegisteringTable[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;
        //}

        //private void dgvRegisteringTable_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}

        private void btnLoadCoursesAvailable_Click(object sender, EventArgs e)
        {
            registerCoursesTable = database.Read("SELECT * FROM Courses");
            dgvCourseRegisterOrDrop.DataSource = registerCoursesTable;
            dgvCourseRegisterOrDrop.RowHeadersVisible = false;

            

            registeringCoursesTable = database.Read("SELECT CourseID FROM Registrations WHERE StudentID=" + userID);
            dgvRegisteringTable.DataSource = registeringCoursesTable;
            dgvRegisteringTable.RowHeadersVisible = false;
        }
        

        
    }
}
