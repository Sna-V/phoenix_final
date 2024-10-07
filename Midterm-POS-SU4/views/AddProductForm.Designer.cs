namespace Midterm_POS_SU4.views
{
    partial class AddProductForm
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProduct.Location = new System.Drawing.Point(12, 164);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(560, 26);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProductName.Location = new System.Drawing.Point(12, 143);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 18);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBarcode.Location = new System.Drawing.Point(12, 214);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(560, 26);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBarcode.Location = new System.Drawing.Point(9, 193);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(72, 18);
            this.lblBarcode.TabIndex = 8;
            this.lblBarcode.Text = "Barcode:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSellPrice.Location = new System.Drawing.Point(12, 264);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(560, 26);
            this.txtSellPrice.TabIndex = 2;
            this.txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellPrice_KeyPress);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSellPrice.Location = new System.Drawing.Point(11, 243);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(127, 18);
            this.lblSellPrice.TabIndex = 10;
            this.lblSellPrice.Text = "Sell Price (USD):";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(189, 42);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(206, 37);
            this.lblAddProduct.TabIndex = 12;
            this.lblAddProduct.Text = "Add Product";
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
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.pbProduct.TabIndex = 18;
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.Black;
            this.btnSelectImage.Location = new System.Drawing.Point(452, 138);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(120, 23);
            this.btnSelectImage.TabIndex = 19;
            this.btnSelectImage.Text = "Select";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCategory.Location = new System.Drawing.Point(12, 300);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(76, 18);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.AllowDrop = true;
            this.cboCategory.DropDownHeight = 200;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.IntegralHeight = false;
            this.cboCategory.Location = new System.Drawing.Point(94, 296);
            this.cboCategory.MaxDropDownItems = 20;
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(179, 26);
            this.cboCategory.TabIndex = 5;
            this.cboCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCategory_KeyPress);
            // 
            // AddProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddProductForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        public System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        public System.Windows.Forms.Label lblAddProduct;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.ComboBox cboCategory;
    }
}