namespace Midterm_POS_SU4.views
{
    partial class SupplierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.PictureBox();
            this.lblLatestUpdate = new System.Windows.Forms.Label();
            this.lblTotalRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colSupplierId,
            this.colSupplierName,
            this.colTel,
            this.colAddress,
            this.colCreateBy,
            this.colCreateAt,
            this.colUpdateAt,
            this.colUpdateBy,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvSuppliers.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 55);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowHeadersWidth = 51;
            this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.ShowCellErrors = false;
            this.dgvSuppliers.ShowCellToolTips = false;
            this.dgvSuppliers.ShowEditingIcon = false;
            this.dgvSuppliers.ShowRowErrors = false;
            this.dgvSuppliers.Size = new System.Drawing.Size(1004, 417);
            this.dgvSuppliers.TabIndex = 6;
            this.dgvSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellContentClick);
            this.dgvSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellDoubleClick);
            this.dgvSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSuppliers_KeyDown);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No#";
            this.colNo.MinimumWidth = 38;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 38;
            // 
            // colSupplierId
            // 
            this.colSupplierId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSupplierId.HeaderText = "Supplier ID";
            this.colSupplierId.MinimumWidth = 6;
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.ReadOnly = true;
            this.colSupplierId.Visible = false;
            // 
            // colSupplierName
            // 
            this.colSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSupplierName.HeaderText = "Supplier Name";
            this.colSupplierName.MinimumWidth = 100;
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Phone Number";
            this.colTel.MinimumWidth = 200;
            this.colTel.Name = "colTel";
            this.colTel.ReadOnly = true;
            this.colTel.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 200;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 200;
            // 
            // colCreateBy
            // 
            this.colCreateBy.HeaderText = "Created By";
            this.colCreateBy.MinimumWidth = 120;
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.ReadOnly = true;
            this.colCreateBy.Width = 120;
            // 
            // colCreateAt
            // 
            this.colCreateAt.HeaderText = "Created At";
            this.colCreateAt.MinimumWidth = 100;
            this.colCreateAt.Name = "colCreateAt";
            this.colCreateAt.ReadOnly = true;
            // 
            // colUpdateAt
            // 
            this.colUpdateAt.HeaderText = "Update At";
            this.colUpdateAt.Name = "colUpdateAt";
            this.colUpdateAt.ReadOnly = true;
            this.colUpdateAt.Visible = false;
            // 
            // colUpdateBy
            // 
            this.colUpdateBy.HeaderText = "Update By";
            this.colUpdateBy.Name = "colUpdateBy";
            this.colUpdateBy.ReadOnly = true;
            this.colUpdateBy.Visible = false;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = global::Midterm_POS_SU4.Properties.Resources.edit_golden_24px;
            this.colEdit.MinimumWidth = 24;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEdit.Width = 24;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = global::Midterm_POS_SU4.Properties.Resources.delete_red_24px_2;
            this.colDelete.MinimumWidth = 24;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.Width = 24;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 16);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(71, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(902, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = global::Midterm_POS_SU4.Properties.Resources.add_green_512px;
            this.btnAddSupplier.Location = new System.Drawing.Point(979, 12);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(37, 37);
            this.btnAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddSupplier.TabIndex = 9;
            this.btnAddSupplier.TabStop = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lblLatestUpdate
            // 
            this.lblLatestUpdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestUpdate.ForeColor = System.Drawing.Color.Gray;
            this.lblLatestUpdate.Location = new System.Drawing.Point(9, 475);
            this.lblLatestUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.lblLatestUpdate.Name = "lblLatestUpdate";
            this.lblLatestUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLatestUpdate.Size = new System.Drawing.Size(554, 16);
            this.lblLatestUpdate.TabIndex = 10;
            this.lblLatestUpdate.Text = "Latest update";
            this.lblLatestUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLatestUpdate.Visible = false;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalRows.Location = new System.Drawing.Point(563, 475);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalRows.Size = new System.Drawing.Size(453, 16);
            this.lblTotalRows.TabIndex = 11;
            this.lblTotalRows.Text = "Total: ";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SupplierForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 500);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.lblLatestUpdate);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSuppliers);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnAddSupplier;
        private System.Windows.Forms.Label lblLatestUpdate;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateBy;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}