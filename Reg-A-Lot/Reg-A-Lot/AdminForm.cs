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
    public partial class AdminForm : Form
    {
        private int childFormNumber = 0;
        Database database = new Database();
        DataTable userTable = new DataTable();
        DataTable courseTable = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public AdminForm()
        {
            InitializeComponent();
            RefreshDataGrid();


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

        private void searchButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    userTable = database.Read("Select * From Users where ID='" + id + "'");
                    usernameBox.Text = userTable.Rows[0][1].ToString();
                    passwordBox.Text = userTable.Rows[0][2].ToString();
                    roleBox.Text = userTable.Rows[0][3].ToString();
                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }

            }
            else
            {
                MessageBox.Show("That is not a valid ID number.");
            }


        }
        private void RefreshDataGrid()
        {
            userTable = database.Read("Select * From Users");
            courseTable = database.Read("Select * From Courses");
            dataGridView1.DataSource = userTable;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.DataSource = courseTable;
            dataGridView2.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.InsertUser(usernameBox.Text, passwordBox.Text, roleBox.Text);
            MessageBox.Show("User added successfully!");
            RefreshDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete user " + id + "?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        database.DeleteUser(id);
                        MessageBox.Show("User " + id + " Deleted!");
                        RefreshDataGrid();
                    }


                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }
            }
            else
            {
                MessageBox.Show("That is not a valid ID number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = 0;
            if (int.TryParse(idBox.Text, out id))
            {
                try
                {
                    database.UpdateUser(usernameBox.Text, passwordBox.Text, roleBox.Text, id);
                    MessageBox.Show("User " + id + " Updated!");
                    RefreshDataGrid();
                }
                catch
                {
                    MessageBox.Show("ID not found.");
                }
            }
            else
            {
                MessageBox.Show("That is not a valid ID number.");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var courseID = 0;
            var courseNumber = 0;
            if (int.TryParse(CourseIDBox.Text, out courseID))
            {
                
                if (int.TryParse(CourseNumberBox.Text, out courseNumber))
                {
                    database.InsertCourse(courseID, CoursePrefixBox.Text, courseNumber, CourseNameBox.Text, CourseTimesBox.Text, CourseSeatsBox.Text, CourseProfessorBox.Text);
                }
                else
                {
                    MessageBox.Show("Course Number must be a number");
                }
                   
            }
            else
            {
                MessageBox.Show("Course ID must be a number");
            }

            MessageBox.Show("Course added successfully!");
            RefreshDataGrid();

        }
    }
    
}
