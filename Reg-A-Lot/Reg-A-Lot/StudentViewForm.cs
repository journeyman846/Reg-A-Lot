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
        // Making sql and database connection
        SqlConnection connection = new SqlConnection();
        Database database = new Database();
        string courseCon = @"SELECT * FROM Courses";
        public string userID { get; set; }
        public string userName { get; set; }
        public StudentViewForm()
        {
            InitializeComponent();
        }

        

        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            database.Read(courseCon);
            tbStudentID.Text = userID;
        }
    }
}
