namespace Midterm_POS_SU4.views
{
    partial class RoleForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.PictureBox();
            this.lblLatestUpdate = new System.Windows.Forms.Label();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(71, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(902, 23);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 16);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = global::Midterm_POS_SU4.Properties.Resources.add_green_512px;
            this.btnAddCategory.Location = new System.Drawing.Point(979, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(37, 37);
            this.btnAddCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCategory.TabIndex = 19;
            this.btnAddCategory.TabStop = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddRole_Click);
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
            this.lblLatestUpdate.TabIndex = 20;
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
            this.lblTotalRows.TabIndex = 21;
            this.lblTotalRows.Text = "Total: ";
            this.lblTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeColumns = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colRoleId,
            this.colRole,
            this.colStatus,
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
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoles.EnableHeadersVisualStyles = false;
            this.dgvRoles.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvRoles.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvRoles.Location = new System.Drawing.Point(12, 55);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.ShowCellErrors = false;
            this.dgvRoles.ShowCellToolTips = false;
            this.dgvRoles.ShowEditingIcon = false;
            this.dgvRoles.ShowRowErrors = false;
            this.dgvRoles.Size = new System.Drawing.Size(1004, 417);
            this.dgvRoles.TabIndex = 22;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            this.dgvRoles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRoles_CellFormatting);
            this.dgvRoles.SelectionChanged += new System.EventHandler(this.dgvRoles_SelectionChanged);
            this.dgvRoles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRoles_KeyDown);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No#";
            this.colNo.MinimumWidth = 38;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 38;
            // 
            // colRoleId
            // 
            this.colRoleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRoleId.HeaderText = "Role ID";
            this.colRoleId.MinimumWidth = 6;
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.ReadOnly = true;
            this.colRoleId.Visible = false;
            // 
            // colRole
            // 
            this.colRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 100;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 61;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 70;
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
            // RoleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 500);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.lblLatestUpdate);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox btnAddCategory;
        private System.Windows.Forms.Label lblLatestUpdate;
        private System.Windows.Forms.Label lblTotalRows;
        public System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateBy;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}