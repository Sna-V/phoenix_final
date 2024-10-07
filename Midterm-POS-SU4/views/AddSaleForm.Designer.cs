namespace Midterm_POS_SU4.views
{
    partial class AddSaleForm
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
            this.picSales = new System.Windows.Forms.PictureBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblQTY = new System.Windows.Forms.Label();
            this.numQTY = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).BeginInit();
            this.SuspendLayout();
            // 
            // picSales
            // 
            this.picSales.Image = global::Midterm_POS_SU4.Properties.Resources.sales_black_512px;
            this.picSales.Location = new System.Drawing.Point(12, 20);
            this.picSales.Name = "picSales";
            this.picSales.Size = new System.Drawing.Size(81, 81);
            this.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSales.TabIndex = 4;
            this.picSales.TabStop = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerName.Location = new System.Drawing.Point(12, 131);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(126, 18);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.DropDownHeight = 200;
            this.cboCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.IntegralHeight = false;
            this.cboCustomerName.Location = new System.Drawing.Point(12, 157);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(560, 26);
            this.cboCustomerName.TabIndex = 0;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProductName.Location = new System.Drawing.Point(12, 190);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 18);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Product Name:";
            // 
            // cboProductName
            // 
            this.cboProductName.DropDownHeight = 200;
            this.cboProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.IntegralHeight = false;
            this.cboProductName.Location = new System.Drawing.Point(10, 216);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(560, 26);
            this.cboProductName.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPrice.Location = new System.Drawing.Point(12, 249);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 18);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSellPrice.Location = new System.Drawing.Point(12, 275);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(560, 26);
            this.txtSellPrice.TabIndex = 2;
            this.txtSellPrice.TextChanged += new System.EventHandler(this.txtSellPrice_TextChanged);
            // 
            // lblQTY
            // 
            this.lblQTY.AutoSize = true;
            this.lblQTY.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQTY.Location = new System.Drawing.Point(12, 316);
            this.lblQTY.Name = "lblQTY";
            this.lblQTY.Size = new System.Drawing.Size(41, 18);
            this.lblQTY.TabIndex = 15;
            this.lblQTY.Text = "QTY:";
            // 
            // numQTY
            // 
            this.numQTY.Location = new System.Drawing.Point(59, 312);
            this.numQTY.Name = "numQTY";
            this.numQTY.Size = new System.Drawing.Size(100, 26);
            this.numQTY.TabIndex = 3;
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
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblAddSale
            // 
            this.lblAddSale.AutoSize = true;
            this.lblAddSale.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSale.Location = new System.Drawing.Point(215, 42);
            this.lblAddSale.Name = "lblAddSale";
            this.lblAddSale.Size = new System.Drawing.Size(154, 37);
            this.lblAddSale.TabIndex = 21;
            this.lblAddSale.Text = "Add Sale";
            // 
            // AddSaleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblAddSale);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numQTY);
            this.Controls.Add(this.lblQTY);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.picSales);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSaleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSales;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblQTY;
        public System.Windows.Forms.NumericUpDown numQTY;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblAddSale;
    }
}