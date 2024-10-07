namespace Midterm_POS_SU4.views
{
    partial class AddCategoryForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.rFalse = new System.Windows.Forms.RadioButton();
            this.rTrue = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rFalse
            // 
            this.rFalse.AutoSize = true;
            this.rFalse.Location = new System.Drawing.Point(148, 188);
            this.rFalse.Name = "rFalse";
            this.rFalse.Size = new System.Drawing.Size(65, 22);
            this.rFalse.TabIndex = 50;
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
            this.rTrue.TabIndex = 49;
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
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status:";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.Location = new System.Drawing.Point(181, 37);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(225, 37);
            this.lblAddCategory.TabIndex = 47;
            this.lblAddCategory.Text = "Add Category";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategory.Location = new System.Drawing.Point(13, 149);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(560, 26);
            this.txtCategory.TabIndex = 46;
            this.txtCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoryName_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCategory.Location = new System.Drawing.Point(13, 123);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 18);
            this.lblCategory.TabIndex = 45;
            this.lblCategory.Text = "Category:";
            // 
            // AddCategoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 289);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rFalse);
            this.Controls.Add(this.rTrue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAddCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 328);
            this.Name = "AddCategoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.RadioButton rFalse;
        public System.Windows.Forms.RadioButton rTrue;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblAddCategory;
        public System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}