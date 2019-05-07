namespace Reg_A_Lot
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.regdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userEditTab = new System.Windows.Forms.TabPage();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.courseEditTab = new System.Windows.Forms.TabPage();
            this.courseIDBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.courseTimesBox = new System.Windows.Forms.TextBox();
            this.courseSeatsBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.courseProfessorBox = new System.Windows.Forms.ComboBox();
            this.deleteCourseButton = new System.Windows.Forms.Button();
            this.courseIDBox1 = new System.Windows.Forms.TextBox();
            this.updateCourseButton = new System.Windows.Forms.Button();
            this.searchCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.coursePrefixBox = new System.Windows.Forms.TextBox();
            this.courseNumberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.studentEditTab = new System.Windows.Forms.TabPage();
            this.studentFirstNameBox = new System.Windows.Forms.TextBox();
            this.StudentFirstNameLabel = new System.Windows.Forms.Label();
            this.studentEmailBox = new System.Windows.Forms.TextBox();
            this.studentPhoneBox = new System.Windows.Forms.TextBox();
            this.StudentEmailLabel = new System.Windows.Forms.Label();
            this.StudentPhoneLabel = new System.Windows.Forms.Label();
            this.StudentAddressLabel = new System.Windows.Forms.Label();
            this.studentAddressBox = new System.Windows.Forms.TextBox();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.studentSearchButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentLastNameBox = new System.Windows.Forms.TextBox();
            this.studentAgeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.StudentAgeLabel = new System.Windows.Forms.Label();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.professorEditTab = new System.Windows.Forms.TabPage();
            this.professorAddressBox = new System.Windows.Forms.TextBox();
            this.ProfessorAddressLabel = new System.Windows.Forms.Label();
            this.professorPhoneBox = new System.Windows.Forms.TextBox();
            this.ProfessorPhoneLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.professorEmailBox = new System.Windows.Forms.TextBox();
            this.ProfessorEmailLabel = new System.Windows.Forms.Label();
            this.professorFaxBox = new System.Windows.Forms.TextBox();
            this.ProfessorFaxLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.professorFirstNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteProfessorButton = new System.Windows.Forms.Button();
            this.professorIDBox = new System.Windows.Forms.TextBox();
            this.updateProfessorButton = new System.Windows.Forms.Button();
            this.searchProfessorButton = new System.Windows.Forms.Button();
            this.addProfessorButton = new System.Windows.Forms.Button();
            this.professorLastNameBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.professorGridView = new System.Windows.Forms.DataGridView();
            this.registrationEditTab = new System.Windows.Forms.TabPage();
            this.regGradeBox = new System.Windows.Forms.ComboBox();
            this.regIsActiveBox = new System.Windows.Forms.ComboBox();
            this.regIsActiveLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.regStudentIDBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.deleteRegistrationButton = new System.Windows.Forms.Button();
            this.regIDBox = new System.Windows.Forms.TextBox();
            this.updateRegistrationButton = new System.Windows.Forms.Button();
            this.searchRegistrationButton = new System.Windows.Forms.Button();
            this.addRegistrationButton = new System.Windows.Forms.Button();
            this.regCourseIDBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.regGridView = new System.Windows.Forms.DataGridView();
            this.coursePriceBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.userEditTab.SuspendLayout();
            this.courseEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.studentEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.professorEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).BeginInit();
            this.registrationEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(541, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(210, 7);
            this.idBox.MaxLength = 5;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(102, 20);
            this.idBox.TabIndex = 4;
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(222, 33);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(75, 23);
            this.searchUserButton.TabIndex = 5;
            this.searchUserButton.Text = "Search";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // reg_dbDataSet
            // 
            this.reg_dbDataSet.DataSetName = "reg_dbDataSet";
            this.reg_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regdbDataSetBindingSource
            // 
            this.regdbDataSetBindingSource.DataSource = this.reg_dbDataSet;
            this.regdbDataSetBindingSource.Position = 0;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(141, 85);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 9;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(141, 111);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(79, 88);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AllowUserToOrderColumns = true;
            this.userGridView.AllowUserToResizeColumns = false;
            this.userGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.userGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(6, 219);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.userGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userGridView.Size = new System.Drawing.Size(518, 174);
            this.userGridView.TabIndex = 16;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(141, 190);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(222, 190);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(75, 23);
            this.updateUserButton.TabIndex = 19;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(303, 190);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 20;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userEditTab);
            this.tabControl1.Controls.Add(this.courseEditTab);
            this.tabControl1.Controls.Add(this.studentEditTab);
            this.tabControl1.Controls.Add(this.professorEditTab);
            this.tabControl1.Controls.Add(this.registrationEditTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 425);
            this.tabControl1.TabIndex = 22;
            // 
            // userEditTab
            // 
            this.userEditTab.BackColor = System.Drawing.Color.Gray;
            this.userEditTab.Controls.Add(this.userIDBox);
            this.userEditTab.Controls.Add(this.label12);
            this.userEditTab.Controls.Add(this.roleBox);
            this.userEditTab.Controls.Add(this.userGridView);
            this.userEditTab.Controls.Add(this.deleteUserButton);
            this.userEditTab.Controls.Add(this.idBox);
            this.userEditTab.Controls.Add(this.updateUserButton);
            this.userEditTab.Controls.Add(this.searchUserButton);
            this.userEditTab.Controls.Add(this.addUserButton);
            this.userEditTab.Controls.Add(this.usernameBox);
            this.userEditTab.Controls.Add(this.passwordBox);
            this.userEditTab.Controls.Add(this.label1);
            this.userEditTab.Controls.Add(this.label3);
            this.userEditTab.Controls.Add(this.Username);
            this.userEditTab.Controls.Add(this.label2);
            this.userEditTab.Location = new System.Drawing.Point(4, 22);
            this.userEditTab.Name = "userEditTab";
            this.userEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.userEditTab.Size = new System.Drawing.Size(530, 399);
            this.userEditTab.TabIndex = 0;
            this.userEditTab.Text = "User Edit";
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(292, 85);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(100, 20);
            this.userIDBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID";
            // 
            // roleBox
            // 
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Student",
            "Staff",
            "Administrator"});
            this.roleBox.Location = new System.Drawing.Point(292, 111);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(100, 21);
            this.roleBox.TabIndex = 21;
            // 
            // courseEditTab
            // 
            this.courseEditTab.BackColor = System.Drawing.Color.Gray;
            this.courseEditTab.Controls.Add(this.coursePriceBox);
            this.courseEditTab.Controls.Add(this.label13);
            this.courseEditTab.Controls.Add(this.courseIDBox2);
            this.courseEditTab.Controls.Add(this.label8);
            this.courseEditTab.Controls.Add(this.label10);
            this.courseEditTab.Controls.Add(this.courseTimesBox);
            this.courseEditTab.Controls.Add(this.courseSeatsBox);
            this.courseEditTab.Controls.Add(this.label6);
            this.courseEditTab.Controls.Add(this.label9);
            this.courseEditTab.Controls.Add(this.label5);
            this.courseEditTab.Controls.Add(this.courseNameBox);
            this.courseEditTab.Controls.Add(this.courseProfessorBox);
            this.courseEditTab.Controls.Add(this.deleteCourseButton);
            this.courseEditTab.Controls.Add(this.courseIDBox1);
            this.courseEditTab.Controls.Add(this.updateCourseButton);
            this.courseEditTab.Controls.Add(this.searchCourseButton);
            this.courseEditTab.Controls.Add(this.addCourseButton);
            this.courseEditTab.Controls.Add(this.coursePrefixBox);
            this.courseEditTab.Controls.Add(this.courseNumberBox);
            this.courseEditTab.Controls.Add(this.label4);
            this.courseEditTab.Controls.Add(this.Prefix);
            this.courseEditTab.Controls.Add(this.label7);
            this.courseEditTab.Controls.Add(this.courseGridView);
            this.courseEditTab.Location = new System.Drawing.Point(4, 22);
            this.courseEditTab.Name = "courseEditTab";
            this.courseEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.courseEditTab.Size = new System.Drawing.Size(530, 399);
            this.courseEditTab.TabIndex = 1;
            this.courseEditTab.Text = "Courses";
            // 
            // courseIDBox2
            // 
            this.courseIDBox2.Enabled = false;
            this.courseIDBox2.Location = new System.Drawing.Point(126, 63);
            this.courseIDBox2.Name = "courseIDBox2";
            this.courseIDBox2.ReadOnly = true;
            this.courseIDBox2.Size = new System.Drawing.Size(100, 20);
            this.courseIDBox2.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Course ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Professor";
            // 
            // courseTimesBox
            // 
            this.courseTimesBox.Location = new System.Drawing.Point(291, 63);
            this.courseTimesBox.Name = "courseTimesBox";
            this.courseTimesBox.Size = new System.Drawing.Size(100, 20);
            this.courseTimesBox.TabIndex = 38;
            // 
            // courseSeatsBox
            // 
            this.courseSeatsBox.Location = new System.Drawing.Point(291, 89);
            this.courseSeatsBox.Name = "courseSeatsBox";
            this.courseSeatsBox.Size = new System.Drawing.Size(100, 20);
            this.courseSeatsBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Times";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Name";
            // 
            // courseNameBox
            // 
            this.courseNameBox.Location = new System.Drawing.Point(126, 142);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(265, 20);
            this.courseNameBox.TabIndex = 34;
            // 
            // courseProfessorBox
            // 
            this.courseProfessorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseProfessorBox.FormattingEnabled = true;
            this.courseProfessorBox.Location = new System.Drawing.Point(291, 115);
            this.courseProfessorBox.Name = "courseProfessorBox";
            this.courseProfessorBox.Size = new System.Drawing.Size(100, 21);
            this.courseProfessorBox.TabIndex = 33;
            this.courseProfessorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Location = new System.Drawing.Point(303, 189);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCourseButton.TabIndex = 32;
            this.deleteCourseButton.Text = "Delete";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // courseIDBox1
            // 
            this.courseIDBox1.Location = new System.Drawing.Point(210, 7);
            this.courseIDBox1.MaxLength = 5;
            this.courseIDBox1.Name = "courseIDBox1";
            this.courseIDBox1.Size = new System.Drawing.Size(102, 20);
            this.courseIDBox1.TabIndex = 22;
            // 
            // updateCourseButton
            // 
            this.updateCourseButton.Location = new System.Drawing.Point(222, 189);
            this.updateCourseButton.Name = "updateCourseButton";
            this.updateCourseButton.Size = new System.Drawing.Size(75, 23);
            this.updateCourseButton.TabIndex = 31;
            this.updateCourseButton.Text = "Update";
            this.updateCourseButton.UseVisualStyleBackColor = true;
            this.updateCourseButton.Click += new System.EventHandler(this.updateCourseButton_Click);
            // 
            // searchCourseButton
            // 
            this.searchCourseButton.Location = new System.Drawing.Point(222, 33);
            this.searchCourseButton.Name = "searchCourseButton";
            this.searchCourseButton.Size = new System.Drawing.Size(75, 23);
            this.searchCourseButton.TabIndex = 23;
            this.searchCourseButton.Text = "Search";
            this.searchCourseButton.UseVisualStyleBackColor = true;
            this.searchCourseButton.Click += new System.EventHandler(this.searchCourseButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(141, 189);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(75, 23);
            this.addCourseButton.TabIndex = 30;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // coursePrefixBox
            // 
            this.coursePrefixBox.Location = new System.Drawing.Point(126, 89);
            this.coursePrefixBox.Name = "coursePrefixBox";
            this.coursePrefixBox.Size = new System.Drawing.Size(100, 20);
            this.coursePrefixBox.TabIndex = 24;
            // 
            // courseNumberBox
            // 
            this.courseNumberBox.Location = new System.Drawing.Point(126, 115);
            this.courseNumberBox.Name = "courseNumberBox";
            this.courseNumberBox.Size = new System.Drawing.Size(100, 20);
            this.courseNumberBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Course ID";
            // 
            // Prefix
            // 
            this.Prefix.AutoSize = true;
            this.Prefix.Location = new System.Drawing.Point(88, 92);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(33, 13);
            this.Prefix.TabIndex = 26;
            this.Prefix.Text = "Prefix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Number";
            // 
            // courseGridView
            // 
            this.courseGridView.AllowUserToAddRows = false;
            this.courseGridView.AllowUserToDeleteRows = false;
            this.courseGridView.AllowUserToOrderColumns = true;
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(6, 219);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.courseGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.courseGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.courseGridView.Size = new System.Drawing.Size(519, 177);
            this.courseGridView.TabIndex = 0;
            // 
            // studentEditTab
            // 
            this.studentEditTab.BackColor = System.Drawing.Color.Gray;
            this.studentEditTab.Controls.Add(this.studentFirstNameBox);
            this.studentEditTab.Controls.Add(this.StudentFirstNameLabel);
            this.studentEditTab.Controls.Add(this.studentEmailBox);
            this.studentEditTab.Controls.Add(this.studentPhoneBox);
            this.studentEditTab.Controls.Add(this.StudentEmailLabel);
            this.studentEditTab.Controls.Add(this.StudentPhoneLabel);
            this.studentEditTab.Controls.Add(this.StudentAddressLabel);
            this.studentEditTab.Controls.Add(this.studentAddressBox);
            this.studentEditTab.Controls.Add(this.deleteStudentButton);
            this.studentEditTab.Controls.Add(this.studentIDBox);
            this.studentEditTab.Controls.Add(this.updateStudentButton);
            this.studentEditTab.Controls.Add(this.studentSearchButton);
            this.studentEditTab.Controls.Add(this.addStudentButton);
            this.studentEditTab.Controls.Add(this.studentLastNameBox);
            this.studentEditTab.Controls.Add(this.studentAgeBox);
            this.studentEditTab.Controls.Add(this.label16);
            this.studentEditTab.Controls.Add(this.LastNameLabel);
            this.studentEditTab.Controls.Add(this.StudentAgeLabel);
            this.studentEditTab.Controls.Add(this.studentGridView);
            this.studentEditTab.Location = new System.Drawing.Point(4, 22);
            this.studentEditTab.Name = "studentEditTab";
            this.studentEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentEditTab.Size = new System.Drawing.Size(530, 399);
            this.studentEditTab.TabIndex = 2;
            this.studentEditTab.Text = "Students";
            // 
            // studentFirstNameBox
            // 
            this.studentFirstNameBox.Location = new System.Drawing.Point(126, 63);
            this.studentFirstNameBox.Name = "studentFirstNameBox";
            this.studentFirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.studentFirstNameBox.TabIndex = 64;
            // 
            // StudentFirstNameLabel
            // 
            this.StudentFirstNameLabel.AutoSize = true;
            this.StudentFirstNameLabel.Location = new System.Drawing.Point(67, 65);
            this.StudentFirstNameLabel.Name = "StudentFirstNameLabel";
            this.StudentFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.StudentFirstNameLabel.TabIndex = 65;
            this.StudentFirstNameLabel.Text = "First Name";
            // 
            // studentEmailBox
            // 
            this.studentEmailBox.Location = new System.Drawing.Point(291, 63);
            this.studentEmailBox.Name = "studentEmailBox";
            this.studentEmailBox.Size = new System.Drawing.Size(100, 20);
            this.studentEmailBox.TabIndex = 59;
            // 
            // studentPhoneBox
            // 
            this.studentPhoneBox.Location = new System.Drawing.Point(291, 87);
            this.studentPhoneBox.Name = "studentPhoneBox";
            this.studentPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.studentPhoneBox.TabIndex = 60;
            // 
            // StudentEmailLabel
            // 
            this.StudentEmailLabel.AutoSize = true;
            this.StudentEmailLabel.Location = new System.Drawing.Point(254, 65);
            this.StudentEmailLabel.Name = "StudentEmailLabel";
            this.StudentEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.StudentEmailLabel.TabIndex = 61;
            this.StudentEmailLabel.Text = "Email";
            // 
            // StudentPhoneLabel
            // 
            this.StudentPhoneLabel.AutoSize = true;
            this.StudentPhoneLabel.Location = new System.Drawing.Point(239, 91);
            this.StudentPhoneLabel.Name = "StudentPhoneLabel";
            this.StudentPhoneLabel.Size = new System.Drawing.Size(48, 13);
            this.StudentPhoneLabel.TabIndex = 62;
            this.StudentPhoneLabel.Text = "Phone #";
            // 
            // StudentAddressLabel
            // 
            this.StudentAddressLabel.AutoSize = true;
            this.StudentAddressLabel.Location = new System.Drawing.Point(239, 114);
            this.StudentAddressLabel.Name = "StudentAddressLabel";
            this.StudentAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.StudentAddressLabel.TabIndex = 58;
            this.StudentAddressLabel.Text = "Address";
            // 
            // studentAddressBox
            // 
            this.studentAddressBox.Location = new System.Drawing.Point(291, 111);
            this.studentAddressBox.Name = "studentAddressBox";
            this.studentAddressBox.Size = new System.Drawing.Size(100, 20);
            this.studentAddressBox.TabIndex = 57;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(303, 188);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentButton.TabIndex = 55;
            this.deleteStudentButton.Text = "Delete";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // studentIDBox
            // 
            this.studentIDBox.Location = new System.Drawing.Point(210, 6);
            this.studentIDBox.MaxLength = 5;
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(102, 20);
            this.studentIDBox.TabIndex = 46;
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(222, 188);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(75, 23);
            this.updateStudentButton.TabIndex = 54;
            this.updateStudentButton.Text = "Update";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // studentSearchButton
            // 
            this.studentSearchButton.Location = new System.Drawing.Point(222, 32);
            this.studentSearchButton.Name = "studentSearchButton";
            this.studentSearchButton.Size = new System.Drawing.Size(75, 23);
            this.studentSearchButton.TabIndex = 47;
            this.studentSearchButton.Text = "Search";
            this.studentSearchButton.UseVisualStyleBackColor = true;
            this.studentSearchButton.Click += new System.EventHandler(this.studentSearchButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(141, 188);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 53;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentLastNameBox
            // 
            this.studentLastNameBox.Location = new System.Drawing.Point(126, 87);
            this.studentLastNameBox.Name = "studentLastNameBox";
            this.studentLastNameBox.Size = new System.Drawing.Size(100, 20);
            this.studentLastNameBox.TabIndex = 48;
            // 
            // studentAgeBox
            // 
            this.studentAgeBox.Location = new System.Drawing.Point(126, 111);
            this.studentAgeBox.Name = "studentAgeBox";
            this.studentAgeBox.Size = new System.Drawing.Size(100, 20);
            this.studentAgeBox.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(148, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Student ID";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(67, 91);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 50;
            this.LastNameLabel.Text = "Last Name";
            // 
            // StudentAgeLabel
            // 
            this.StudentAgeLabel.AutoSize = true;
            this.StudentAgeLabel.Location = new System.Drawing.Point(99, 114);
            this.StudentAgeLabel.Name = "StudentAgeLabel";
            this.StudentAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.StudentAgeLabel.TabIndex = 51;
            this.StudentAgeLabel.Text = "Age";
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AllowUserToOrderColumns = true;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(7, 219);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.studentGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentGridView.Size = new System.Drawing.Size(519, 177);
            this.studentGridView.TabIndex = 1;
            // 
            // professorEditTab
            // 
            this.professorEditTab.BackColor = System.Drawing.Color.Gray;
            this.professorEditTab.Controls.Add(this.professorAddressBox);
            this.professorEditTab.Controls.Add(this.ProfessorAddressLabel);
            this.professorEditTab.Controls.Add(this.professorPhoneBox);
            this.professorEditTab.Controls.Add(this.ProfessorPhoneLabel);
            this.professorEditTab.Controls.Add(this.label21);
            this.professorEditTab.Controls.Add(this.professorEmailBox);
            this.professorEditTab.Controls.Add(this.ProfessorEmailLabel);
            this.professorEditTab.Controls.Add(this.professorFaxBox);
            this.professorEditTab.Controls.Add(this.ProfessorFaxLabel);
            this.professorEditTab.Controls.Add(this.label14);
            this.professorEditTab.Controls.Add(this.professorFirstNameBox);
            this.professorEditTab.Controls.Add(this.label11);
            this.professorEditTab.Controls.Add(this.deleteProfessorButton);
            this.professorEditTab.Controls.Add(this.professorIDBox);
            this.professorEditTab.Controls.Add(this.updateProfessorButton);
            this.professorEditTab.Controls.Add(this.searchProfessorButton);
            this.professorEditTab.Controls.Add(this.addProfessorButton);
            this.professorEditTab.Controls.Add(this.professorLastNameBox);
            this.professorEditTab.Controls.Add(this.label15);
            this.professorEditTab.Controls.Add(this.label17);
            this.professorEditTab.Controls.Add(this.label18);
            this.professorEditTab.Controls.Add(this.professorGridView);
            this.professorEditTab.Location = new System.Drawing.Point(4, 22);
            this.professorEditTab.Name = "professorEditTab";
            this.professorEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.professorEditTab.Size = new System.Drawing.Size(530, 399);
            this.professorEditTab.TabIndex = 3;
            this.professorEditTab.Text = "Professors";
            // 
            // professorAddressBox
            // 
            this.professorAddressBox.Location = new System.Drawing.Point(292, 91);
            this.professorAddressBox.Name = "professorAddressBox";
            this.professorAddressBox.Size = new System.Drawing.Size(100, 20);
            this.professorAddressBox.TabIndex = 92;
            // 
            // ProfessorAddressLabel
            // 
            this.ProfessorAddressLabel.AutoSize = true;
            this.ProfessorAddressLabel.Location = new System.Drawing.Point(241, 92);
            this.ProfessorAddressLabel.Name = "ProfessorAddressLabel";
            this.ProfessorAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.ProfessorAddressLabel.TabIndex = 93;
            this.ProfessorAddressLabel.Text = "Address";
            // 
            // professorPhoneBox
            // 
            this.professorPhoneBox.Location = new System.Drawing.Point(292, 115);
            this.professorPhoneBox.Name = "professorPhoneBox";
            this.professorPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.professorPhoneBox.TabIndex = 89;
            // 
            // ProfessorPhoneLabel
            // 
            this.ProfessorPhoneLabel.AutoSize = true;
            this.ProfessorPhoneLabel.Location = new System.Drawing.Point(238, 118);
            this.ProfessorPhoneLabel.Name = "ProfessorPhoneLabel";
            this.ProfessorPhoneLabel.Size = new System.Drawing.Size(48, 13);
            this.ProfessorPhoneLabel.TabIndex = 90;
            this.ProfessorPhoneLabel.Text = "Phone #";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(286, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 91;
            // 
            // professorEmailBox
            // 
            this.professorEmailBox.Location = new System.Drawing.Point(126, 113);
            this.professorEmailBox.Name = "professorEmailBox";
            this.professorEmailBox.Size = new System.Drawing.Size(100, 20);
            this.professorEmailBox.TabIndex = 87;
            // 
            // ProfessorEmailLabel
            // 
            this.ProfessorEmailLabel.AutoSize = true;
            this.ProfessorEmailLabel.Location = new System.Drawing.Point(88, 117);
            this.ProfessorEmailLabel.Name = "ProfessorEmailLabel";
            this.ProfessorEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.ProfessorEmailLabel.TabIndex = 88;
            this.ProfessorEmailLabel.Text = "Email";
            // 
            // professorFaxBox
            // 
            this.professorFaxBox.Location = new System.Drawing.Point(292, 63);
            this.professorFaxBox.Name = "professorFaxBox";
            this.professorFaxBox.Size = new System.Drawing.Size(100, 20);
            this.professorFaxBox.TabIndex = 84;
            // 
            // ProfessorFaxLabel
            // 
            this.ProfessorFaxLabel.AutoSize = true;
            this.ProfessorFaxLabel.Location = new System.Drawing.Point(262, 66);
            this.ProfessorFaxLabel.Name = "ProfessorFaxLabel";
            this.ProfessorFaxLabel.Size = new System.Drawing.Size(24, 13);
            this.ProfessorFaxLabel.TabIndex = 85;
            this.ProfessorFaxLabel.Text = "Fax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 86;
            // 
            // professorFirstNameBox
            // 
            this.professorFirstNameBox.Location = new System.Drawing.Point(126, 63);
            this.professorFirstNameBox.Name = "professorFirstNameBox";
            this.professorFirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.professorFirstNameBox.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "First Name";
            // 
            // deleteProfessorButton
            // 
            this.deleteProfessorButton.Location = new System.Drawing.Point(303, 188);
            this.deleteProfessorButton.Name = "deleteProfessorButton";
            this.deleteProfessorButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProfessorButton.TabIndex = 75;
            this.deleteProfessorButton.Text = "Delete";
            this.deleteProfessorButton.UseVisualStyleBackColor = true;
            this.deleteProfessorButton.Click += new System.EventHandler(this.deleteProfessorButton_Click);
            // 
            // professorIDBox
            // 
            this.professorIDBox.Location = new System.Drawing.Point(210, 6);
            this.professorIDBox.MaxLength = 5;
            this.professorIDBox.Name = "professorIDBox";
            this.professorIDBox.Size = new System.Drawing.Size(102, 20);
            this.professorIDBox.TabIndex = 66;
            // 
            // updateProfessorButton
            // 
            this.updateProfessorButton.Location = new System.Drawing.Point(222, 188);
            this.updateProfessorButton.Name = "updateProfessorButton";
            this.updateProfessorButton.Size = new System.Drawing.Size(75, 23);
            this.updateProfessorButton.TabIndex = 74;
            this.updateProfessorButton.Text = "Update";
            this.updateProfessorButton.UseVisualStyleBackColor = true;
            this.updateProfessorButton.Click += new System.EventHandler(this.addProfessorButton_Click);
            // 
            // searchProfessorButton
            // 
            this.searchProfessorButton.Location = new System.Drawing.Point(222, 32);
            this.searchProfessorButton.Name = "searchProfessorButton";
            this.searchProfessorButton.Size = new System.Drawing.Size(75, 23);
            this.searchProfessorButton.TabIndex = 67;
            this.searchProfessorButton.Text = "Search";
            this.searchProfessorButton.UseVisualStyleBackColor = true;
            this.searchProfessorButton.Click += new System.EventHandler(this.searchProfessorButton_Click);
            // 
            // addProfessorButton
            // 
            this.addProfessorButton.Location = new System.Drawing.Point(141, 188);
            this.addProfessorButton.Name = "addProfessorButton";
            this.addProfessorButton.Size = new System.Drawing.Size(75, 23);
            this.addProfessorButton.TabIndex = 73;
            this.addProfessorButton.Text = "Add";
            this.addProfessorButton.UseVisualStyleBackColor = true;
            this.addProfessorButton.Click += new System.EventHandler(this.addProfessorButton_Click);
            // 
            // professorLastNameBox
            // 
            this.professorLastNameBox.Location = new System.Drawing.Point(126, 87);
            this.professorLastNameBox.Name = "professorLastNameBox";
            this.professorLastNameBox.Size = new System.Drawing.Size(100, 20);
            this.professorLastNameBox.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Professor ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Last Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(99, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 71;
            // 
            // professorGridView
            // 
            this.professorGridView.AllowUserToAddRows = false;
            this.professorGridView.AllowUserToDeleteRows = false;
            this.professorGridView.AllowUserToOrderColumns = true;
            this.professorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorGridView.Location = new System.Drawing.Point(7, 220);
            this.professorGridView.Name = "professorGridView";
            this.professorGridView.ReadOnly = true;
            this.professorGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.professorGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.professorGridView.Size = new System.Drawing.Size(519, 177);
            this.professorGridView.TabIndex = 2;
            // 
            // registrationEditTab
            // 
            this.registrationEditTab.BackColor = System.Drawing.Color.Gray;
            this.registrationEditTab.Controls.Add(this.regGradeBox);
            this.registrationEditTab.Controls.Add(this.regIsActiveBox);
            this.registrationEditTab.Controls.Add(this.regIsActiveLabel);
            this.registrationEditTab.Controls.Add(this.label20);
            this.registrationEditTab.Controls.Add(this.label23);
            this.registrationEditTab.Controls.Add(this.label24);
            this.registrationEditTab.Controls.Add(this.regStudentIDBox);
            this.registrationEditTab.Controls.Add(this.label25);
            this.registrationEditTab.Controls.Add(this.deleteRegistrationButton);
            this.registrationEditTab.Controls.Add(this.regIDBox);
            this.registrationEditTab.Controls.Add(this.updateRegistrationButton);
            this.registrationEditTab.Controls.Add(this.searchRegistrationButton);
            this.registrationEditTab.Controls.Add(this.addRegistrationButton);
            this.registrationEditTab.Controls.Add(this.regCourseIDBox);
            this.registrationEditTab.Controls.Add(this.label26);
            this.registrationEditTab.Controls.Add(this.label27);
            this.registrationEditTab.Controls.Add(this.regGridView);
            this.registrationEditTab.Location = new System.Drawing.Point(4, 22);
            this.registrationEditTab.Name = "registrationEditTab";
            this.registrationEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.registrationEditTab.Size = new System.Drawing.Size(530, 399);
            this.registrationEditTab.TabIndex = 4;
            this.registrationEditTab.Text = "Registrations";
            // 
            // regGradeBox
            // 
            this.regGradeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regGradeBox.FormattingEnabled = true;
            this.regGradeBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.regGradeBox.Location = new System.Drawing.Point(292, 60);
            this.regGradeBox.Margin = new System.Windows.Forms.Padding(2);
            this.regGradeBox.Name = "regGradeBox";
            this.regGradeBox.Size = new System.Drawing.Size(100, 21);
            this.regGradeBox.TabIndex = 95;
            // 
            // regIsActiveBox
            // 
            this.regIsActiveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regIsActiveBox.FormattingEnabled = true;
            this.regIsActiveBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.regIsActiveBox.Location = new System.Drawing.Point(292, 88);
            this.regIsActiveBox.Margin = new System.Windows.Forms.Padding(2);
            this.regIsActiveBox.Name = "regIsActiveBox";
            this.regIsActiveBox.Size = new System.Drawing.Size(100, 21);
            this.regIsActiveBox.TabIndex = 94;
            // 
            // regIsActiveLabel
            // 
            this.regIsActiveLabel.AutoSize = true;
            this.regIsActiveLabel.Location = new System.Drawing.Point(241, 93);
            this.regIsActiveLabel.Name = "regIsActiveLabel";
            this.regIsActiveLabel.Size = new System.Drawing.Size(48, 13);
            this.regIsActiveLabel.TabIndex = 93;
            this.regIsActiveLabel.Text = "Is Active";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(286, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 91;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(250, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 85;
            this.label23.Text = "Grade";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(286, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 86;
            // 
            // regStudentIDBox
            // 
            this.regStudentIDBox.Location = new System.Drawing.Point(126, 63);
            this.regStudentIDBox.Name = "regStudentIDBox";
            this.regStudentIDBox.Size = new System.Drawing.Size(100, 20);
            this.regStudentIDBox.TabIndex = 82;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(64, 67);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 83;
            this.label25.Text = "Student ID";
            // 
            // deleteRegistrationButton
            // 
            this.deleteRegistrationButton.Location = new System.Drawing.Point(303, 188);
            this.deleteRegistrationButton.Name = "deleteRegistrationButton";
            this.deleteRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRegistrationButton.TabIndex = 75;
            this.deleteRegistrationButton.Text = "Delete";
            this.deleteRegistrationButton.UseVisualStyleBackColor = true;
            this.deleteRegistrationButton.Click += new System.EventHandler(this.deleteRegistrationButton_Click);
            // 
            // regIDBox
            // 
            this.regIDBox.Location = new System.Drawing.Point(210, 6);
            this.regIDBox.MaxLength = 5;
            this.regIDBox.Name = "regIDBox";
            this.regIDBox.Size = new System.Drawing.Size(102, 20);
            this.regIDBox.TabIndex = 66;
            // 
            // updateRegistrationButton
            // 
            this.updateRegistrationButton.Location = new System.Drawing.Point(222, 188);
            this.updateRegistrationButton.Name = "updateRegistrationButton";
            this.updateRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.updateRegistrationButton.TabIndex = 74;
            this.updateRegistrationButton.Text = "Update";
            this.updateRegistrationButton.UseVisualStyleBackColor = true;
            this.updateRegistrationButton.Click += new System.EventHandler(this.updateRegistrationButton_Click);
            // 
            // searchRegistrationButton
            // 
            this.searchRegistrationButton.Location = new System.Drawing.Point(222, 32);
            this.searchRegistrationButton.Name = "searchRegistrationButton";
            this.searchRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.searchRegistrationButton.TabIndex = 67;
            this.searchRegistrationButton.Text = "Search";
            this.searchRegistrationButton.UseVisualStyleBackColor = true;
            this.searchRegistrationButton.Click += new System.EventHandler(this.button18_Click);
            // 
            // addRegistrationButton
            // 
            this.addRegistrationButton.Location = new System.Drawing.Point(141, 188);
            this.addRegistrationButton.Name = "addRegistrationButton";
            this.addRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.addRegistrationButton.TabIndex = 73;
            this.addRegistrationButton.Text = "Add";
            this.addRegistrationButton.UseVisualStyleBackColor = true;
            this.addRegistrationButton.Click += new System.EventHandler(this.addRegistrationButton_Click);
            // 
            // regCourseIDBox
            // 
            this.regCourseIDBox.Location = new System.Drawing.Point(126, 87);
            this.regCourseIDBox.Name = "regCourseIDBox";
            this.regCourseIDBox.Size = new System.Drawing.Size(100, 20);
            this.regCourseIDBox.TabIndex = 68;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(128, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 72;
            this.label26.Text = "Registration ID";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(68, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 70;
            this.label27.Text = "Course ID";
            // 
            // regGridView
            // 
            this.regGridView.AllowUserToAddRows = false;
            this.regGridView.AllowUserToDeleteRows = false;
            this.regGridView.AllowUserToOrderColumns = true;
            this.regGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regGridView.Location = new System.Drawing.Point(7, 220);
            this.regGridView.Name = "regGridView";
            this.regGridView.ReadOnly = true;
            this.regGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.regGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.regGridView.Size = new System.Drawing.Size(519, 177);
            this.regGridView.TabIndex = 2;
            // 
            // coursePriceBox
            // 
            this.coursePriceBox.Location = new System.Drawing.Point(212, 163);
            this.coursePriceBox.Name = "coursePriceBox";
            this.coursePriceBox.Size = new System.Drawing.Size(100, 20);
            this.coursePriceBox.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Price";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.userEditTab.ResumeLayout(false);
            this.userEditTab.PerformLayout();
            this.courseEditTab.ResumeLayout(false);
            this.courseEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.studentEditTab.ResumeLayout(false);
            this.studentEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.professorEditTab.ResumeLayout(false);
            this.professorEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professorGridView)).EndInit();
            this.registrationEditTab.ResumeLayout(false);
            this.registrationEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.BindingSource regdbDataSetBindingSource;
        private reg_dbDataSet reg_dbDataSet;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userEditTab;
        private System.Windows.Forms.TabPage courseEditTab;
        private System.Windows.Forms.TabPage studentEditTab;
        private System.Windows.Forms.TabPage professorEditTab;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.ComboBox courseProfessorBox;
        private System.Windows.Forms.Button deleteCourseButton;
        private System.Windows.Forms.TextBox courseIDBox1;
        private System.Windows.Forms.Button updateCourseButton;
        private System.Windows.Forms.Button searchCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.TextBox coursePrefixBox;
        private System.Windows.Forms.TextBox courseNumberBox;
        private System.Windows.Forms.Label Prefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox courseTimesBox;
        private System.Windows.Forms.TextBox courseSeatsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox courseIDBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.TextBox studentFirstNameBox;
        private System.Windows.Forms.Label StudentFirstNameLabel;
        private System.Windows.Forms.TextBox studentEmailBox;
        private System.Windows.Forms.TextBox studentPhoneBox;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label StudentPhoneLabel;
        private System.Windows.Forms.Label StudentAddressLabel;
        private System.Windows.Forms.TextBox studentAddressBox;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button studentSearchButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox studentLastNameBox;
        private System.Windows.Forms.TextBox studentAgeBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label StudentAgeLabel;
        private System.Windows.Forms.TextBox professorFirstNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteProfessorButton;
        private System.Windows.Forms.TextBox professorIDBox;
        private System.Windows.Forms.Button updateProfessorButton;
        private System.Windows.Forms.Button searchProfessorButton;
        private System.Windows.Forms.Button addProfessorButton;
        private System.Windows.Forms.TextBox professorLastNameBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView professorGridView;
        private System.Windows.Forms.TextBox professorAddressBox;
        private System.Windows.Forms.Label ProfessorAddressLabel;
        private System.Windows.Forms.TextBox professorPhoneBox;
        private System.Windows.Forms.Label ProfessorPhoneLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox professorEmailBox;
        private System.Windows.Forms.Label ProfessorEmailLabel;
        private System.Windows.Forms.TextBox professorFaxBox;
        private System.Windows.Forms.Label ProfessorFaxLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage registrationEditTab;
        private System.Windows.Forms.Label regIsActiveLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox regStudentIDBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button deleteRegistrationButton;
        private System.Windows.Forms.TextBox regIDBox;
        private System.Windows.Forms.Button updateRegistrationButton;
        private System.Windows.Forms.Button searchRegistrationButton;
        private System.Windows.Forms.Button addRegistrationButton;
        private System.Windows.Forms.TextBox regCourseIDBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView regGridView;
        private System.Windows.Forms.ComboBox regGradeBox;
        private System.Windows.Forms.ComboBox regIsActiveBox;
        private System.Windows.Forms.TextBox coursePriceBox;
        private System.Windows.Forms.Label label13;
    }
}



