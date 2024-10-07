namespace Midterm_POS_SU4.views
{
    partial class ViewInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPhoenix = new System.Windows.Forms.Label();
            this.lblBillTo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRepName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhoenix
            // 
            this.lblPhoenix.AutoSize = true;
            this.lblPhoenix.Font = new System.Drawing.Font("LEMON MILK", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoenix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.lblPhoenix.Location = new System.Drawing.Point(493, 9);
            this.lblPhoenix.Name = "lblPhoenix";
            this.lblPhoenix.Size = new System.Drawing.Size(182, 30);
            this.lblPhoenix.TabIndex = 5;
            this.lblPhoenix.Text = "P  H  O  E  N  I  X";
            // 
            // lblBillTo
            // 
            this.lblBillTo.AutoSize = true;
            this.lblBillTo.BackColor = System.Drawing.Color.White;
            this.lblBillTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBillTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTo.ForeColor = System.Drawing.Color.Black;
            this.lblBillTo.Location = new System.Drawing.Point(12, 137);
            this.lblBillTo.Name = "lblBillTo";
            this.lblBillTo.Size = new System.Drawing.Size(77, 19);
            this.lblBillTo.TabIndex = 6;
            this.lblBillTo.Text = "BILL TO:";
            this.lblBillTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomerName.Location = new System.Drawing.Point(13, 156);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(327, 20);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Name:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGender.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Gray;
            this.lblGender.Location = new System.Drawing.Point(13, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(327, 18);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 192);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(327, 18);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(13, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(327, 18);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colDescription,
            this.colQuantity,
            this.colPrice,
            this.colSubTotal});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvSales.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvSales.Location = new System.Drawing.Point(12, 237);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.ShowCellErrors = false;
            this.dgvSales.ShowCellToolTips = false;
            this.dgvSales.ShowEditingIcon = false;
            this.dgvSales.ShowRowErrors = false;
            this.dgvSales.Size = new System.Drawing.Size(660, 349);
            this.dgvSales.TabIndex = 17;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No#";
            this.colNo.MinimumWidth = 38;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 38;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 100;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 79;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 87;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 10);
            this.label1.TabIndex = 18;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.Color.Black;
            this.lblInvoice.Location = new System.Drawing.Point(3, 3);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(127, 32);
            this.lblInvoice.TabIndex = 19;
            this.lblInvoice.Text = "INVOICE";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.BackColor = System.Drawing.Color.White;
            this.lblInvoiceNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(346, 173);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(326, 20);
            this.lblInvoiceNumber.TabIndex = 20;
            this.lblInvoiceNumber.Text = "Invoice Number:";
            this.lblInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalValue.Location = new System.Drawing.Point(488, 598);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalValue.Size = new System.Drawing.Size(184, 32);
            this.lblTotalValue.TabIndex = 22;
            this.lblTotalValue.Text = "0.00 USD";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(403, 598);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 32);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(346, 209);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(326, 20);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRepName
            // 
            this.lblRepName.BackColor = System.Drawing.Color.White;
            this.lblRepName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRepName.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepName.ForeColor = System.Drawing.Color.Gray;
            this.lblRepName.Location = new System.Drawing.Point(346, 191);
            this.lblRepName.Name = "lblRepName";
            this.lblRepName.Size = new System.Drawing.Size(326, 20);
            this.lblRepName.TabIndex = 24;
            this.lblRepName.Text = "Sale Rep:";
            this.lblRepName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvoiceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblRepName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblBillTo);
            this.Controls.Add(this.lblPhoenix);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPhoenix;
        private System.Windows.Forms.Label lblBillTo;
        public System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvoice;
        public System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.Label lblPhoneNumber;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblTotalValue;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblInvoiceNumber;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        public System.Windows.Forms.Label lblRepName;
    }
}