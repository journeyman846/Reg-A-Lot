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

        Database database = new Database();
        DataTable professorsTable = new DataTable();

        private void RefreshDataGrid()
        {
            professorsTable = database.Read("Select * From Professors");
            dataGridView1.DataSource = professorsTable;
            dataGridView1.RowHeadersVisible = false;



        }

        public ProfessorGradeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadSubmissions_Click(object sender, EventArgs e)
        {

        }
    }
}
