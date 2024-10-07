using System;
using System.Windows.Forms;
using DataAccessLibrary;
using System.Drawing;

namespace Midterm_POS_SU4.views
{
    public partial class UserForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public UserForm()
        {
            InitializeComponent();
            RefreshUI();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            RefreshUI();
            dgvUsers.ClearSelection();
            dgvUsers.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                if (dgvUsers.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateUser();
                }
                if (dgvUsers.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteUser(_operation);
                }
            }
        }
        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateUser();
            }
        }
        private void UpdateUser()
        {
            if (dgvUsers.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                AddUserForm addUserForm = new AddUserForm();
                addUserForm.TransferDataGridView(dgvUsers);
                addUserForm.txtUserName.Text = selectedRow.Cells[2].Value.ToString();
                addUserForm.txtPassword.Text = selectedRow.Cells[3].Value.ToString();
                addUserForm.txtEmail.Text = selectedRow.Cells[4].Value.ToString();
                addUserForm.cboGender.Text = selectedRow.Cells[5].Value.ToString();
                addUserForm.cboRoleName.Text = selectedRow.Cells[6].Value.ToString();
                string status = selectedRow.Cells[7].Value.ToString();
                if (status == "True")
                {
                    addUserForm.rTrue.Checked = true;
                }
                else
                {
                    addUserForm.rFalse.Checked = true;
                }
                addUserForm.lblAddUser.Text = "Update User";
                addUserForm.btnAdd.Text = "Update";
                addUserForm.ShowDialog();
                RefreshUI();
                dgvUsers.ClearSelection();
                dgvUsers.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void DeleteUser(QueryOperations operation)
        {
            int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
            int lastRowIndex = dgvUsers.Rows.Count - 1;
            var row = dgvUsers.SelectedRows[0];
            int userId = Convert.ToInt32(row.Cells[1].Value.ToString()); // Cell[1] = Cell["colUserId"]
            string userName = row.Cells[2].Value.ToString(); // Cell[2] = Cell["colUserName"]
            if (MessageBox.Show($"Are you sure you want to delete user : \"{userName}\"?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteUser(userId);
                RefreshUI();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvUsers.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvUsers.Rows[lastRowIndex].Selected = true;
                }
                if (userId == Program.UserId)
                {
                    MainForm.Instance.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                }
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadUserData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        private void LoadUserData(QueryOperations operation, string searchTerm)
        {
            var users = operation.FetchUserData(searchTerm);
            if (users == null || dgvUsers == null)
            {
                return;
            }
            dgvUsers.Rows.Clear();
            int rowNumber = 0;
            foreach (var user in users)
            {
                rowNumber++;
                int rowIndex = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = user.UserId;
                row.Cells[2].Value = user.UserName;
                row.Cells[3].Value = user.Password;
                row.Cells[4].Value = user.Email;
                row.Cells[5].Value = user.Gender;
                row.Cells[6].Value = user.Role;
                row.Cells[7].Value = user.Status;
                row.Cells[8].Value = user.CreateBy;
                row.Cells[9].Value = Customize.GetDateWithSuffix(user.CreateAt);
                row.Cells[10].Value = user.UpdateAt;
                row.Cells[11].Value = user.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
        }
        private void HandleRowSelection()
        {
            if (dgvUsers.SelectedRows.Count > 0 && dgvUsers.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var row = dgvUsers.SelectedRows[0];
            if (row.Cells["colUpdateBy"].Value != null && row.Cells["colUpdateAt"].Value != null)
            {
                if (DateTime.TryParse(row.Cells["colUpdateAt"].Value.ToString(), out DateTime updateAt))
                {
                    string updateBy = row.Cells["colUpdateBy"].Value.ToString();
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
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        private void dgvUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddUser_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateUser();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteUser(_operation);
                RefreshUI();
            }
        }
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "colRole" column
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colRole" && e.Value != null)
            {
                if (e.Value.ToString() == "admin")
                {
                    if (dgvUsers.Rows[e.RowIndex].Selected) // Row is selected
                    {
                        e.CellStyle.SelectionForeColor = Color.FromArgb(9, 121, 105);

                    }
                    else // Row is not selected
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(9, 121, 105);
                    }
                }
            }

            // Check if the current cell belongs to the "colStatus" column
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                if (e.Value.ToString() == "False")
                {
                    if (dgvUsers.Rows[e.RowIndex].Selected) // Row is selected
                    {
                        e.CellStyle.SelectionForeColor = Color.FromArgb(178, 34, 34);
                    }
                    else // Row is not selected
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(178, 34, 34);
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}