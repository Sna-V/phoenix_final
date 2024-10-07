namespace Midterm_POS_SU4.views
{
    partial class AddStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStockForm));
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.Transparent;
            this.pbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProduct.ErrorImage = global::Midterm_POS_SU4.Properties.Resources.blank_icon__1_;
            this.pbProduct.Image = global::Midterm_POS_SU4.Properties.Resources.landscape_image_gray_512px;
            this.pbProduct.InitialImage = global::Midterm_POS_SU4.Properties.Resources.landscape_image_black_512px;
            this.pbProduct.Location = new System.Drawing.Point(452, 12);
            this.pbProduct.Margin = new System.Windows.Forms.Padding(0);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(120, 120);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 30;
            this.pbProduct.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(45)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(560, 50);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(12, 300);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 18);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(205, 42);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(174, 37);
            this.lblAddStock.TabIndex = 11;
            this.lblAddStock.Text = "Add Stock";
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Enabled = false;
            this.txtProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProduct.Location = new System.Drawing.Point(12, 264);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(560, 26);
            this.txtProduct.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProduct.Location = new System.Drawing.Point(11, 243);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(66, 18);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product:";
            // 
            // txtProductId
            // 
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Enabled = false;
            this.txtProductId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProductId.Location = new System.Drawing.Point(12, 214);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(560, 26);
            this.txtProductId.TabIndex = 3;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProductId.Location = new System.Drawing.Point(9, 193);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(82, 18);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "Product Id:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSupplier.Location = new System.Drawing.Point(12, 143);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 18);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(12, 165);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(517, 26);
            this.cboSupplier.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantity.Location = new System.Drawing.Point(12, 321);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(560, 26);
            this.txtQuantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cost (USD):";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCost.Location = new System.Drawing.Point(12, 371);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(560, 26);
            this.txtCost.TabIndex = 9;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.Location = new System.Drawing.Point(535, 160);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(37, 37);
            this.btnAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // AddStockForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblSupplier);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbProduct;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.Label lblAddStock;
        public System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblProduct;
        public System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboSupplier;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.PictureBox btnAddCustomer;
    }
}