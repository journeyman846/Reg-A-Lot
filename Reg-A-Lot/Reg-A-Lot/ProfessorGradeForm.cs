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
    public partial class ProfessorGradeForm : Form
    {
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblEarnedPoints_Click(object sender, EventArgs e)
        {

        }

        Database database = new Database();
        DataTable professorsTable = new DataTable();
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        Professor professorConnect = new Professor();
        ProfessorForm professorRegistrationForm = new ProfessorForm();
        DataTable coursesTable = new DataTable();
        DataTable coursesFilledTable = new DataTable();
        DataTable duplicateRegister = new DataTable();
        DataTable registerCoursesTable = new DataTable();
        DataTable registeringCourses = new DataTable();
        DataTable loadStudentGradeSubmissions = new DataTable();
        DataTable dropCourses = new DataTable();
        DataTable courseIDValues = new DataTable();
        DataTable studentsTable = new DataTable();
        DataTable gradesTable = new DataTable();

        public string userID { get; set; }
        public string userName { get; set; }

        public ProfessorGradeForm()
        {
            InitializeComponent();
        }
       

        private void RefreshDataGrid()
        {
            professorsTable = database.Read("Select * From Professors");
            dgvCoursesBeingTaught.DataSource = professorsTable;
            dgvCoursesBeingTaught.RowHeadersVisible = false;
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to drop this course?",
                                  "Drop Course", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (cbAddCourse.SelectedItem.ToString() != null)
                {
                    int courseID = int.Parse(cbAddCourse.SelectedItem.ToString());
                    database.DeleteRegistration(courseID);
                }
            }
            else if (dialog == DialogResult.No)
            {
                // No changes
            }
        }

        private void ProfessorGradeForm_Load(object sender, EventArgs e)
        {
            txtProfessorID.Text = userID;
            var lastName = database.Read("SELECT LastName FROM Professors WHERE ID=" + userID);
            professorsTable = database.Read("SELECT * from Courses WHERE Professor='" + lastName.Rows[0][0].ToString() + "'");
            dgvCoursesBeingTaught.DataSource = professorsTable;

            //// Loads Registered Courses into the registered Courses table
            //coursesTable = database.Read("Select * from Courses where ID in (SELECT CourseID FROM Registrations WHERE ProfessorID=" + userID + " AND IsActive=1)");
            //dgvCoursesBeingTaught.DataSource = registerCoursesTable;
            //dgvCoursesBeingTaught.RowHeadersVisible = false;

            

            // Reading the CourseID from the SQL table and using a List to 
            // populate the CourseID values to the needed combobox's and 
            // display them to the professor
            courseIDValues = database.Read("SELECT ID FROM Courses");
            List<string> cpv = new List<string>();
            for (int y = 0; y <= 6; y++)
            {

                cpv.Add(courseIDValues.Rows[y][0].ToString());

            }

            foreach (string ID in cpv)
            {
                cbAddCourse.Items.Add(ID.ToString());
                cbDropCourse.Items.Add(ID.ToString());
                cbCourseOfGrade.Items.Add(ID.ToString());
                cbCourseGrade.Items.Add(ID.ToString());
            }
        }

        private void btnLoadSubmissions_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string courseID = cbCourseOfGrade.Text;
            loadStudentGradeSubmissions = database.Read("SELECT Grade FROM Registrations WHERE StudentID=" 
                                                        + studentID + "AND CourseID=" + courseID + 
                                                        "AND SELECT Professor FROM Courses WHERE CourseID=" 
                                                        + courseID);
            dgvAddFinalGrades.DataSource = gradesTable;
            dgvAddFinalGrades.RowHeadersVisible = false;
        }

        private void btnSubmitGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
