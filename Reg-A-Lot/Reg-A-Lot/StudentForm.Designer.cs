namespace Reg_A_Lot
{
    partial class StudentForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reg_dbDataSet1 = new Reg_A_Lot.reg_dbDataSet();
            this.reg_dbDataSet2 = new Reg_A_Lot.reg_dbDataSet();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbStudentCourseRegistration = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudentRegister = new System.Windows.Forms.Button();
            this.txtStudentUserName = new System.Windows.Forms.TextBox();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.lblStudentUsername = new System.Windows.Forms.Label();
            this.lblStudentFormBreak = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentPhone = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 672);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1142, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // reg_dbDataSet1
            // 
            this.reg_dbDataSet1.DataSetName = "reg_dbDataSet";
            this.reg_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reg_dbDataSet2
            // 
            this.reg_dbDataSet2.DataSetName = "reg_dbDataSet";
            this.reg_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Location = new System.Drawing.Point(32, 37);
            this.lblStudentFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblStudentFirstName.TabIndex = 4;
            this.lblStudentFirstName.Text = "First Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbStudentCourseRegistration);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStudentRegister);
            this.groupBox1.Controls.Add(this.txtStudentUserName);
            this.groupBox1.Controls.Add(this.txtStudentPhoneNumber);
            this.groupBox1.Controls.Add(this.txtStudentPassword);
            this.groupBox1.Controls.Add(this.txtStudentAge);
            this.groupBox1.Controls.Add(this.txtStudentAddress);
            this.groupBox1.Controls.Add(this.txtStudentLastName);
            this.groupBox1.Controls.Add(this.txtStudentEmail);
            this.groupBox1.Controls.Add(this.txtStudentFirstName);
            this.groupBox1.Controls.Add(this.lblStudentPassword);
            this.groupBox1.Controls.Add(this.lblStudentUsername);
            this.groupBox1.Controls.Add(this.lblStudentFormBreak);
            this.groupBox1.Controls.Add(this.lblStudentEmail);
            this.groupBox1.Controls.Add(this.lblStudentPhone);
            this.groupBox1.Controls.Add(this.lblStudentAddress);
            this.groupBox1.Controls.Add(this.lblStudentAge);
            this.groupBox1.Controls.Add(this.lblStudentLastName);
            this.groupBox1.Controls.Add(this.lblStudentFirstName);
            this.groupBox1.Location = new System.Drawing.Point(50, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1010, 614);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student\'s Information";
            // 
            // clbStudentCourseRegistration
            // 
            this.clbStudentCourseRegistration.CheckOnClick = true;
            this.clbStudentCourseRegistration.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.reg_dbDataSet1, "Sections.Id", true));
            this.clbStudentCourseRegistration.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionsBindingSource, "Id", true));
            this.clbStudentCourseRegistration.FormattingEnabled = true;
            this.clbStudentCourseRegistration.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3",
            "item4",
            "item5"});
            this.clbStudentCourseRegistration.Location = new System.Drawing.Point(160, 373);
            this.clbStudentCourseRegistration.Name = "clbStudentCourseRegistration";
            this.clbStudentCourseRegistration.ScrollAlwaysVisible = true;
            this.clbStudentCourseRegistration.Size = new System.Drawing.Size(612, 151);
            this.clbStudentCourseRegistration.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please select the courses you want to register for:";
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Location = new System.Drawing.Point(389, 545);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(285, 44);
            this.btnStudentRegister.TabIndex = 14;
            this.btnStudentRegister.Text = "Submit Information and Register";
            this.btnStudentRegister.UseVisualStyleBackColor = true;
            this.btnStudentRegister.Click += new System.EventHandler(this.btnStudentRegister_Click);
            // 
            // txtStudentUserName
            // 
            this.txtStudentUserName.Location = new System.Drawing.Point(633, 106);
            this.txtStudentUserName.Name = "txtStudentUserName";
            this.txtStudentUserName.Size = new System.Drawing.Size(336, 26);
            this.txtStudentUserName.TabIndex = 13;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(190, 166);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(336, 26);
            this.txtStudentPhoneNumber.TabIndex = 13;
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Location = new System.Drawing.Point(633, 157);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(336, 26);
            this.txtStudentPassword.TabIndex = 13;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(190, 122);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(336, 26);
            this.txtStudentAge.TabIndex = 13;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(633, 40);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(336, 43);
            this.txtStudentAddress.TabIndex = 13;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(190, 81);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(336, 26);
            this.txtStudentLastName.TabIndex = 13;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(190, 213);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(336, 26);
            this.txtStudentEmail.TabIndex = 13;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(190, 37);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(336, 26);
            this.txtStudentFirstName.TabIndex = 13;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Location = new System.Drawing.Point(543, 157);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(82, 20);
            this.lblStudentPassword.TabIndex = 12;
            this.lblStudentPassword.Text = "Password:";
            // 
            // lblStudentUsername
            // 
            this.lblStudentUsername.AutoSize = true;
            this.lblStudentUsername.Location = new System.Drawing.Point(543, 106);
            this.lblStudentUsername.Name = "lblStudentUsername";
            this.lblStudentUsername.Size = new System.Drawing.Size(87, 20);
            this.lblStudentUsername.TabIndex = 11;
            this.lblStudentUsername.Text = "Username:";
            // 
            // lblStudentFormBreak
            // 
            this.lblStudentFormBreak.AutoSize = true;
            this.lblStudentFormBreak.Location = new System.Drawing.Point(32, 262);
            this.lblStudentFormBreak.Name = "lblStudentFormBreak";
            this.lblStudentFormBreak.Size = new System.Drawing.Size(936, 20);
            this.lblStudentFormBreak.TabIndex = 10;
            this.lblStudentFormBreak.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(32, 213);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(52, 20);
            this.lblStudentEmail.TabIndex = 9;
            this.lblStudentEmail.Text = "Email:";
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.Location = new System.Drawing.Point(32, 166);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(119, 20);
            this.lblStudentPhone.TabIndex = 8;
            this.lblStudentPhone.Text = "Phone Number:";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(543, 43);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(72, 20);
            this.lblStudentAddress.TabIndex = 7;
            this.lblStudentAddress.Text = "Address:";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(32, 124);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(42, 20);
            this.lblStudentAge.TabIndex = 6;
            this.lblStudentAge.Text = "Age:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(32, 81);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(90, 20);
            this.lblStudentLastName.TabIndex = 5;
            this.lblStudentLastName.Text = "Last Name:";
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.reg_dbDataSet1;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1142, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentForm";
            this.Text = "Student Registration Form";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_dbDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private reg_dbDataSet reg_dbDataSet1;
        private reg_dbDataSet reg_dbDataSet2;
        private System.Windows.Forms.Label lblStudentFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStudentPhone;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.Button btnStudentRegister;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label lblStudentFormBreak;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.TextBox txtStudentUserName;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.Label lblStudentUsername;
        private System.Windows.Forms.CheckedListBox clbStudentCourseRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
    }
}



