namespace Midterm_POS_SU4.views
{
    partial class AddUserForm
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
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.cboRoleName = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rTrue = new System.Windows.Forms.RadioButton();
            this.rFalse = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(213, 42);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(158, 37);
            this.lblAddUser.TabIndex = 1;
            this.lblAddUser.Text = "Add User";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUserName.Location = new System.Drawing.Point(12, 131);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 18);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(12, 157);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(560, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPassword.Location = new System.Drawing.Point(12, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(10, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(560, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(12, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(560, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmail.Location = new System.Drawing.Point(12, 249);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGender.Location = new System.Drawing.Point(12, 308);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 18);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownHeight = 50;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.IntegralHeight = false;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(12, 334);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(273, 26);
            this.cboGender.TabIndex = 3;
            this.cboGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboGender_KeyPress);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRoleName.Location = new System.Drawing.Point(8, 368);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(44, 18);
            this.lblRoleName.TabIndex = 12;
            this.lblRoleName.Text = "Role:";
            // 
            // cboRoleName
            // 
            this.cboRoleName.DropDownHeight = 200;
            this.cboRoleName.FormattingEnabled = true;
            this.cboRoleName.IntegralHeight = false;
            this.cboRoleName.ItemHeight = 18;
            this.cboRoleName.Location = new System.Drawing.Point(12, 394);
            this.cboRoleName.Name = "cboRoleName";
            this.cboRoleName.Size = new System.Drawing.Size(273, 26);
            this.cboRoleName.TabIndex = 4;
            this.cboRoleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRoleName_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(11, 433);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // rTrue
            // 
            this.rTrue.AutoSize = true;
            this.rTrue.Checked = true;
            this.rTrue.Location = new System.Drawing.Point(73, 431);
            this.rTrue.Name = "rTrue";
            this.rTrue.Size = new System.Drawing.Size(56, 22);
            this.rTrue.TabIndex = 5;
            this.rTrue.TabStop = true;
            this.rTrue.Text = "True";
            this.rTrue.UseVisualStyleBackColor = true;
            this.rTrue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTrue_KeyPress);
            // 
            // rFalse
            // 
            this.rFalse.AutoSize = true;
            this.rFalse.Location = new System.Drawing.Point(135, 431);
            this.rFalse.Name = "rFalse";
            this.rFalse.Size = new System.Drawing.Size(65, 22);
            this.rFalse.TabIndex = 6;
            this.rFalse.Text = "False";
            this.rFalse.UseVisualStyleBackColor = true;
            this.rFalse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rFalse_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(560, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rFalse);
            this.Controls.Add(this.rTrue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAddUser);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.ComboBox cboGender;
        public System.Windows.Forms.ComboBox cboRoleName;
        public System.Windows.Forms.RadioButton rTrue;
        public System.Windows.Forms.RadioButton rFalse;
        public System.Windows.Forms.Label lblAddUser;
        public System.Windows.Forms.Button btnAdd;
    }
}