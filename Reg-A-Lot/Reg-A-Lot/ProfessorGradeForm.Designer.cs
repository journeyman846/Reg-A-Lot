namespace Reg_A_Lot
{
    partial class ProfessorGradeForm
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
            this.lblProfessorDisplayCoursesTaught = new System.Windows.Forms.GroupBox();
            this.lblProfessorCourses = new System.Windows.Forms.Label();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.lblProfessorID = new System.Windows.Forms.Label();
            this.txtProfessorID = new System.Windows.Forms.TextBox();
            this.dgvCoursesBeingTaught = new System.Windows.Forms.DataGridView();
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadSubmissions = new System.Windows.Forms.Button();
            this.lblCurrentAssignments = new System.Windows.Forms.GroupBox();
            this.btnSubmitGrade = new System.Windows.Forms.Button();
            this.dgvAddFinalGrades = new System.Windows.Forms.DataGridView();
            this.lblEarnedPoints = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblStudentLookup = new System.Windows.Forms.Label();
            this.lnlStudentID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbDropCourse = new System.Windows.Forms.ComboBox();
            this.lblProfessorDisplayCoursesTaught.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesBeingTaught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            this.lblCurrentAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFinalGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfessorDisplayCoursesTaught
            // 
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.cbDropCourse);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.lblProfessorCourses);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.btnDropCourse);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.btnLoadCourses);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.lblProfessorID);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.txtProfessorID);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.dgvCoursesBeingTaught);
            this.lblProfessorDisplayCoursesTaught.Location = new System.Drawing.Point(12, 12);
            this.lblProfessorDisplayCoursesTaught.Name = "lblProfessorDisplayCoursesTaught";
            this.lblProfessorDisplayCoursesTaught.Size = new System.Drawing.Size(715, 278);
            this.lblProfessorDisplayCoursesTaught.TabIndex = 0;
            this.lblProfessorDisplayCoursesTaught.TabStop = false;
            this.lblProfessorDisplayCoursesTaught.Text = "Course Lookup";
            // 
            // lblProfessorCourses
            // 
            this.lblProfessorCourses.AutoSize = true;
            this.lblProfessorCourses.Location = new System.Drawing.Point(417, 25);
            this.lblProfessorCourses.Name = "lblProfessorCourses";
            this.lblProfessorCourses.Size = new System.Drawing.Size(121, 13);
            this.lblProfessorCourses.TabIndex = 3;
            this.lblProfessorCourses.Text = "Course(s) Being Taught:";
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(67, 219);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(106, 31);
            this.btnDropCourse.TabIndex = 4;
            this.btnDropCourse.Text = "Drop Course";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(67, 97);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(106, 31);
            this.btnLoadCourses.TabIndex = 4;
            this.btnLoadCourses.Text = "Load Courses";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // lblProfessorID
            // 
            this.lblProfessorID.AutoSize = true;
            this.lblProfessorID.Location = new System.Drawing.Point(21, 63);
            this.lblProfessorID.Name = "lblProfessorID";
            this.lblProfessorID.Size = new System.Drawing.Size(68, 13);
            this.lblProfessorID.TabIndex = 2;
            this.lblProfessorID.Text = "Professor ID:";
            // 
            // txtProfessorID
            // 
            this.txtProfessorID.Location = new System.Drawing.Point(114, 60);
            this.txtProfessorID.Name = "txtProfessorID";
            this.txtProfessorID.Size = new System.Drawing.Size(100, 20);
            this.txtProfessorID.TabIndex = 1;
            // 
            // dgvCoursesBeingTaught
            // 
            this.dgvCoursesBeingTaught.AutoGenerateColumns = false;
            this.dgvCoursesBeingTaught.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesBeingTaught.DataSource = this.reg_dbDataSet;
            this.dgvCoursesBeingTaught.Location = new System.Drawing.Point(264, 41);
            this.dgvCoursesBeingTaught.Name = "dgvCoursesBeingTaught";
            this.dgvCoursesBeingTaught.Size = new System.Drawing.Size(410, 209);
            this.dgvCoursesBeingTaught.TabIndex = 0;
            // 
            // reg_dbDataSet
            // 
            this.reg_dbDataSet.DataSetName = "reg_dbDataSet";
            this.reg_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.reg_dbDataSet;
            // 
            // btnLoadSubmissions
            // 
            this.btnLoadSubmissions.Location = new System.Drawing.Point(67, 90);
            this.btnLoadSubmissions.Name = "btnLoadSubmissions";
            this.btnLoadSubmissions.Size = new System.Drawing.Size(106, 31);
            this.btnLoadSubmissions.TabIndex = 4;
            this.btnLoadSubmissions.Text = "Load Submissions";
            this.btnLoadSubmissions.UseVisualStyleBackColor = true;
            this.btnLoadSubmissions.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // lblCurrentAssignments
            // 
            this.lblCurrentAssignments.Controls.Add(this.btnSubmitGrade);
            this.lblCurrentAssignments.Controls.Add(this.btnLoadSubmissions);
            this.lblCurrentAssignments.Controls.Add(this.dgvAddFinalGrades);
            this.lblCurrentAssignments.Controls.Add(this.lblEarnedPoints);
            this.lblCurrentAssignments.Controls.Add(this.textBox3);
            this.lblCurrentAssignments.Controls.Add(this.lblStudentLookup);
            this.lblCurrentAssignments.Controls.Add(this.lnlStudentID);
            this.lblCurrentAssignments.Controls.Add(this.textBox2);
            this.lblCurrentAssignments.Location = new System.Drawing.Point(12, 296);
            this.lblCurrentAssignments.Name = "lblCurrentAssignments";
            this.lblCurrentAssignments.Size = new System.Drawing.Size(715, 283);
            this.lblCurrentAssignments.TabIndex = 1;
            this.lblCurrentAssignments.TabStop = false;
            this.lblCurrentAssignments.Text = "Course Assignments";
            // 
            // btnSubmitGrade
            // 
            this.btnSubmitGrade.Location = new System.Drawing.Point(67, 196);
            this.btnSubmitGrade.Name = "btnSubmitGrade";
            this.btnSubmitGrade.Size = new System.Drawing.Size(106, 31);
            this.btnSubmitGrade.TabIndex = 4;
            this.btnSubmitGrade.Text = "Submit Grade";
            this.btnSubmitGrade.UseVisualStyleBackColor = true;
            // 
            // dgvAddFinalGrades
            // 
            this.dgvAddFinalGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddFinalGrades.Location = new System.Drawing.Point(238, 44);
            this.dgvAddFinalGrades.Name = "dgvAddFinalGrades";
            this.dgvAddFinalGrades.Size = new System.Drawing.Size(436, 220);
            this.dgvAddFinalGrades.TabIndex = 0;
            // 
            // lblEarnedPoints
            // 
            this.lblEarnedPoints.AutoSize = true;
            this.lblEarnedPoints.Location = new System.Drawing.Point(21, 156);
            this.lblEarnedPoints.Name = "lblEarnedPoints";
            this.lblEarnedPoints.Size = new System.Drawing.Size(76, 13);
            this.lblEarnedPoints.TabIndex = 2;
            this.lblEarnedPoints.Text = "Earned Grade:";
            this.lblEarnedPoints.Click += new System.EventHandler(this.lblEarnedPoints_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // lblStudentLookup
            // 
            this.lblStudentLookup.AutoSize = true;
            this.lblStudentLookup.Location = new System.Drawing.Point(21, 27);
            this.lblStudentLookup.Name = "lblStudentLookup";
            this.lblStudentLookup.Size = new System.Drawing.Size(86, 13);
            this.lblStudentLookup.TabIndex = 2;
            this.lblStudentLookup.Text = "Student Lookup:";
            // 
            // lnlStudentID
            // 
            this.lnlStudentID.AutoSize = true;
            this.lnlStudentID.Location = new System.Drawing.Point(21, 58);
            this.lnlStudentID.Name = "lnlStudentID";
            this.lnlStudentID.Size = new System.Drawing.Size(61, 13);
            this.lnlStudentID.TabIndex = 2;
            this.lnlStudentID.Text = "Student ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // cbDropCourse
            // 
            this.cbDropCourse.FormattingEnabled = true;
            this.cbDropCourse.Location = new System.Drawing.Point(67, 174);
            this.cbDropCourse.Name = "cbDropCourse";
            this.cbDropCourse.Size = new System.Drawing.Size(106, 21);
            this.cbDropCourse.TabIndex = 5;
            // 
            // ProfessorGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 602);
            this.Controls.Add(this.lblCurrentAssignments);
            this.Controls.Add(this.lblProfessorDisplayCoursesTaught);
            this.Name = "ProfessorGradeForm";
            this.Text = "ProfessorGradeForm";
            this.lblProfessorDisplayCoursesTaught.ResumeLayout(false);
            this.lblProfessorDisplayCoursesTaught.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesBeingTaught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            this.lblCurrentAssignments.ResumeLayout(false);
            this.lblCurrentAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFinalGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblProfessorDisplayCoursesTaught;
        private reg_dbDataSet reg_dbDataSet;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private System.Windows.Forms.DataGridView dgvCoursesBeingTaught;
        private System.Windows.Forms.Label lblProfessorCourses;
        private System.Windows.Forms.Label lblProfessorID;
        private System.Windows.Forms.TextBox txtProfessorID;
        private System.Windows.Forms.Button btnLoadSubmissions;
        private System.Windows.Forms.GroupBox lblCurrentAssignments;
        private System.Windows.Forms.DataGridView dgvAddFinalGrades;
        private System.Windows.Forms.Label lblEarnedPoints;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lnlStudentID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblStudentLookup;
        private System.Windows.Forms.Button btnSubmitGrade;
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.ComboBox cbDropCourse;
    }
}