using DataAccessLibrary;
using System;
using System.Windows.Forms;

namespace Midterm_POS_SU4.views
{
    public partial class AddRoleForm : Form
    {
        public int _roleId = 0;
        public string _oldRole;
        public bool _oldStatus;
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddRoleForm()
        {
            InitializeComponent();
        }
        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            _oldRole = txtRole.Text;
            if (rTrue.Checked)
            {
                _oldStatus = true;
            }
            else if (rFalse.Checked)
            {
                _oldStatus = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validating values and initializing relevant variables
            if (txtRole.Text == "")
            {
                txtRole.Focus();
                return;
            }
            string role = txtRole.Text;
            int status = 0;
            if (rTrue.Checked == true)
            {
                status = 1;
            }
            int createBy = Program.UserId;
            int updateBy = Program.UserId;
            #endregion
            try
            {
                if (_roleId == 0) // If _roleId = 0 means we're inserting a new role :)
                {
                    if (CheckIfRoleExists(_operation, role) == true)
                    {
                        MessageBox.Show($"Role : \"{txtRole.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRole.Focus();
                        return;
                    }
                    if(InsertRole(_operation, role, status, createBy) == true)
                    {
                        MessageBox.Show($"Role : \"{txtRole.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // Otherwise means we're updating an existing role (:
                {
                    if (CheckIfRoleExists(_operation, role) == true && txtRole.Text != _oldRole)
                    {
                        MessageBox.Show($"Role : \"{txtRole.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRole.Focus();
                        return;
                    }
                    if (_oldRole == txtRole.Text && _oldStatus == rTrue.Checked)
                    {
                        return;
                    }
                    else
                    {
                        if (UpdateRole(_operation, _roleId, role, status, updateBy) == true)
                        {
                            if (_oldStatus == false && rTrue.Checked == true)
                            {
                                MessageBox.Show($"Role : \"{txtRole.Text}\" is now enabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Role : \"{txtRole.Text}\" is now disabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }
                    }           
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshUI();
        }
        #region -------------------------------------------------- Sql Operations --------------------------------------------------
        private bool InsertRole(QueryOperations operation, string role, int status, int createBy)
        {
            return operation.InsertRole(role, status, createBy);
        }
        private bool UpdateRole(QueryOperations operation, int userId, string role, int status, int updateBy)
        {
            return operation.UpdateRole(userId, role, status, updateBy);
        }
        #endregion
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            txtRole.Clear();
            rTrue.Checked = true;
            txtRole.Focus();
        }
        private bool CheckIfRoleExists(QueryOperations operation, string role)
        {
            if (operation.CheckIfRoleExists(role) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TransferDataGridView(DataGridView dgv)
        {
            var row = dgv.SelectedRows[0];
            _roleId = Convert.ToInt32(row.Cells["colRoleId"].Value.ToString());
        }
        #endregion
        #region Events
        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAdd_Click(sender, e);
            }
        }
        private void txtRoleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void rTrue_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void rFalse_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        #endregion
        #endregion
    }
}
