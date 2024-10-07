namespace Midterm_POS_SU4
{
    partial class MainForm
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnMiddle = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblPhoenix = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.pnLeft.Controls.Add(this.btnInvoices);
            this.pnLeft.Controls.Add(this.btnSales);
            this.pnLeft.Controls.Add(this.btnLogOut);
            this.pnLeft.Controls.Add(this.btnCustomers);
            this.pnLeft.Controls.Add(this.btnSuppliers);
            this.pnLeft.Controls.Add(this.btnProducts);
            this.pnLeft.Controls.Add(this.btnCategories);
            this.pnLeft.Controls.Add(this.btnRoles);
            this.pnLeft.Controls.Add(this.btnUsers);
            this.pnLeft.Location = new System.Drawing.Point(0, 82);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(202, 500);
            this.pnLeft.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 450);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(202, 50);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnMiddle
            // 
            this.pnMiddle.BackColor = System.Drawing.Color.White;
            this.pnMiddle.Location = new System.Drawing.Point(218, 82);
            this.pnMiddle.Name = "pnMiddle";
            this.pnMiddle.Size = new System.Drawing.Size(1028, 500);
            this.pnMiddle.TabIndex = 4;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.lblPhoenix);
            this.pnTop.Controls.Add(this.lblUserName);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Location = new System.Drawing.Point(0, -5);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1261, 74);
            this.pnTop.TabIndex = 5;
            // 
            // lblPhoenix
            // 
            this.lblPhoenix.AutoSize = true;
            this.lblPhoenix.Font = new System.Drawing.Font("LEMON MILK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoenix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.lblPhoenix.Location = new System.Drawing.Point(10, 27);
            this.lblPhoenix.Name = "lblPhoenix";
            this.lblPhoenix.Size = new System.Drawing.Size(182, 30);
            this.lblPhoenix.TabIndex = 4;
            this.lblPhoenix.Text = "P  H  O  E  N  I  X";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.Location = new System.Drawing.Point(947, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(249, 47);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Midterm_POS_SU4.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1202, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnInvoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInvoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.ForeColor = System.Drawing.Color.White;
            this.btnInvoices.Image = global::Midterm_POS_SU4.Properties.Resources.invoices_white_24px;
            this.btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.Location = new System.Drawing.Point(0, 350);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(202, 50);
            this.btnInvoices.TabIndex = 9;
            this.btnInvoices.Text = "     Invoices";
            this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::Midterm_POS_SU4.Properties.Resources.sale_white_24px;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 300);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(202, 50);
            this.btnSales.TabIndex = 7;
            this.btnSales.Text = "     Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::Midterm_POS_SU4.Properties.Resources.customer_white_24px;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 250);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(202, 50);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "     Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Image = global::Midterm_POS_SU4.Properties.Resources.supplier_white_24px;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 200);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(202, 50);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "     Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::Midterm_POS_SU4.Properties.Resources.product_white_24px;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 150);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(202, 50);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "     Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::Midterm_POS_SU4.Properties.Resources.categories_white_24px;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 100);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(202, 50);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "     Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = global::Midterm_POS_SU4.Properties.Resources.role_white_24px;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 50);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(202, 50);
            this.btnRoles.TabIndex = 2;
            this.btnRoles.Text = "     Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Midterm_POS_SU4.Properties.Resources.user_white_24px1;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(202, 50);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "     Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 601);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMiddle);
            this.Controls.Add(this.pnLeft);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 640);
            this.MinimumSize = new System.Drawing.Size(1280, 640);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnLeft.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnMiddle;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSales;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Label lblPhoenix;
        public System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnInvoices;
    }
}

