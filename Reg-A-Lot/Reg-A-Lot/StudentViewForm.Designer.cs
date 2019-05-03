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
            this.lblStudentDisplayCoursesRegistered.Location = new System.Drawing.Point(14, 12);
            this.lblStudentDisplayCoursesRegistered.Name = "lblStudentDisplayCoursesRegistered";
            this.lblStudentDisplayCoursesRegistered.Size = new System.Drawing.Size(1216, 408);
            this.lblStudentDisplayCoursesRegistered.TabIndex = 0;
            this.lblStudentDisplayCoursesRegistered.TabStop = false;
            this.lblStudentDisplayCoursesRegistered.Text = "Student Profile";
            // 
            // btnSaveStudentInfo
            // 
            this.btnSaveStudentInfo.Location = new System.Drawing.Point(280, 312);
            this.btnSaveStudentInfo.Name = "btnSaveStudentInfo";
            this.btnSaveStudentInfo.Size = new System.Drawing.Size(75, 35);
            this.btnSaveStudentInfo.TabIndex = 28;
            this.btnSaveStudentInfo.Text = "Save";
            this.btnSaveStudentInfo.UseVisualStyleBackColor = true;
            this.btnSaveStudentInfo.Click += new System.EventHandler(this.btnSaveStudentInfo_Click);
            // 
            // btnEditStudentInfo
            // 
            this.btnEditStudentInfo.Location = new System.Drawing.Point(208, 312);
            this.btnEditStudentInfo.Name = "btnEditStudentInfo";
            this.btnEditStudentInfo.Size = new System.Drawing.Size(68, 35);
            this.btnEditStudentInfo.TabIndex = 27;
            this.btnEditStudentInfo.Text = "Edit";
            this.btnEditStudentInfo.UseVisualStyleBackColor = true;
            this.btnEditStudentInfo.Click += new System.EventHandler(this.btnEditStudentInfo_Click);
            // 
            // btnLoadGrades
            // 
            this.btnLoadGrades.Location = new System.Drawing.Point(490, 352);
            this.btnLoadGrades.Name = "btnLoadGrades";
            this.btnLoadGrades.Size = new System.Drawing.Size(124, 48);
            this.btnLoadGrades.TabIndex = 26;
            this.btnLoadGrades.Text = "Load Grades";
            this.btnLoadGrades.UseVisualStyleBackColor = true;
            this.btnLoadGrades.Click += new System.EventHandler(this.btnLoadGrades_Click);
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(928, 352);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(134, 48);
            this.btnLoadCourses.TabIndex = 25;
            this.btnLoadCourses.Text = "Load Courses";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // dgvStudentViewRegisteredCourses
            // 
            this.dgvStudentViewRegisteredCourses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentViewRegisteredCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentViewRegisteredCourses.Location = new System.Drawing.Point(760, 48);
            this.dgvStudentViewRegisteredCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStudentViewRegisteredCourses.Name = "dgvStudentViewRegisteredCourses";
            this.dgvStudentViewRegisteredCourses.Size = new System.Drawing.Size(434, 297);
            this.dgvStudentViewRegisteredCourses.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Course(s) Registered For:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(208, 37);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(148, 26);
            this.txtStudentID.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(208, 72);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(148, 26);
            this.txtFirstName.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(208, 189);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(148, 46);
            this.txtAddress.TabIndex = 20;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(208, 246);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 26);
            this.txtPhoneNumber.TabIndex = 20;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(208, 149);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(148, 26);
            this.txtAge.TabIndex = 20;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(208, 111);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(148, 26);
            this.txtLastName.TabIndex = 20;
            // 
            // dgvViewFinalGrades
            // 
            this.dgvViewFinalGrades.AllowUserToAddRows = false;
            this.dgvViewFinalGrades.AllowUserToDeleteRows = false;
            this.dgvViewFinalGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvViewFinalGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewFinalGrades.Location = new System.Drawing.Point(408, 48);
            this.dgvViewFinalGrades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewFinalGrades.Name = "dgvViewFinalGrades";
            this.dgvViewFinalGrades.ReadOnly = true;
            this.dgvViewFinalGrades.Size = new System.Drawing.Size(296, 297);
            this.dgvViewFinalGrades.TabIndex = 19;
            // 
            // lblCourseGrades
            // 
            this.lblCourseGrades.AutoSize = true;
            this.lblCourseGrades.Location = new System.Drawing.Point(476, 23);
            this.lblCourseGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseGrades.Name = "lblCourseGrades";
            this.lblCourseGrades.Size = new System.Drawing.Size(159, 20);
            this.lblCourseGrades.TabIndex = 18;
            this.lblCourseGrades.Text = "Your Course Grades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Student ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(124, 483);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(0, 20);
            this.lblCourse1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadCoursesAvailable);
            this.groupBox1.Controls.Add(this.btnDropCourses);
            this.groupBox1.Controls.Add(this.dgvCourseRegisterOrDrop);
            this.groupBox1.Controls.Add(this.lblStudentCourseRegister);
            this.groupBox1.Controls.Add(this.btnRegisterForCourses);
            this.groupBox1.Location = new System.Drawing.Point(14, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 382);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Changes";
            // 
            // btnLoadCoursesAvailable
            // 
            this.btnLoadCoursesAvailable.Location = new System.Drawing.Point(32, 91);
            this.btnLoadCoursesAvailable.Name = "btnLoadCoursesAvailable";
            this.btnLoadCoursesAvailable.Size = new System.Drawing.Size(228, 37);
            this.btnLoadCoursesAvailable.TabIndex = 12;
            this.btnLoadCoursesAvailable.Text = "Load Courses To Table";
            this.btnLoadCoursesAvailable.UseVisualStyleBackColor = true;
            this.btnLoadCoursesAvailable.Click += new System.EventHandler(this.btnLoadCoursesAvailable_Click);
            // 
            // btnDropCourses
            // 
            this.btnDropCourses.Location = new System.Drawing.Point(32, 182);
            this.btnDropCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDropCourses.Name = "btnDropCourses";
            this.btnDropCourses.Size = new System.Drawing.Size(228, 35);
            this.btnDropCourses.TabIndex = 11;
            this.btnDropCourses.Text = "Drop Course(s)";
            this.btnDropCourses.UseVisualStyleBackColor = true;
            // 
            // dgvCourseRegisterOrDrop
            // 
            this.dgvCourseRegisterOrDrop.AllowUserToAddRows = false;
            this.dgvCourseRegisterOrDrop.AllowUserToDeleteRows = false;
            this.dgvCourseRegisterOrDrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseRegisterOrDrop.Location = new System.Drawing.Point(408, 71);
            this.dgvCourseRegisterOrDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCourseRegisterOrDrop.Name = "dgvCourseRegisterOrDrop";
            this.dgvCourseRegisterOrDrop.ReadOnly = true;
            this.dgvCourseRegisterOrDrop.Size = new System.Drawing.Size(621, 265);
            this.dgvCourseRegisterOrDrop.TabIndex = 10;
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
            this.lblStudentCourseRegister.Location = new System.Drawing.Point(621, 42);
            this.lblStudentCourseRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentCourseRegister.Name = "lblStudentCourseRegister";
            this.lblStudentCourseRegister.Size = new System.Drawing.Size(178, 20);
            this.lblStudentCourseRegister.TabIndex = 9;
            this.lblStudentCourseRegister.Text = "Please Select a Course:";
            // 
            // btnRegisterForCourses
            // 
            this.btnRegisterForCourses.Location = new System.Drawing.Point(32, 135);
            this.btnRegisterForCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterForCourses.Name = "btnRegisterForCourses";
            this.btnRegisterForCourses.Size = new System.Drawing.Size(228, 35);
            this.btnRegisterForCourses.TabIndex = 6;
            this.btnRegisterForCourses.Text = "Register For Course(s)";
            this.btnRegisterForCourses.UseVisualStyleBackColor = true;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 845);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudentDisplayCoursesRegistered);
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