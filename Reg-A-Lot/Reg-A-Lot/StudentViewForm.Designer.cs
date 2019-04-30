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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStudentRegisteredCourses = new System.Windows.Forms.ListView();
            this.cbStudentRegisteredCoursesToDrop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRegisterForCourse = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.regdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudentDisplayCoursesRegistered.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentDisplayCoursesRegistered
            // 
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.groupBox2);
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
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 49);
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
            this.label1.Location = new System.Drawing.Point(551, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The courses you registered for are listed below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblRegisterForCourse);
            this.groupBox1.Controls.Add(this.lbStudentRegisteredCourses);
            this.groupBox1.Controls.Add(this.cbStudentRegisteredCoursesToDrop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(811, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resgistered Courses";
            // 
            // lbStudentRegisteredCourses
            // 
            this.lbStudentRegisteredCourses.Location = new System.Drawing.Point(554, 46);
            this.lbStudentRegisteredCourses.Margin = new System.Windows.Forms.Padding(2);
            this.lbStudentRegisteredCourses.Name = "lbStudentRegisteredCourses";
            this.lbStudentRegisteredCourses.Size = new System.Drawing.Size(225, 102);
            this.lbStudentRegisteredCourses.TabIndex = 8;
            this.lbStudentRegisteredCourses.UseCompatibleStateImageBehavior = false;
            this.lbStudentRegisteredCourses.View = System.Windows.Forms.View.List;
            // 
            // cbStudentRegisteredCoursesToDrop
            // 
            this.cbStudentRegisteredCoursesToDrop.DataSource = this.sectionsBindingSource;
            this.cbStudentRegisteredCoursesToDrop.DisplayMember = "Id";
            this.cbStudentRegisteredCoursesToDrop.FormattingEnabled = true;
            this.cbStudentRegisteredCoursesToDrop.Location = new System.Drawing.Point(282, 46);
            this.cbStudentRegisteredCoursesToDrop.Margin = new System.Windows.Forms.Padding(2);
            this.cbStudentRegisteredCoursesToDrop.Name = "cbStudentRegisteredCoursesToDrop";
            this.cbStudentRegisteredCoursesToDrop.Size = new System.Drawing.Size(212, 21);
            this.cbStudentRegisteredCoursesToDrop.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Please select the courses you need to DROP:";
            // 
            // lblRegisterForCourse
            // 
            this.lblRegisterForCourse.AutoSize = true;
            this.lblRegisterForCourse.Location = new System.Drawing.Point(22, 25);
            this.lblRegisterForCourse.Name = "lblRegisterForCourse";
            this.lblRegisterForCourse.Size = new System.Drawing.Size(230, 13);
            this.lblRegisterForCourse.TabIndex = 9;
            this.lblRegisterForCourse.Text = "Select the courses you need to REGISTER for:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sectionsBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 10;
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
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.reg_dbDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(414, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 200);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Grades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Below is a list of your class grades:";
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudentDisplayCoursesRegistered);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentViewForm";
            this.Text = "Student Profile";
            this.lblStudentDisplayCoursesRegistered.ResumeLayout(false);
            this.lblStudentDisplayCoursesRegistered.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblStudentDisplayCoursesRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lbStudentRegisteredCourses;
        private System.Windows.Forms.ComboBox cbStudentRegisteredCoursesToDrop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private reg_dbDataSet reg_dbDataSet;
        private System.Windows.Forms.Label lblRegisterForCourse;
        private System.Windows.Forms.BindingSource regdbDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
    }
}