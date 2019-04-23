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
            this.label8 = new System.Windows.Forms.Label();
            this.cbStudentRegisteredCoursesToDrop = new System.Windows.Forms.ComboBox();
            this.lbStudentRegisteredCourses = new System.Windows.Forms.ListView();
            this.lblStudentDisplayCoursesRegistered.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentDisplayCoursesRegistered
            // 
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label7);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label6);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label5);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label4);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label3);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.label2);
            this.lblStudentDisplayCoursesRegistered.Controls.Add(this.lblCourse1);
            this.lblStudentDisplayCoursesRegistered.Location = new System.Drawing.Point(13, 13);
            this.lblStudentDisplayCoursesRegistered.Name = "lblStudentDisplayCoursesRegistered";
            this.lblStudentDisplayCoursesRegistered.Size = new System.Drawing.Size(1216, 381);
            this.lblStudentDisplayCoursesRegistered.TabIndex = 0;
            this.lblStudentDisplayCoursesRegistered.TabStop = false;
            this.lblStudentDisplayCoursesRegistered.Text = "Student Profile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 39);
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
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(125, 483);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(0, 20);
            this.lblCourse1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "The courses you registered for are listed below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbStudentRegisteredCourses);
            this.groupBox1.Controls.Add(this.cbStudentRegisteredCoursesToDrop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resgistered Courses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Please select the course you need to drop:";
            // 
            // cbStudentRegisteredCoursesToDrop
            // 
            this.cbStudentRegisteredCoursesToDrop.FormattingEnabled = true;
            this.cbStudentRegisteredCoursesToDrop.Location = new System.Drawing.Point(472, 71);
            this.cbStudentRegisteredCoursesToDrop.Name = "cbStudentRegisteredCoursesToDrop";
            this.cbStudentRegisteredCoursesToDrop.Size = new System.Drawing.Size(316, 28);
            this.cbStudentRegisteredCoursesToDrop.TabIndex = 7;
            // 
            // lbStudentRegisteredCourses
            // 
            this.lbStudentRegisteredCourses.Location = new System.Drawing.Point(19, 71);
            this.lbStudentRegisteredCourses.Name = "lbStudentRegisteredCourses";
            this.lbStudentRegisteredCourses.Size = new System.Drawing.Size(336, 155);
            this.lbStudentRegisteredCourses.TabIndex = 8;
            this.lbStudentRegisteredCourses.UseCompatibleStateImageBehavior = false;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStudentDisplayCoursesRegistered);
            this.Name = "StudentViewForm";
            this.Text = "Student Profile";
            this.lblStudentDisplayCoursesRegistered.ResumeLayout(false);
            this.lblStudentDisplayCoursesRegistered.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}