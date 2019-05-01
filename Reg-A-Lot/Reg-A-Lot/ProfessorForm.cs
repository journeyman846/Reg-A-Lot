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
    public partial class ProfessorForm : Form
    {

        public string userID { get; set; }
        public string userName { get; set; }

        private int childFormNumber = 0;

        public ProfessorForm()
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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProfessorEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtProfessorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        // Instantiation of an SQL objct and Professor object
        SqlConnection connection = new SqlConnection();
        Professor professorRegistration = new Professor();
        Database database = new Database();

        private void btnProfessorRegister_Click(object sender, EventArgs e)
        {
            // Logging of Professor information to the Professer class variable
            professorRegistration.FirstName = txtProfessorFirstName.Text;
            professorRegistration.LastName = txtProfessorLastName.Text;
            professorRegistration.Email = txtProfessorEmail.Text;
            professorRegistration.Fax = txtProfessorFax.Text;
            professorRegistration.Address = txtProfessorAddress.Text;
            professorRegistration.PhoneNumber = int.Parse(txtProfessorPhoneNumber.Text);
            professorRegistration.UserName = txtProfessorUsername.Text;
            professorRegistration.Password = txtProfessorPassword.Text;

            // Adding Professor demographics to table, and clearing text boxes
            database.InsertProfessor(professorRegistration.FirstName, professorRegistration.LastName, professorRegistration.Email, professorRegistration.Fax, professorRegistration.Address, professorRegistration.PhoneNumber);
            txtProfessorFirstName.Clear();
            txtProfessorLastName.Clear();
            txtProfessorEmail.Clear();
            txtProfessorFax.Clear();
            txtProfessorAddress.Clear();
            txtProfessorPhoneNumber.Clear();

            // Adding Professor username and password to Users table and clearing text boxes
            database.InsertUser(professorRegistration.UserName, professorRegistration.Password, "Professor");
            txtProfessorUsername.Clear();
            txtProfessorPassword.Clear();

            // Display message box of successful registration attempt and opening log in
            MessageBox.Show("Registration successful. \n Now redirecting to Log In.");
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        
    }
}
