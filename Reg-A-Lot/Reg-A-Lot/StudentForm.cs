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


        // Instantiating a SQL object and instantiating a Student object
        SqlConnection connection = new SqlConnection();
        Student studentRegistration = new Student();
        Database database = new Database();

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
     
            // Saving the student's registration information to the Student class variables
            try
            {
                studentRegistration.FirstName = txtStudentFirstName.Text;
                studentRegistration.LastName = txtStudentLastName.Text;
                studentRegistration.Age = int.Parse(txtStudentAge.Text);
                studentRegistration.Email = txtStudentEmail.Text;
                studentRegistration.Address = txtStudentAddress.Text;
                studentRegistration.PhoneNumber = txtStudentPhoneNumber.Text;
                studentRegistration.UserName = txtStudentUserName.Text;
                studentRegistration.Password = txtStudentPassword.Text;

                // Adding the Student demographics to the Students table and clearing the text boxes
                // studentID is being returned from the InsertStudent method
                // studentID will be passed into the InsertUser table
                var studentID = database.InsertStudent(studentRegistration.FirstName, studentRegistration.LastName, studentRegistration.Age, studentRegistration.Email, studentRegistration.Address, studentRegistration.PhoneNumber);
                

                // Adding the Student UserName, Password, Role, and ID to the Users Table 
                database.InsertUser(studentRegistration.UserName, studentRegistration.Password, "Student", studentID , 0);
                
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show("There was an error, please contact your Systems Administrator.");
                Console.WriteLine("There was a ArgumentNull Exception." + ane.ToString());
            }
            catch (FormatException fe)
            {
                MessageBox.Show("There was an error, please contact your Systems Administrator.");
                Console.WriteLine("There was a Format Exception." + fe.ToString());
            }
            catch(OverflowException oe)
            {
                MessageBox.Show("There was an error, please contact your Systems Administrator." );
                Console.WriteLine("There was a Overflow Exception." + oe.ToString());
            }

            // Displaying message box of successful student registration and opening Login Form
            try
            {
                MessageBox.Show("Registration was successful! \n You are being redirected to Log in.");
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch(InvalidOperationException ioe)
            {
                MessageBox.Show("There was an error, please contact your Systems Administrator.");
                Console.WriteLine("There was a Invalid Operation Exception." + ioe.ToString());
            }
            
        }
    }
    }

