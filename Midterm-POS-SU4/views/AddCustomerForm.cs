using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using DataAccessLibrary;

namespace Midterm_POS_SU4.views
{
    public partial class AddCustomerForm : Form
    {
        public int _customerId = 0;      

        public string _oldCustomerName;
        public string _oldGender;
        public string _oldPhoneNumber;
        public string _oldAddress;
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            _oldCustomerName = txtCustomerName.Text;
            _oldGender = cboGender.Text;
            _oldPhoneNumber = txtPhoneNumber.Text;
            _oldAddress = txtAddress.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validating values and initializing relevant variables
            if (txtCustomerName.Text == "")
            {
                txtCustomerName.Focus();
                return;
            }
            if (cboGender.Text == "")
            {
                cboGender.Focus();
                return;
            }
            int phoneNumberLength = txtPhoneNumber.Text.Replace(" ", "").Length;
            if (txtPhoneNumber.Text == "" || phoneNumberLength < 9 || phoneNumberLength > 10)
            {
                txtPhoneNumber.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                return;
            }
            string customerName = txtCustomerName.Text;
            string gender = cboGender.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            int createBy = Program.UserId;
            int updateBy = Program.UserId;
            #endregion
            try
            {
                if (_customerId == 0)
                {
                    if (CheckIfCustomerPhoneNumberExists(_operation, phoneNumber) == true)
                    {
                        MessageBox.Show($"Tel : \"{txtPhoneNumber.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }
                    if (InsertCustomer(_operation, customerName, gender, phoneNumber, address, createBy) == true)
                    {
                        MessageBox.Show($"Customer : \"{txtCustomerName.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (CheckIfCustomerPhoneNumberExists(_operation, phoneNumber) == true && _oldPhoneNumber != txtPhoneNumber.Text)
                    {
                        MessageBox.Show($"Tel : \"{txtPhoneNumber.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }
                    if (UpdateCustomer(_operation, _customerId, customerName, gender, phoneNumber, address, updateBy) == true)
                    {
                        if (_oldCustomerName == txtCustomerName.Text && _oldGender == cboGender.Text && _oldPhoneNumber == txtPhoneNumber.Text && _oldAddress == txtAddress.Text)
                        {
                            return;
                        }
                        this.Close();
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
        private bool InsertCustomer(QueryOperations operation, string customerName, string gender, string phoneNumber, string address, int createBy)
        {
            return operation.InsertCustomer(customerName, gender, phoneNumber, address, createBy);
        }
        private bool UpdateCustomer(QueryOperations operation, int customerId, string customerName, string gender, string phoneNumber, string address, int updateBy)
        {
            return operation.UpdateCustomer(customerId, customerName, gender, phoneNumber, address, updateBy);
        }
        #endregion
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            txtCustomerName.Clear();
            cboGender.SelectedIndex = -1;
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtCustomerName.Focus();
        }
        private bool CheckIfCustomerPhoneNumberExists(QueryOperations operation, string phoneNumber)
        {
            if (operation.CheckIfCustomerPhoneNumberExists(phoneNumber) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TransferDataGridView(DataGridView dgvCustomers)
        {
            var selectedRow = dgvCustomers.SelectedRows[0];
            _customerId = Convert.ToInt32(selectedRow.Cells["colCustomerId"].Value.ToString());
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
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void cboGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            EnterKey(sender, e);
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        #endregion
        #endregion
    }
}
