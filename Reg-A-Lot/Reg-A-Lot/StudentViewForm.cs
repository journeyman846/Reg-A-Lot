using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reg_A_Lot
{
    public partial class StudentViewForm : Form
    {
        public string userID { get; set; }
        public string userName { get; set; }
        public StudentViewForm()
        {
            InitializeComponent();
        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            studentIDBox.Text = userID;
        }
    }
}
