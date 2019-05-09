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
        // Declaring any variables needed for this class
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


        // Instantiation of an SQL objct and Professor object
        SqlConnection connection = new SqlConnection();
        Database database = new Database();

        private void btnProfessorRegister_Click(object sender, EventArgs e)
        {
            
            // Adding Professor demographics to table, and clearing text boxes
            var professorID = database.InsertProfessor(txtProfessorFirstName.Text, txtProfessorLastName.Text, txtProfessorEmail.Text, txtProfessorFax.Text, txtProfessorEmail.Text, txtProfessorPhoneNumber.Text);
            txtProfessorFirstName.Clear();
            txtProfessorLastName.Clear();
            txtProfessorEmail.Clear();
            txtProfessorFax.Clear();
            txtProfessorAddress.Clear();
            txtProfessorPhoneNumber.Clear();

            // Adding Professor username and password to Users table and clearing text boxes
            database.InsertUser(txtProfessorUsername.Text, txtProfessorPassword.Text, "Professor", 0, professorID);
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
