using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
/// <summary>
///                 THIS PART OF THE PROJECT IS NOT FINISHED!
/// </summary>
namespace Reg_A_Lot
{
    public partial class ProfessorGradeForm : Form
    {
        

        Database database = new Database();
        DataTable professorsTable = new DataTable();
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
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
        
        private void btnAddCourse_Click(object sender, EventArgs e)
        {


        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            // Asking the user if they are sure they want to drop selected course
            DialogResult dialog = MessageBox.Show("Are you sure you want to drop this course from your schedule?",
                                  "Drop Course", MessageBoxButtons.YesNo);

            // Depending on the user's selection will be the outcome of this code
            if (dialog == DialogResult.Yes)
            {
                if (cbDropCourse.SelectedItem.ToString() != null)
                {
                    string courseID = cbDropCourse.SelectedItem.ToString();
                    dropCourses = database.Read("SELECT ID FROM Registrations WHERE CourseID=" + courseID + "AND ProfessorID=" + txtProfessorID.Text);


                    // Loop pulling ID values from the Registrations Table
                    for (int i = 0; i < dropCourses.Rows.Count; i++)
                    {
                        // The actual pulling from the ID Values
                        string IDValues = dropCourses.Rows[i][0].ToString();

                        // Checking if IDValues and CourseID are a match to select correct course to drop
                        if (IDValues == IDValues && courseID == courseID)
                        {
                            // Parsing and deleting of the specified course
                            int ID = int.Parse(IDValues);
                            database.DeleteRegistration(ID);

                            // Refreshes the CoursesRegisteredTable
                            coursesTable = database.Read("Select * from Courses where ID in (SELECT CourseID FROM Registrations WHERE Professor=" + userID);
                            dgvCoursesBeingTaught.DataSource = coursesTable;
                            dgvCoursesBeingTaught.RowHeadersVisible = false;
                        }
                    }
                }
            }
            else if (dialog == DialogResult.No)
            {
                // No changes
            }
        }

        private void btnLoadSubmissions_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string courseID = cbCourseOfGrade.Text;

            loadStudentGradeSubmissions = database.Read("SELECT Grade FROM Registrations WHERE StudentID="
                                                            + studentID + "AND CourseID=" + courseID);
            if (loadStudentGradeSubmissions == null)
            {
                MessageBox.Show("Student is not registered for this course.");
            }
            else
            {
                loadStudentGradeSubmissions = database.Read("SELECT Grade FROM Registrations WHERE StudentID="
                                                            + studentID + "AND CourseID=" + courseID);
                dgvAddFinalGrades.DataSource = gradesTable;
                dgvAddFinalGrades.RowHeadersVisible = false;
            }
        }

        private void btnSubmitGrade_Click(object sender, EventArgs e)
        {
            string studentGradeID = txtStudentGradeID.Text;
            string courseID = cbCourseOfGrade.Text;

            loadStudentGradeSubmissions = database.Read("SELECT Grade FROM Registrations WHERE StudentID="
                                                            + studentGradeID + "AND CourseID=" + courseID);

            loadStudentGradeSubmissions.Rows[0][0] = txtEarnedGrade.Text;
        }
    }
}
