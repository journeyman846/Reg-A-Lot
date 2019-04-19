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
    public partial class Form1 : Form
    {
        // Person somePerson;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentForm login = new StudentForm();
            this.Hide();
            login.Show();
        }
    }
}
