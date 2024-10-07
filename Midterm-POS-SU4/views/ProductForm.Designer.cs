namespace Midterm_POS_SU4.views
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPhotoUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsAddStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLatestUpdate = new System.Windows.Forms.Label();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsAddStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(71, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(902, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 16);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProductId,
            this.colPhoto,
            this.colProduct,
            this.colBarcode,
            this.colSellPrice,
            this.colQtyInStock,
            this.colCategory,
            this.colCreateBy,
            this.colCreateAt,
            this.colUpdateAt,
            this.colUpdateBy,
            this.colEdit,
            this.colDelete,
            this.colPhotoUrl});
            this.dgvProducts.ContextMenuStrip = this.cmsAddStock;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvProducts.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvProducts.Location = new System.Drawing.Point(12, 55);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.ShowCellToolTips = false;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(1004, 417);
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            this.dgvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProducts_KeyDown);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No#";
            this.colNo.MinimumWidth = 38;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 38;
            // 
            // colProductId
            // 
            this.colProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colPhoto
            // 
            this.colPhoto.HeaderText = "";
            this.colPhoto.Image = global::Midterm_POS_SU4.Properties.Resources.landscape_image_gray_512px1;
            this.colPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPhoto.MinimumWidth = 24;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.ReadOnly = true;
            this.colPhoto.Width = 24;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "Product";
            this.colProduct.MinimumWidth = 100;
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "Barcode";
            this.colBarcode.MinimumWidth = 100;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            // 
            // colSellPrice
            // 
            this.colSellPrice.HeaderText = "Sell Price";
            this.colSellPrice.MinimumWidth = 100;
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.ReadOnly = true;
            // 
            // colQtyInStock
            // 
            this.colQtyInStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQtyInStock.HeaderText = "Qty In Stock";
            this.colQtyInStock.MinimumWidth = 79;
            this.colQtyInStock.Name = "colQtyInStock";
            this.colQtyInStock.ReadOnly = true;
            this.colQtyInStock.Width = 106;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 150;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 150;
            // 
            // colCreateBy
            // 
            this.colCreateBy.HeaderText = "Created By";
            this.colCreateBy.Name = "colCreateBy";
            this.colCreateBy.ReadOnly = true;
            this.colCreateBy.Width = 120;
            // 
            // colCreateAt
            // 
            this.colCreateAt.HeaderText = "Created At";
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
            // colPhotoUrl
            // 
            this.colPhotoUrl.HeaderText = "Photo Url";
            this.colPhotoUrl.Name = "colPhotoUrl";
            this.colPhotoUrl.ReadOnly = true;
            this.colPhotoUrl.Visible = false;
            // 
            // cmsAddStock
            // 
            this.cmsAddStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem});
            this.cmsAddStock.Name = "cmsAddStock";
            this.cmsAddStock.Size = new System.Drawing.Size(171, 26);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
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
            this.lblLatestUpdate.TabIndex = 12;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Midterm_POS_SU4.Properties.Resources.edit_black_24px;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Midterm_POS_SU4.Properties.Resources.trash_bin_black_24px;
            this.dataGridViewImageColumn2.MinimumWidth = 24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Midterm_POS_SU4.Properties.Resources.delete_red_24px_2;
            this.dataGridViewImageColumn3.MinimumWidth = 24;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = global::Midterm_POS_SU4.Properties.Resources.add_green_512px;
            this.btnAddProduct.Location = new System.Drawing.Point(979, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(37, 37);
            this.btnAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 500);
            this.Controls.Add(this.lblLatestUpdate);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsAddStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnAddProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblLatestUpdate;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewImageColumn colPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateBy;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhotoUrl;
        private System.Windows.Forms.ContextMenuStrip cmsAddStock;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
    }
}