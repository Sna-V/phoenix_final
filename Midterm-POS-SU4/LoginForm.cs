using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace Midterm_POS_SU4
{
    public partial class LoginForm : Form
    {
        QueryOperations operation = new QueryOperations(Program.GetConnectionString());
        public LoginForm()
        {
            InitializeComponent();
        }
        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
        }
        private bool IsUserEnabled()
        {
            var user = operation.IsUserEnabled(txtUsernameOrEmail.Text, txtPassword.Text);
            if (user.Status == "True")
            {
                Program.UserId = user.UserId;
                Program.UserName = user.UserName;
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsernameOrEmail.Text == "")
            {
                txtUsernameOrEmail.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }
            if (operation.IsValidUserInfo(txtUsernameOrEmail.Text, txtPassword.Text) == false)
            {
                MessageBox.Show("Username, Email or Password are not matched!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (IsUserEnabled() == false)
                {
                    MessageBox.Show("This user is disabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainForm mainForm = new MainForm();
                if (operation.IsAdmin(txtUsernameOrEmail.Text, txtPassword.Text) == true)
                {
                    mainForm.btnUsers.Enabled = true;
                    mainForm.btnUsers.Visible = true;
                    mainForm.btnRoles.Enabled = true;
                    mainForm.btnRoles.Visible = true;
                }
                else
                {
                    mainForm.btnUsers.Enabled = false;
                    mainForm.btnUsers.Visible = false;
                    mainForm.btnRoles.Enabled = false;
                    mainForm.btnRoles.Visible = false;
                }
                this.Hide();
                mainForm.Show();
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void lblClear_Click_1(object sender, EventArgs e)
        {
            txtUsernameOrEmail.Clear();
            txtPassword.Clear();
            txtUsernameOrEmail.Focus();
        }
        private void txtUsernameOrEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterKey(sender, e);
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterKey(sender, e);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
