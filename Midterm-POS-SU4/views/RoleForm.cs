using System;
using System.Windows.Forms;
using DataAccessLibrary;

namespace Midterm_POS_SU4.views
{
    public partial class RoleForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public RoleForm()
        {
            InitializeComponent();
            RefreshUI();
        }
        private void RoleForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvRoles.SelectedRows[0].Index;
            AddRoleForm addRoleForm = new AddRoleForm();
            addRoleForm.ShowDialog();
            RefreshUI();
            dgvRoles.ClearSelection();
            dgvRoles.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                if (dgvRoles.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateRole();
                }
                if (dgvRoles.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteRole(_operation);
                }
            }
        }
        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                int selectedRowIndex = dgvRoles.SelectedRows[0].Index;
                UpdateRole();
                dgvRoles.ClearSelection();
                dgvRoles.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void UpdateRole()
        {
            if (dgvRoles.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRoles.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                AddRoleForm addRoleForm = new AddRoleForm();
                addRoleForm.TransferDataGridView(dgvRoles);
                addRoleForm.txtRole.Text = selectedRow.Cells["colRole"].Value.ToString();
                string status = selectedRow.Cells["colStatus"].Value.ToString();
                if (status == "True")
                {
                    addRoleForm.rTrue.Checked = true;
                }
                else
                {
                    addRoleForm.rFalse.Checked = true;
                }
                addRoleForm.lblAddRole.Text = "Update Role";
                addRoleForm.btnAdd.Text = "Update";
                addRoleForm.ShowDialog();
                RefreshUI();
                dgvRoles.ClearSelection();
                dgvRoles.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void DeleteRole(QueryOperations operation)
        {
            int selectedRowIndex = dgvRoles.SelectedRows[0].Index;
            int lastRowIndex = dgvRoles.Rows.Count - 1;
            var row = dgvRoles.SelectedRows[0];
            int roleId = Convert.ToInt32(row.Cells["colRoleId"].Value.ToString());
            string role = row.Cells["colRole"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete role : \"{role}\"?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteRole(roleId);
                RefreshUI();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvRoles.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvRoles.Rows[lastRowIndex].Selected = true;
                }
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadRoleData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        private void LoadRoleData(QueryOperations operation, string searchTerm)
        {
            var roles = operation.FetchRoleData(searchTerm);
            if (roles == null || dgvRoles == null)
            {
                return;
            }
            dgvRoles.Rows.Clear();
            int rowNumber = 0;
            foreach (var role in roles)
            {
                rowNumber++;
                int rowIndex = dgvRoles.Rows.Add();
                var row = dgvRoles.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = role.RoleId;
                row.Cells[2].Value = role.Role;
                row.Cells[3].Value = role.Status;
                row.Cells[4].Value = role.CreateBy;
                row.Cells[5].Value = Customize.GetDateWithSuffix(role.CreateAt);
                row.Cells[6].Value = role.UpdateAt;
                row.Cells[7].Value = role.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
            InvisibleUpdateLabel();
        }
        private void HandleRowSelection()
        {
            if (dgvRoles.SelectedRows.Count > 0 && dgvRoles.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var selectedRow = dgvRoles.SelectedRows[0];
            if (selectedRow.Cells[7].Value != null && selectedRow.Cells[6].Value != null && dgvRoles != null) // Cells[7] = Cell["colUpdateAt"], Cells[8] = Cells["colUpdateBy"]
            {
                if (DateTime.TryParse(selectedRow.Cells[6].Value.ToString(), out DateTime updateAt))
                {
                    string updateBy = selectedRow.Cells[7].Value.ToString();
                    string latestUpdate = $"Latest update on {Customize.GetDateWithSuffix(updateAt)} by {updateBy}";
                    if (lblLatestUpdate.Text != latestUpdate || lblLatestUpdate.Visible == false)
                    {
                        lblLatestUpdate.Visible = true;
                        lblLatestUpdate.Text = latestUpdate;
                    }
                }
                else
                {
                    if (lblLatestUpdate.Visible == true)
                    {
                        lblLatestUpdate.Visible = false;
                    }
                }
            }
            else
            {
                if (lblLatestUpdate.Visible == true)
                {
                    lblLatestUpdate.Visible = false;
                }
            }
        }
        private void InvisibleUpdateLabel()
        {
            if (lblTotalRows.Text == "Total: 0 row")
            {
                lblLatestUpdate.Visible = false;
            }
        }
        #endregion
        #region Events
        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        private void dgvRoles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "colStatus" column
            if (dgvRoles.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                if (e.Value.ToString() == "False")
                {
                    if (dgvRoles.Rows[e.RowIndex].Selected) // Row is selected
                    {
                        e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(178, 34, 34);
                    }
                    else // Row is not selected
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34);
                    }
                }
            }
        }
        private void dgvRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddRole_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateRole();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteRole(_operation);
            }
        }
        #endregion

        #endregion
    }
}