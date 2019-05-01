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
            this.menuStrip.Size = new System.Drawing.Size(761, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(761, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
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
            this.lblStudentFirstName.Location = new System.Drawing.Point(21, 24);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblStudentFirstName.TabIndex = 4;
            this.lblStudentFirstName.Text = "First Name: ";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 399);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student\'s Information";
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Location = new System.Drawing.Point(220, 291);
            this.btnStudentRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(190, 29);
            this.btnStudentRegister.TabIndex = 14;
            this.btnStudentRegister.Text = "Submit Information and Register";
            this.btnStudentRegister.UseVisualStyleBackColor = true;
            this.btnStudentRegister.Click += new System.EventHandler(this.btnStudentRegister_Click);
            // 
            // txtStudentUserName
            // 
            this.txtStudentUserName.Location = new System.Drawing.Point(53, 236);
            this.txtStudentUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentUserName.Name = "txtStudentUserName";
            this.txtStudentUserName.Size = new System.Drawing.Size(225, 20);
            this.txtStudentUserName.TabIndex = 13;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(127, 108);
            this.txtStudentPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(225, 20);
            this.txtStudentPhoneNumber.TabIndex = 13;
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Location = new System.Drawing.Point(354, 236);
            this.txtStudentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(225, 20);
            this.txtStudentPassword.TabIndex = 13;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(127, 79);
            this.txtStudentAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(225, 20);
            this.txtStudentAge.TabIndex = 13;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(422, 26);
            this.txtStudentAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(225, 29);
            this.txtStudentAddress.TabIndex = 13;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(127, 53);
            this.txtStudentLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(225, 20);
            this.txtStudentLastName.TabIndex = 13;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(422, 74);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(225, 20);
            this.txtStudentEmail.TabIndex = 13;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(127, 24);
            this.txtStudentFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(225, 20);
            this.txtStudentFirstName.TabIndex = 13;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Location = new System.Drawing.Point(351, 221);
            this.lblStudentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(56, 13);
            this.lblStudentPassword.TabIndex = 12;
            this.lblStudentPassword.Text = "Password:";
            // 
            // lblStudentUsername
            // 
            this.lblStudentUsername.AutoSize = true;
            this.lblStudentUsername.Location = new System.Drawing.Point(50, 221);
            this.lblStudentUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentUsername.Name = "lblStudentUsername";
            this.lblStudentUsername.Size = new System.Drawing.Size(58, 13);
            this.lblStudentUsername.TabIndex = 11;
            this.lblStudentUsername.Text = "Username:";
            // 
            // lblStudentFormBreak
            // 
            this.lblStudentFormBreak.AutoSize = true;
            this.lblStudentFormBreak.Location = new System.Drawing.Point(22, 174);
            this.lblStudentFormBreak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentFormBreak.Name = "lblStudentFormBreak";
            this.lblStudentFormBreak.Size = new System.Drawing.Size(625, 13);
            this.lblStudentFormBreak.TabIndex = 10;
            this.lblStudentFormBreak.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(362, 74);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(35, 13);
            this.lblStudentEmail.TabIndex = 9;
            this.lblStudentEmail.Text = "Email:";
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.Location = new System.Drawing.Point(21, 108);
            this.lblStudentPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(81, 13);
            this.lblStudentPhone.TabIndex = 8;
            this.lblStudentPhone.Text = "Phone Number:";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(362, 28);
            this.lblStudentAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(48, 13);
            this.lblStudentAddress.TabIndex = 7;
            this.lblStudentAddress.Text = "Address:";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(21, 81);
            this.lblStudentAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(29, 13);
            this.lblStudentAge.TabIndex = 6;
            this.lblStudentAge.Text = "Age:";
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Location = new System.Drawing.Point(21, 53);
            this.lblStudentLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(61, 13);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
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
        private System.Windows.Forms.BindingSource sectionsBindingSource;
    }
}



