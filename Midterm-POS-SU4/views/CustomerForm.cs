using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Midterm_POS_SU4.views
{
    public partial class CustomerForm : Form
    {
        QueryOperations _operation = new QueryOperations(Main.GetConnectionString());
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {            
            int selectedRowIndex = dgvCustomers.SelectedRows[0].Index;
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            RefreshUI();
            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void UpdateCustomer()
        {
            DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];
            int selectedRowIndex = selectedRow.Index;
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.TransferDataGridView(dgvCustomers);
            addCustomerForm.txtCustomerName.Text = selectedRow.Cells[2].Value.ToString();
            addCustomerForm.cboGender.Text = selectedRow.Cells[3].Value.ToString();
            addCustomerForm.txtPhoneNumber.Text = selectedRow.Cells[4].Value.ToString();
            addCustomerForm.txtAddress.Text = selectedRow.Cells[5].Value.ToString();
            addCustomerForm.lblAddCustomer.Text = "Update Customer";
            addCustomerForm.btnAdd.Text = "Update";
            addCustomerForm.ShowDialog();
            RefreshUI();
            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[selectedRowIndex].Selected = true;
        }
        private void DeleteCustomer(QueryOperations operation)
        {
            int selectedRowIndex = dgvCustomers.SelectedRows[0].Index;
            int lastRowIndex = dgvCustomers.Rows.Count - 1;
            var selectedRow = dgvCustomers.SelectedRows[0];
            int customerId = Convert.ToInt32(selectedRow.Cells["colCustomerId"].Value.ToString());
            string customerName = selectedRow.Cells["colCustomerName"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete customer : \"{customerName}\"?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteCustomer(customerId);
                RefreshUI();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvCustomers.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvCustomers.Rows[lastRowIndex].Selected = true;
                }
            }
        }
        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCustomers.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateCustomer();
                }
                if (dgvCustomers.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteCustomer(_operation);
                }
            }
        }
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                UpdateCustomer();
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadCustomerData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        private void LoadCustomerData(QueryOperations operation, string searchTerm)
        {
            var customers = operation.FetchCustomerData(searchTerm);
            if (customers == null || dgvCustomers == null)
            {
                return;
            }
            dgvCustomers.Rows.Clear();
            int rowNumber = 0;
            foreach (var customer in customers)
            {
                rowNumber++;
                int rowIndex = dgvCustomers.Rows.Add();
                var row = dgvCustomers.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = customer.CustomerId;
                row.Cells[2].Value = customer.CustomerName;
                row.Cells[3].Value = customer.Gender;
                row.Cells[4].Value = customer.PhoneNumber;
                row.Cells[5].Value = customer.Address;
                row.Cells[6].Value = customer.CreateBy;
                row.Cells[7].Value = Customize.GetDateWithSuffix(customer.CreateAt);
                row.Cells[8].Value = customer.UpdateAt;
                row.Cells[9].Value = customer.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
        }
        private void HandleRowSelection()
        {
            if (dgvCustomers.SelectedRows.Count > 0 && dgvCustomers.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var row = dgvCustomers.SelectedRows[0];
            if (row.Cells[9].Value != null && row.Cells[8].Value != null && dgvCustomers != null) // Cells[8] = Cell["colUpdateAt"], Cells[9] = Cells["colUpdateBy"]
            {
                if (DateTime.TryParse(row.Cells[8].Value.ToString(), out DateTime updateAt))
                {
                    string updateBy = row.Cells[9].Value.ToString();
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
        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddCustomer_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateCustomer();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteCustomer(_operation);
            }
        }
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        #endregion
        #endregion
    }
}
