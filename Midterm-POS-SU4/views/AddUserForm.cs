using DataAccessLibrary;
using System;
using System.Windows.Forms;

namespace Midterm_POS_SU4.views
{
    public partial class AddUserForm : Form
    {
        private int _userId = 0;
        private string _oldUserName;
        private string _oldPassword;
        private string _oldEmail;
        private string _oldGenter;
        private string _oldRoleName;
        private bool _oldStatus;
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddUserForm()
        {
            InitializeComponent();
            txtUserName.Focus();
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            DisplayRoleData(_operation, cboRoleName);
            _oldUserName = txtUserName.Text;
            _oldPassword = txtPassword.Text;
            _oldEmail = txtEmail.Text;
            _oldGenter = cboGender.Text;
            _oldRoleName = cboRoleName.Text;
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
            if (txtUserName.Text == "")
            {
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                return;
            }
            if (cboGender.Text == "")
            {
                cboGender.Focus();
                return;
            }
            if (cboRoleName.Text == "")
            {
                cboRoleName.Focus();
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string gender = cboGender.Text;
            string role = cboRoleName.Text;
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
                if (_userId == 0)
                {
                    if (CheckIfUserNameExists(_operation,txtUserName.Text) == true)
                    {
                        MessageBox.Show($"Username : \"{txtUserName.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                        return;
                    }
                    if(InsertUser(_operation, userName, password, email, gender, role, status, createBy) == true)
                    {
                        MessageBox.Show($"User : \"{txtUserName.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (CheckIfUserNameExists(_operation, txtUserName.Text) == true && _oldUserName != txtUserName.Text)
                    {
                        MessageBox.Show($"Username : \"{txtUserName.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                        return;
                    }
                    if (
                        _oldUserName == txtUserName.Text &&
                        _oldPassword == txtPassword.Text &&
                        _oldEmail == txtEmail.Text &&
                        _oldGenter == cboGender.Text &&
                        _oldRoleName == cboRoleName.Text &&
                        _oldStatus == rTrue.Checked
                        )
                    {
                        return;
                    }
                    else
                    {
                        if (UpdateUser(_operation, _userId, userName, password, email, gender, role, status, updateBy) == true)
                        {
                            if (_oldStatus == false && rTrue.Checked == true)
                            {
                                MessageBox.Show($"User : \"{txtUserName.Text}\" is now enabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (_oldStatus == true && rTrue.Checked == false)
                            {
                                MessageBox.Show($"User : \"{txtUserName.Text}\" is now disabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshUI();
        }
        #region -------------------------------------------------- Sql Operations --------------------------------------------------
        private bool InsertUser(QueryOperations operation, string userName, string password, string email, string gender, string role, int status, int createBy)
        {
            return operation.InsertUser(userName, password, email, gender, role, status, createBy);
        }
        private bool UpdateUser(QueryOperations operation, int userId, string userName, string password, string email, string gender, string role, int status, int updateBy)
        {
            return operation.UpdateUser(userId, userName, password, email, gender, role, status, updateBy);
        }
        #endregion
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void DisplayRoleData(QueryOperations operation, ComboBox cboRoleName)
        {
            var roles = operation.FetchRoleData();
            foreach (var role in roles)
            {
                cboRoleName.Items.Add(role.Role);
            }
        }
        public void TransferDataGridView(DataGridView dgvUsers)
        {
            var row = dgvUsers.SelectedRows[0];
            _userId = Convert.ToInt32(row.Cells[1].Value.ToString());
        }
        private bool CheckIfUserNameExists(QueryOperations operation, string userName)
        {
            if (operation.CheckIfUserNameExists(userName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RefreshUI()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cboGender.Text = "";
            cboRoleName.Text = "";
            rTrue.Checked = true;
            txtUserName.Focus();
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
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void cboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void cboRoleName_KeyPress(object sender, KeyPressEventArgs e)
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
