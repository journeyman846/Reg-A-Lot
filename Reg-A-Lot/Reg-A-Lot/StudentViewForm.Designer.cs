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
            this.dgvViewFinalGrades = new System.Windows.Forms.DataGridView();
            this.lblCourseGrades = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCourseDrop = new System.Windows.Forms.DataGridView();
            this.dgvViewCourses = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.dgvCourseRegister = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentCourseRegister = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStudentDisplayCoursesRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFinalGrades)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseDrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentDisplayCoursesRegistered
            // 
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbStudentID);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbFirstName);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbAddress);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbPhoneNumber);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbAge);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.tbLastName);
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
            this.lblStudentDisplayCoursesRegistered.Margin = new System.Windows.Forms.Padding(2);
            this.lblStudentDisplayCoursesRegistered.Name = "lblStudentDisplayCoursesRegistered";
            this.lblStudentDisplayCoursesRegistered.Padding = new System.Windows.Forms.Padding(2);
            this.lblStudentDisplayCoursesRegistered.Size = new System.Drawing.Size(811, 248);
            this.lblStudentDisplayCoursesRegistered.TabIndex = 0;
            this.lblStudentDisplayCoursesRegistered.TabStop = false;
            this.lblStudentDisplayCoursesRegistered.Text = "Student Profile";
            // 
            // dgvViewFinalGrades
            // 
            this.dgvViewFinalGrades.AllowUserToAddRows = false;
            this.dgvViewFinalGrades.AllowUserToDeleteRows = false;
            this.dgvViewFinalGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvViewFinalGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewFinalGrades.Location = new System.Drawing.Point(514, 31);
            this.dgvViewFinalGrades.Name = "dgvViewFinalGrades";
            this.dgvViewFinalGrades.ReadOnly = true;
            this.dgvViewFinalGrades.Size = new System.Drawing.Size(197, 137);
            this.dgvViewFinalGrades.TabIndex = 19;
            // 
            // lblCourseGrades
            // 
            this.lblCourseGrades.AutoSize = true;
            this.lblCourseGrades.Location = new System.Drawing.Point(556, 15);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The courses you registered for are listed below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCourseDrop);
            this.groupBox1.Controls.Add(this.dgvViewCourses);
            this.groupBox1.Controls.Add(this.dgvCourseRegister);
            this.groupBox1.Controls.Add(this.lblStudentCourseRegister);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(811, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resgistered Courses";
            // 
            // dgvCourseDrop
            // 
            this.dgvCourseDrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseDrop.Location = new System.Drawing.Point(315, 40);
            this.dgvCourseDrop.Name = "dgvCourseDrop";
            this.dgvCourseDrop.Size = new System.Drawing.Size(240, 140);
            this.dgvCourseDrop.TabIndex = 12;
            // 
            // dgvViewCourses
            // 
            this.dgvViewCourses.AllowUserToAddRows = false;
            this.dgvViewCourses.AllowUserToDeleteRows = false;
            this.dgvViewCourses.AutoGenerateColumns = false;
            this.dgvViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1});
            this.dgvViewCourses.DataSource = this.sectionsBindingSource;
            this.dgvViewCourses.Location = new System.Drawing.Point(568, 40);
            this.dgvViewCourses.Name = "dgvViewCourses";
            this.dgvViewCourses.ReadOnly = true;
            this.dgvViewCourses.Size = new System.Drawing.Size(240, 140);
            this.dgvViewCourses.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dgvCourseRegister
            // 
            this.dgvCourseRegister.AllowUserToAddRows = false;
            this.dgvCourseRegister.AllowUserToDeleteRows = false;
            this.dgvCourseRegister.AutoGenerateColumns = false;
            this.dgvCourseRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dgvCourseRegister.DataSource = this.sectionsBindingSource;
            this.dgvCourseRegister.Location = new System.Drawing.Point(31, 40);
            this.dgvCourseRegister.Name = "dgvCourseRegister";
            this.dgvCourseRegister.ReadOnly = true;
            this.dgvCourseRegister.Size = new System.Drawing.Size(260, 140);
            this.dgvCourseRegister.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblStudentCourseRegister
            // 
            this.lblStudentCourseRegister.AutoSize = true;
            this.lblStudentCourseRegister.Location = new System.Drawing.Point(28, 24);
            this.lblStudentCourseRegister.Name = "lblStudentCourseRegister";
            this.lblStudentCourseRegister.Size = new System.Drawing.Size(263, 13);
            this.lblStudentCourseRegister.TabIndex = 9;
            this.lblStudentCourseRegister.Text = "Please select the courses you need to REGISTER for:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Please select the course you need to DROP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(139, 72);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 20;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(139, 97);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 20;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(139, 148);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNumber.TabIndex = 20;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(139, 123);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 20;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(139, 47);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 20;
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(139, 24);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(100, 20);
            this.tbStudentID.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudentDisplayCoursesRegistered);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentViewForm";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            this.lblStudentDisplayCoursesRegistered.ResumeLayout(false);
            this.lblStudentDisplayCoursesRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFinalGrades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseDrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblStudentDisplayCoursesRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStudentCourseRegister;
        private System.Windows.Forms.DataGridView dgvViewFinalGrades;
        private System.Windows.Forms.Label lblCourseGrades;
        private System.Windows.Forms.DataGridView dgvCourseRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private reg_dbDataSet reg_dbDataSet;
        private System.Windows.Forms.DataGridView dgvCourseDrop;
        private System.Windows.Forms.DataGridView dgvViewCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}