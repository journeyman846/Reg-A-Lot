namespace Reg_A_Lot
{
    partial class StudentViewForm
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
            this.lblStudentDisplayCoursesRegistered = new System.Windows.Forms.GroupBox();
            this.btnSaveStudentInfo = new System.Windows.Forms.Button();
            this.btnEditStudentInfo = new System.Windows.Forms.Button();
            this.btnLoadGrades = new System.Windows.Forms.Button();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvStudentViewRegisteredCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dgvViewFinalGrades = new System.Windows.Forms.DataGridView();
            this.lblCourseGrades = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadCoursesAvailable = new System.Windows.Forms.Button();
            this.btnDropCourses = new System.Windows.Forms.Button();
            this.dgvCourseRegisterOrDrop = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.lblStudentCourseRegister = new System.Windows.Forms.Label();
            this.btnRegisterForCourses = new System.Windows.Forms.Button();
            this.lblStudentDisplayCoursesRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentViewRegisteredCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFinalGrades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegisterOrDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentDisplayCoursesRegistered
            // 
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.btnSaveStudentInfo);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.btnEditStudentInfo);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.btnLoadGrades);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.btnLoadCourses);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label8);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtEmail);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.dgvStudentViewRegisteredCourses);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label1);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtStudentID);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtFirstName);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtAddress);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtPhoneNumber);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtAge);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.txtLastName);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.dgvViewFinalGrades);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.lblCourseGrades);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label7);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label6);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label5);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label4);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label3);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label2);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.lblCourse1);
            this.lblStudentDisplayCoursesRegistered.Location = new System.Drawing.Point(9, 8);
            this.lblStudentDisplayCoursesRegistered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblStudentDisplayCoursesRegistered.Name = "lblStudentDisplayCoursesRegistered";
            this.lblStudentDisplayCoursesRegistered.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblStudentDisplayCoursesRegistered.Size = new System.Drawing.Size(811, 265);
            this.lblStudentDisplayCoursesRegistered.TabIndex = 0;
            this.lblStudentDisplayCoursesRegistered.TabStop = false;
            this.lblStudentDisplayCoursesRegistered.Text = "Student Profile";
            // 
            // btnSaveStudentInfo
            // 
            this.btnSaveStudentInfo.Location = new System.Drawing.Point(187, 203);
            this.btnSaveStudentInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveStudentInfo.Name = "btnSaveStudentInfo";
            this.btnSaveStudentInfo.Size = new System.Drawing.Size(50, 23);
            this.btnSaveStudentInfo.TabIndex = 28;
            this.btnSaveStudentInfo.Text = "Save";
            this.btnSaveStudentInfo.UseVisualStyleBackColor = true;
            this.btnSaveStudentInfo.Click += new System.EventHandler(this.btnSaveStudentInfo_Click);
            // 
            // btnEditStudentInfo
            // 
            this.btnEditStudentInfo.Location = new System.Drawing.Point(139, 203);
            this.btnEditStudentInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditStudentInfo.Name = "btnEditStudentInfo";
            this.btnEditStudentInfo.Size = new System.Drawing.Size(45, 23);
            this.btnEditStudentInfo.TabIndex = 27;
            this.btnEditStudentInfo.Text = "Edit";
            this.btnEditStudentInfo.UseVisualStyleBackColor = true;
            this.btnEditStudentInfo.Click += new System.EventHandler(this.btnEditStudentInfo_Click);
            // 
            // btnLoadGrades
            // 
            this.btnLoadGrades.Location = new System.Drawing.Point(327, 229);
            this.btnLoadGrades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadGrades.Name = "btnLoadGrades";
            this.btnLoadGrades.Size = new System.Drawing.Size(83, 31);
            this.btnLoadGrades.TabIndex = 26;
            this.btnLoadGrades.Text = "Load Grades";
            this.btnLoadGrades.UseVisualStyleBackColor = true;
            this.btnLoadGrades.Click += new System.EventHandler(this.btnLoadGrades_Click);
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(619, 229);
            this.btnLoadCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(89, 31);
            this.btnLoadCourses.TabIndex = 25;
            this.btnLoadCourses.Text = "Load Courses";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 183);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // dgvStudentViewRegisteredCourses
            // 
            this.dgvStudentViewRegisteredCourses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentViewRegisteredCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentViewRegisteredCourses.Location = new System.Drawing.Point(507, 31);
            this.dgvStudentViewRegisteredCourses.Name = "dgvStudentViewRegisteredCourses";
            this.dgvStudentViewRegisteredCourses.Size = new System.Drawing.Size(289, 193);
            this.dgvStudentViewRegisteredCourses.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Course(s) Registered For:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(139, 24);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(139, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(139, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 31);
            this.txtAddress.TabIndex = 20;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(139, 160);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 20;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(139, 97);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 20;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(139, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // dgvViewFinalGrades
            // 
            this.dgvViewFinalGrades.AllowUserToAddRows = false;
            this.dgvViewFinalGrades.AllowUserToDeleteRows = false;
            this.dgvViewFinalGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvViewFinalGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewFinalGrades.Location = new System.Drawing.Point(272, 31);
            this.dgvViewFinalGrades.Name = "dgvViewFinalGrades";
            this.dgvViewFinalGrades.ReadOnly = true;
            this.dgvViewFinalGrades.Size = new System.Drawing.Size(197, 193);
            this.dgvViewFinalGrades.TabIndex = 19;
            // 
            // lblCourseGrades
            // 
            this.lblCourseGrades.AutoSize = true;
            this.lblCourseGrades.Location = new System.Drawing.Point(317, 15);
            this.lblCourseGrades.Name = "lblCourseGrades";
            this.lblCourseGrades.Size = new System.Drawing.Size(105, 13);
            this.lblCourseGrades.TabIndex = 18;
            this.lblCourseGrades.Text = "Your Course Grades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Student ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(83, 314);
            this.lblCourse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(0, 13);
            this.lblCourse1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadCoursesAvailable);
            this.groupBox1.Controls.Add(this.btnDropCourses);
            this.groupBox1.Controls.Add(this.dgvCourseRegisterOrDrop);
            this.groupBox1.Controls.Add(this.lblStudentCourseRegister);
            this.groupBox1.Controls.Add(this.btnRegisterForCourses);
            this.groupBox1.Location = new System.Drawing.Point(9, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(811, 248);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Changes";
            // 
            // btnLoadCoursesAvailable
            // 
            this.btnLoadCoursesAvailable.Location = new System.Drawing.Point(21, 59);
            this.btnLoadCoursesAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadCoursesAvailable.Name = "btnLoadCoursesAvailable";
            this.btnLoadCoursesAvailable.Size = new System.Drawing.Size(125, 24);
            this.btnLoadCoursesAvailable.TabIndex = 12;
            this.btnLoadCoursesAvailable.Text = "Load Courses To Table";
            this.btnLoadCoursesAvailable.UseVisualStyleBackColor = true;
            // 
            // btnDropCourses
            // 
            this.btnDropCourses.Location = new System.Drawing.Point(21, 118);
            this.btnDropCourses.Name = "btnDropCourses";
            this.btnDropCourses.Size = new System.Drawing.Size(125, 23);
            this.btnDropCourses.TabIndex = 11;
            this.btnDropCourses.Text = "Drop Course(s)";
            this.btnDropCourses.UseVisualStyleBackColor = true;
            // 
            // dgvCourseRegisterOrDrop
            // 
            this.dgvCourseRegisterOrDrop.AllowUserToAddRows = false;
            this.dgvCourseRegisterOrDrop.AllowUserToDeleteRows = false;
            this.dgvCourseRegisterOrDrop.AutoGenerateColumns = false;
            this.dgvCourseRegisterOrDrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseRegisterOrDrop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dgvCourseRegisterOrDrop.DataSource = this.sectionsBindingSource;
            this.dgvCourseRegisterOrDrop.Location = new System.Drawing.Point(272, 46);
            this.dgvCourseRegisterOrDrop.Name = "dgvCourseRegisterOrDrop";
            this.dgvCourseRegisterOrDrop.ReadOnly = true;
            this.dgvCourseRegisterOrDrop.Size = new System.Drawing.Size(414, 172);
            this.dgvCourseRegisterOrDrop.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.reg_dbDataSet;
            // 
            // reg_dbDataSet
            // 
            this.reg_dbDataSet.DataSetName = "reg_dbDataSet";
            this.reg_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStudentCourseRegister
            // 
            this.lblStudentCourseRegister.AutoSize = true;
            this.lblStudentCourseRegister.Location = new System.Drawing.Point(414, 27);
            this.lblStudentCourseRegister.Name = "lblStudentCourseRegister";
            this.lblStudentCourseRegister.Size = new System.Drawing.Size(120, 13);
            this.lblStudentCourseRegister.TabIndex = 9;
            this.lblStudentCourseRegister.Text = "Please Select a Course:";
            // 
            // btnRegisterForCourses
            // 
            this.btnRegisterForCourses.Location = new System.Drawing.Point(21, 88);
            this.btnRegisterForCourses.Name = "btnRegisterForCourses";
            this.btnRegisterForCourses.Size = new System.Drawing.Size(125, 23);
            this.btnRegisterForCourses.TabIndex = 6;
            this.btnRegisterForCourses.Text = "Register For Course(s)";
            this.btnRegisterForCourses.UseVisualStyleBackColor = true;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudentDisplayCoursesRegistered);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentViewForm";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            this.lblStudentDisplayCoursesRegistered.ResumeLayout(false);
            this.lblStudentDisplayCoursesRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentViewRegisteredCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFinalGrades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegisterOrDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblStudentDisplayCoursesRegistered;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStudentCourseRegister;
        private System.Windows.Forms.DataGridView dgvViewFinalGrades;
        private System.Windows.Forms.Label lblCourseGrades;
        private System.Windows.Forms.DataGridView dgvCourseRegisterOrDrop;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private reg_dbDataSet reg_dbDataSet;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisterForCourses;
        private System.Windows.Forms.DataGridView dgvStudentViewRegisteredCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDropCourses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSaveStudentInfo;
        private System.Windows.Forms.Button btnEditStudentInfo;
        private System.Windows.Forms.Button btnLoadGrades;
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.Button btnLoadCoursesAvailable;
    }
}