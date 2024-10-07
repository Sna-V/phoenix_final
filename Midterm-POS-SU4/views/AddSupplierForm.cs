using DataAccessLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_POS_SU4.views
{
    public partial class AddSupplierForm : Form
    {
        public int _supplierId = 0;
        public string _oldSupplierName;
        public string _oldTel;
        public string _oldAddress;
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddSupplierForm()
        {
            InitializeComponent();
        }
        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            _oldSupplierName = txtSupplierName.Text;
            _oldTel = txtPhoneNumber.Text;
            _oldAddress = txtAddress.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validating values and initializing relevant variables
            if (txtSupplierName.Text == "")
            {
                txtSupplierName.Focus();
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
            string supplierName = txtSupplierName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            int createBy = Program.UserId;
            int updateBy = Program.UserId;
            #endregion
            try
            {
                if (_supplierId == 0)
                {
                    if (CheckIfSupplierExist(_operation, txtSupplierName.Text) == true)
                    {
                        MessageBox.Show($"Supplier : \"{txtSupplierName.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Focus();
                        return;
                    }
                    if (CheckIfPhoneNumberExists(_operation, txtPhoneNumber.Text) == true)
                    {
                        MessageBox.Show($"Tel : \"{txtPhoneNumber.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }
                    if (InsertSupplier(_operation, supplierName, phoneNumber, address, createBy) == true)
                    {
                        MessageBox.Show($"Supplier : \"{txtSupplierName.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (CheckIfSupplierExist(_operation, txtSupplierName.Text) == true && _oldSupplierName != txtSupplierName.Text)
                    {
                        MessageBox.Show($"Supplier : \"{txtSupplierName.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSupplierName.Focus();
                        return;
                    }
                    if (CheckIfPhoneNumberExists(_operation, txtPhoneNumber.Text) == true && _oldTel != txtPhoneNumber.Text)
                    {
                        MessageBox.Show($"Tel : \"{txtPhoneNumber.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhoneNumber.Focus();
                        return;
                    }
                    if (UpdateSupplier(_operation, _supplierId, supplierName, phoneNumber, address, updateBy) == true)
                    {
                        if (_oldSupplierName == txtSupplierName.Text && _oldTel == txtPhoneNumber.Text && _oldAddress == txtAddress.Text)
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
        private bool InsertSupplier(QueryOperations operation, string supplierName, string phoneNumber, string address, int createBy)
        {
            return operation.InsertSupplier(supplierName, phoneNumber, address, createBy);
        }
        private bool UpdateSupplier(QueryOperations operation, int supplierId, string supplierName, string phoneNumber, string address, int updateBy)
        {
            return operation.UpdateSupplier(supplierId, supplierName, phoneNumber, address, updateBy);
        }
        #endregion
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            txtSupplierName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtSupplierName.Focus();
        }
        private bool CheckIfSupplierExist(QueryOperations operation, string supplierName)
        {
            if (operation.CheckIfSupplierExists(supplierName) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckIfPhoneNumberExists(QueryOperations operation, string phoneNumber)
        {
           if (operation.CheckIfSupplierPhoneNumberExists(phoneNumber) == true)
           {
                return true;
           }
            else
            {
                return false;
            }
        }
        public void TransferDataGridView(DataGridView dgvSupplier)
        {
            var selectedRow = dgvSupplier.SelectedRows[0];
            _supplierId = Convert.ToInt32(selectedRow.Cells["colSupplierId"].Value.ToString());
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
        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
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
