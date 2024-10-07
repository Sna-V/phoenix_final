namespace Midterm_POS_SU4.views
{
    partial class AddRoleForm
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
            this.lblaRoleName = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblAddRole = new System.Windows.Forms.Label();
            this.rFalse = new System.Windows.Forms.RadioButton();
            this.rTrue = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblaRoleName
            // 
            this.lblaRoleName.AutoSize = true;
            this.lblaRoleName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblaRoleName.Location = new System.Drawing.Point(13, 123);
            this.lblaRoleName.Name = "lblaRoleName";
            this.lblaRoleName.Size = new System.Drawing.Size(90, 18);
            this.lblaRoleName.TabIndex = 37;
            this.lblaRoleName.Text = "Role Name:";
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRole.Location = new System.Drawing.Point(13, 149);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(560, 26);
            this.txtRole.TabIndex = 0;
            this.txtRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoleName_KeyPress);
            // 
            // lblAddRole
            // 
            this.lblAddRole.AutoSize = true;
            this.lblAddRole.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRole.Location = new System.Drawing.Point(215, 37);
            this.lblAddRole.Name = "lblAddRole";
            this.lblAddRole.Size = new System.Drawing.Size(156, 37);
            this.lblAddRole.TabIndex = 39;
            this.lblAddRole.Text = "Add Role";
            // 
            // rFalse
            // 
            this.rFalse.AutoSize = true;
            this.rFalse.Location = new System.Drawing.Point(148, 188);
            this.rFalse.Name = "rFalse";
            this.rFalse.Size = new System.Drawing.Size(65, 22);
            this.rFalse.TabIndex = 2;
            this.rFalse.Text = "False";
            this.rFalse.UseVisualStyleBackColor = true;
            this.rFalse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rFalse_KeyPress);
            // 
            // rTrue
            // 
            this.rTrue.AutoSize = true;
            this.rTrue.Checked = true;
            this.rTrue.Location = new System.Drawing.Point(86, 188);
            this.rTrue.Name = "rTrue";
            this.rTrue.Size = new System.Drawing.Size(56, 22);
            this.rTrue.TabIndex = 1;
            this.rTrue.TabStop = true;
            this.rTrue.Text = "True";
            this.rTrue.UseVisualStyleBackColor = true;
            this.rTrue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTrue_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(13, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Status:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(560, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddRoleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 289);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rFalse);
            this.Controls.Add(this.rTrue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAddRole);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblaRoleName);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 328);
            this.Name = "AddRoleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddRoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblaRoleName;
        public System.Windows.Forms.TextBox txtRole;
        public System.Windows.Forms.Label lblAddRole;
        public System.Windows.Forms.RadioButton rFalse;
        public System.Windows.Forms.RadioButton rTrue;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnAdd;
    }
}