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
        DataTable coursesTable = new DataTable();
        DataTable studentsTable = new DataTable();
        string courseCon = @"SELECT * FROM Courses";
        string studentCon = @"SELECT * FROM Students";
        public string userID { get; set; }
        public string userName { get; set; }
        
        

        public StudentViewForm()
        {
            InitializeComponent();
        }

        

        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            tbStudentID.Text = userID;
            tbFirstName.Text = studentsTable.Rows[0][1].ToString();
            
        }

        
    }
}
