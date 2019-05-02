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
            txtStudentID.Text = userID;
            studentsTable = database.Read("Select * From Students where ID='" + userID + "'");
            txtFirstName.Text = studentsTable.Rows[0][1].ToString();
            txtLastName.Text = studentsTable.Rows[0][2].ToString();
            txtAge.Text = studentsTable.Rows[0][3].ToString();
            txtEmail.Text = studentsTable.Rows[0][4].ToString();
            txtAddress.Text = studentsTable.Rows[0][5].ToString();
            txtPhoneNumber.Text = studentsTable.Rows[0][6].ToString();

        }

        
    }
}
