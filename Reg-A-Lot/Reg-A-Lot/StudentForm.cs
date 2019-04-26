using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Reg_A_Lot
{

    public partial class StudentForm : Form
    {
        private int childFormNumber = 0;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        // Instantiating a SQL object
        SqlConnection connection = new SqlConnection();
        // Instantiating a Student object
        Student studentRegistration = new Student();

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            // Saving the student's registration information to the Student class variables
            studentRegistration.FirstName = txtStudentFirstName;
            studentRegistration.LastName = txtStudentLastName;
            studentRegistration.Age = txtStudentAge;
            studentRegistration.Email = txtStudentEmail;
            studentRegistration.Address = txtStudentAddress;
            studentRegistration.PhoneNumber = txtStudentPhoneNumber;


            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\reg_db.mdf; Integrated Security = True";
            connection.Open();

            using (SqlCommand insertNewStudent = connection.CreateCommand())
            {
                insertNewStudent.CommandText = "insert into dbo.Student (\"FirstName\", \"LastName\", \"Age\", \"Email\", \"Address\", \"PhoneNumber\") values (@FName, @LName, @Age, @Email, @Address, @PhoneNumber);";
                insertNewStudent.Parameters.Add(new SqlParameter("FName", studentRegistration.FirstName));
                insertNewStudent.Parameters.Add(new SqlParameter("LName", studentRegistration.LastName));
                insertNewStudent.Parameters.Add{ new SqlParameter("Age", studentRegistration.Age);
                    insertNewStudent.Parameters.Add(new SqlParameter("Email", studentRegistration.Email));
                    insertNewStudent.Parameters.Add(new SqlParameter("Address", studentRegistration.Address));
                    insertNewStudent.Parameters.Add(new SqlParameter("PhoneNumber", studentRegistration.PhoneNumber));
                    insertNewStudent.ExecuteNonQuery();
                }


            }
        }
    }
}
