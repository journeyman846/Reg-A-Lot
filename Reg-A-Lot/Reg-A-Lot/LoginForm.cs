﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reg_A_Lot
{
    public partial class LoginForm : Form
    {
        // Person somePerson;
        Login newLogin;
        public string newUsername { get; set; }
        public string newPassword { get; set; }
        public LoginForm()
        {
            // somePerson = new Person();
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../Resources/college.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newLogin.Logon();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var newUsername = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var newPassword = password;
        }
            
                
    }

}
