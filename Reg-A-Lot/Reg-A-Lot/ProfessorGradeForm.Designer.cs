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
            this.cbDropCourse = new System.Windows.Forms.ComboBox();
            this.cbAddCourse = new System.Windows.Forms.ComboBox();
            this.lblProfessorCourses = new System.Windows.Forms.Label();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblProfessorID = new System.Windows.Forms.Label();
            this.txtProfessorID = new System.Windows.Forms.TextBox();
            this.dgvCoursesBeingTaught = new System.Windows.Forms.DataGridView();
            this.reg_dbDataSet = new Reg_A_Lot.reg_dbDataSet();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadSubmissions = new System.Windows.Forms.Button();
            this.lblCurrentAssignments = new System.Windows.Forms.GroupBox();
            this.cbCourseGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCourseOfGrade = new System.Windows.Forms.ComboBox();
            this.lbCourseGrade = new System.Windows.Forms.Label();
            this.btnSubmitGrade = new System.Windows.Forms.Button();
            this.dgvAddFinalGrades = new System.Windows.Forms.DataGridView();
            this.lblEarnedPoints = new System.Windows.Forms.Label();
            this.txtEarnedGrade = new System.Windows.Forms.TextBox();
            this.lblStudentLookup = new System.Windows.Forms.Label();
            this.lnlStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentGradeID = new System.Windows.Forms.TextBox();
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
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.cbAddCourse);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.lblProfessorCourses);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.btnDropCourse);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.btnAddCourse);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.lblProfessorID);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.txtProfessorID);
            this.lblProfessorDisplayCoursesTaught.Controls.Add(this.dgvCoursesBeingTaught);
            this.lblProfessorDisplayCoursesTaught.Location = new System.Drawing.Point(18, 19);
            this.lblProfessorDisplayCoursesTaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblProfessorDisplayCoursesTaught.Name = "lblProfessorDisplayCoursesTaught";
            this.lblProfessorDisplayCoursesTaught.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblProfessorDisplayCoursesTaught.Size = new System.Drawing.Size(1072, 428);
            this.lblProfessorDisplayCoursesTaught.TabIndex = 0;
            this.lblProfessorDisplayCoursesTaught.TabStop = false;
            this.lblProfessorDisplayCoursesTaught.Text = "Course Lookup";
            // 
            // cbDropCourse
            // 
            this.cbDropCourse.FormattingEnabled = true;
            this.cbDropCourse.Location = new System.Drawing.Point(102, 263);
            this.cbDropCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDropCourse.Name = "cbDropCourse";
            this.cbDropCourse.Size = new System.Drawing.Size(157, 28);
            this.cbDropCourse.TabIndex = 5;
            // 
            // cbAddCourse
            // 
            this.cbAddCourse.FormattingEnabled = true;
            this.cbAddCourse.Location = new System.Drawing.Point(100, 149);
            this.cbAddCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAddCourse.Name = "cbAddCourse";
            this.cbAddCourse.Size = new System.Drawing.Size(157, 28);
            this.cbAddCourse.TabIndex = 5;
            // 
            // lblProfessorCourses
            // 
            this.lblProfessorCourses.AutoSize = true;
            this.lblProfessorCourses.Location = new System.Drawing.Point(626, 39);
            this.lblProfessorCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessorCourses.Name = "lblProfessorCourses";
            this.lblProfessorCourses.Size = new System.Drawing.Size(181, 20);
            this.lblProfessorCourses.TabIndex = 3;
            this.lblProfessorCourses.Text = "Course(s) Being Taught:";
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(102, 301);
            this.btnDropCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(159, 48);
            this.btnDropCourse.TabIndex = 4;
            this.btnDropCourse.Text = "Drop Course";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(100, 187);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(159, 48);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Teach Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // lblProfessorID
            // 
            this.lblProfessorID.AutoSize = true;
            this.lblProfessorID.Location = new System.Drawing.Point(32, 98);
            this.lblProfessorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfessorID.Name = "lblProfessorID";
            this.lblProfessorID.Size = new System.Drawing.Size(102, 20);
            this.lblProfessorID.TabIndex = 2;
            this.lblProfessorID.Text = "Professor ID:";
            // 
            // txtProfessorID
            // 
            this.txtProfessorID.Location = new System.Drawing.Point(171, 92);
            this.txtProfessorID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProfessorID.Name = "txtProfessorID";
            this.txtProfessorID.Size = new System.Drawing.Size(148, 26);
            this.txtProfessorID.TabIndex = 1;
            // 
            // dgvCoursesBeingTaught
            // 
            this.dgvCoursesBeingTaught.AutoGenerateColumns = false;
            this.dgvCoursesBeingTaught.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesBeingTaught.DataSource = this.reg_dbDataSet;
            this.dgvCoursesBeingTaught.Location = new System.Drawing.Point(396, 62);
            this.dgvCoursesBeingTaught.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCoursesBeingTaught.Name = "dgvCoursesBeingTaught";
            this.dgvCoursesBeingTaught.Size = new System.Drawing.Size(615, 321);
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
            this.btnLoadSubmissions.Location = new System.Drawing.Point(100, 165);
            this.btnLoadSubmissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadSubmissions.Name = "btnLoadSubmissions";
            this.btnLoadSubmissions.Size = new System.Drawing.Size(159, 48);
            this.btnLoadSubmissions.TabIndex = 4;
            this.btnLoadSubmissions.Text = "Load Submissions";
            this.btnLoadSubmissions.UseVisualStyleBackColor = true;
            this.btnLoadSubmissions.Click += new System.EventHandler(this.btnLoadSubmissions_Click);
            // 
            // lblCurrentAssignments
            // 
            this.lblCurrentAssignments.Controls.Add(this.label2);
            this.lblCurrentAssignments.Controls.Add(this.txtStudentGradeID);
            this.lblCurrentAssignments.Controls.Add(this.cbCourseGrade);
            this.lblCurrentAssignments.Controls.Add(this.label1);
            this.lblCurrentAssignments.Controls.Add(this.cbCourseOfGrade);
            this.lblCurrentAssignments.Controls.Add(this.lbCourseGrade);
            this.lblCurrentAssignments.Controls.Add(this.btnSubmitGrade);
            this.lblCurrentAssignments.Controls.Add(this.btnLoadSubmissions);
            this.lblCurrentAssignments.Controls.Add(this.dgvAddFinalGrades);
            this.lblCurrentAssignments.Controls.Add(this.lblEarnedPoints);
            this.lblCurrentAssignments.Controls.Add(this.txtEarnedGrade);
            this.lblCurrentAssignments.Controls.Add(this.lblStudentLookup);
            this.lblCurrentAssignments.Controls.Add(this.lnlStudentID);
            this.lblCurrentAssignments.Controls.Add(this.txtStudentID);
            this.lblCurrentAssignments.Location = new System.Drawing.Point(18, 455);
            this.lblCurrentAssignments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblCurrentAssignments.Name = "lblCurrentAssignments";
            this.lblCurrentAssignments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblCurrentAssignments.Size = new System.Drawing.Size(1072, 435);
            this.lblCurrentAssignments.TabIndex = 1;
            this.lblCurrentAssignments.TabStop = false;
            this.lblCurrentAssignments.Text = "Course Assignments";
            // 
            // cbCourseGrade
            // 
            this.cbCourseGrade.FormattingEnabled = true;
            this.cbCourseGrade.Location = new System.Drawing.Point(171, 119);
            this.cbCourseGrade.Name = "cbCourseGrade";
            this.cbCourseGrade.Size = new System.Drawing.Size(148, 28);
            this.cbCourseGrade.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course:";
            // 
            // cbCourseOfGrade
            // 
            this.cbCourseOfGrade.FormattingEnabled = true;
            this.cbCourseOfGrade.Location = new System.Drawing.Point(171, 270);
            this.cbCourseOfGrade.Name = "cbCourseOfGrade";
            this.cbCourseOfGrade.Size = new System.Drawing.Size(148, 28);
            this.cbCourseOfGrade.TabIndex = 6;
            // 
            // lbCourseGrade
            // 
            this.lbCourseGrade.AutoSize = true;
            this.lbCourseGrade.Location = new System.Drawing.Point(32, 270);
            this.lbCourseGrade.Name = "lbCourseGrade";
            this.lbCourseGrade.Size = new System.Drawing.Size(64, 20);
            this.lbCourseGrade.TabIndex = 5;
            this.lbCourseGrade.Text = "Course:";
            // 
            // btnSubmitGrade
            // 
            this.btnSubmitGrade.Location = new System.Drawing.Point(100, 359);
            this.btnSubmitGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitGrade.Name = "btnSubmitGrade";
            this.btnSubmitGrade.Size = new System.Drawing.Size(159, 48);
            this.btnSubmitGrade.TabIndex = 4;
            this.btnSubmitGrade.Text = "Submit Grade";
            this.btnSubmitGrade.UseVisualStyleBackColor = true;
            this.btnSubmitGrade.Click += new System.EventHandler(this.btnSubmitGrade_Click);
            // 
            // dgvAddFinalGrades
            // 
            this.dgvAddFinalGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddFinalGrades.Location = new System.Drawing.Point(357, 68);
            this.dgvAddFinalGrades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAddFinalGrades.Name = "dgvAddFinalGrades";
            this.dgvAddFinalGrades.Size = new System.Drawing.Size(654, 339);
            this.dgvAddFinalGrades.TabIndex = 0;
            // 
            // lblEarnedPoints
            // 
            this.lblEarnedPoints.AutoSize = true;
            this.lblEarnedPoints.Location = new System.Drawing.Point(32, 314);
            this.lblEarnedPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEarnedPoints.Name = "lblEarnedPoints";
            this.lblEarnedPoints.Size = new System.Drawing.Size(114, 20);
            this.lblEarnedPoints.TabIndex = 2;
            this.lblEarnedPoints.Text = "Earned Grade:";
            // 
            // txtEarnedGrade
            // 
            this.txtEarnedGrade.Location = new System.Drawing.Point(171, 306);
            this.txtEarnedGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEarnedGrade.Name = "txtEarnedGrade";
            this.txtEarnedGrade.Size = new System.Drawing.Size(148, 26);
            this.txtEarnedGrade.TabIndex = 1;
            // 
            // lblStudentLookup
            // 
            this.lblStudentLookup.AutoSize = true;
            this.lblStudentLookup.Location = new System.Drawing.Point(32, 41);
            this.lblStudentLookup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentLookup.Name = "lblStudentLookup";
            this.lblStudentLookup.Size = new System.Drawing.Size(127, 20);
            this.lblStudentLookup.TabIndex = 2;
            this.lblStudentLookup.Text = "Student Lookup:";
            // 
            // lnlStudentID
            // 
            this.lnlStudentID.AutoSize = true;
            this.lnlStudentID.Location = new System.Drawing.Point(32, 89);
            this.lnlStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlStudentID.Name = "lnlStudentID";
            this.lnlStudentID.Size = new System.Drawing.Size(91, 20);
            this.lnlStudentID.TabIndex = 2;
            this.lnlStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(171, 85);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(148, 26);
            this.txtStudentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID:";
            // 
            // txtStudentGradeID
            // 
            this.txtStudentGradeID.Location = new System.Drawing.Point(171, 236);
            this.txtStudentGradeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentGradeID.Name = "txtStudentGradeID";
            this.txtStudentGradeID.Size = new System.Drawing.Size(148, 26);
            this.txtStudentGradeID.TabIndex = 7;
            // 
            // ProfessorGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1162, 926);
            this.Controls.Add(this.lblCurrentAssignments);
            this.Controls.Add(this.lblProfessorDisplayCoursesTaught);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfessorGradeForm";
            this.Text = "ProfessorGradeForm";
            this.Load += new System.EventHandler(this.ProfessorGradeForm_Load);
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
        private System.Windows.Forms.TextBox txtEarnedGrade;
        private System.Windows.Forms.Label lnlStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentLookup;
        private System.Windows.Forms.Button btnSubmitGrade;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.ComboBox cbAddCourse;
        private System.Windows.Forms.ComboBox cbDropCourse;
        private System.Windows.Forms.ComboBox cbCourseOfGrade;
        private System.Windows.Forms.Label lbCourseGrade;
        private System.Windows.Forms.ComboBox cbCourseGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentGradeID;
    }
}