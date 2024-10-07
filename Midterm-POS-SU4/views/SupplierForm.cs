using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLibrary;

namespace Midterm_POS_SU4.views
{
    public partial class SupplierForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public SupplierForm()
        {
            InitializeComponent();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSuppliers.SelectedRows[0].Index;
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
            RefreshUI();
            dgvSuppliers.ClearSelection();
            dgvSuppliers.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void UpdateSupplier()
        {
            if (dgvSuppliers.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSuppliers.SelectedRows[0];
                int selectedRowIndex = dgvSuppliers.SelectedRows[0].Index;
                AddSupplierForm addSupplierForm = new AddSupplierForm();
                addSupplierForm.TransferDataGridView(dgvSuppliers);
                addSupplierForm.txtSupplierName.Text = selectedRow.Cells[2].Value.ToString();
                addSupplierForm.txtPhoneNumber.Text = selectedRow.Cells[3].Value.ToString();
                addSupplierForm.txtAddress.Text = selectedRow.Cells[4].Value.ToString();
                addSupplierForm.lblAddSupplier.Text = "Update Supplier";
                addSupplierForm.btnAdd.Text = "Update";
                addSupplierForm.ShowDialog();
                RefreshUI();
                dgvSuppliers.ClearSelection();
                dgvSuppliers.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void DeleteSupplier(QueryOperations operation)
        {
            int selectedRowIndex = dgvSuppliers.SelectedRows[0].Index;
            int lastRowIndex = dgvSuppliers.Rows.Count - 1;
            var selectedRow = dgvSuppliers.SelectedRows[0];
            int supplierId = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
            string supplierName = selectedRow.Cells[2].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete supplier : \"{supplierName}\"?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteSupplier(supplierId);
                RefreshUI();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvSuppliers.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvSuppliers.Rows[lastRowIndex].Selected = true;
                }
            }
        }
        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvSuppliers.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateSupplier();
                }
                if (dgvSuppliers.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteSupplier(_operation);
                }
            }
        }
        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateSupplier();
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadSupplierData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        private void LoadSupplierData(QueryOperations operation, string searchterm)
        {
            var suppliers = operation.FetchSupplierData(searchterm);
            if (suppliers == null || dgvSuppliers == null)
            {
                return;
            }
            dgvSuppliers.Rows.Clear();
            int rowNumber = 0;
            foreach (var supplier in suppliers)
            {
                rowNumber++;
                int rowIndex = dgvSuppliers.Rows.Add();
                var row = dgvSuppliers.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = supplier.SupplierId;
                row.Cells[2].Value = supplier.SupplierName;
                row.Cells[3].Value = supplier.PhoneNumber;
                row.Cells[4].Value = supplier.Address;
                row.Cells[5].Value = supplier.CreateBy;
                row.Cells[6].Value = Customize.GetDateWithSuffix(supplier.CreateAt);
                row.Cells[7].Value = supplier.UpdateAt;
                row.Cells[8].Value = supplier.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
        }
        private void HandleRowSelection()
        {
            if (dgvSuppliers.SelectedRows.Count > 0 && dgvSuppliers.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var row = dgvSuppliers.SelectedRows[0];
            if (row.Cells[8].Value != null && row.Cells[7].Value != null && dgvSuppliers != null) // Cells[7] = Cell["colUpdateAt"], Cells[8] = Cells["colUpdateBy"]
            {
                if (DateTime.TryParse(row.Cells[7].Value.ToString(), out DateTime updateAt))
                {
                    string updateBy = row.Cells[8].Value.ToString();
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
        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        private void dgvSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddSupplier_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateSupplier();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteSupplier(_operation);
            }
        }
        #endregion
        #endregion

    }
}
