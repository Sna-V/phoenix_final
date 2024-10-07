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
    public partial class ProductForm : Form
    {
        QueryOperations _operation = new QueryOperations(Main.GetConnectionString());
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvProducts.SelectedRows[0].Index;
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            RefreshUI();
            dgvProducts.ClearSelection();
            dgvProducts.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void AddStock()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                AddStockForm addStockForm = new AddStockForm();
                if (selectedRow.Cells["colPhotoUrl"].Value != null)
                {
                    string photoUrl = selectedRow.Cells["colPhotoUrl"].Value.ToString();
                    addStockForm.pbProduct.Image = Image.FromFile(photoUrl);
                }
                addStockForm.txtProductId.Text = selectedRow.Cells["colProductId"].Value.ToString();
                addStockForm.txtProduct.Text = selectedRow.Cells["colProduct"].Value.ToString();
                addStockForm.ShowDialog();
                RefreshUI();
                dgvProducts.ClearSelection();
                dgvProducts.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void UpdateProduct()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                AddProductForm addProductForm = new AddProductForm();
                addProductForm.TransferDataGridView(dgvProducts);
                if (selectedRow.Cells[14].Value == null)
                {
                    addProductForm.OldPhotoUrl = "";
                }
                else
                {
                    string photoUrl = selectedRow.Cells[14].Value.ToString();
                    addProductForm.pbProduct.Image = Image.FromFile(photoUrl);
                    addProductForm.OldPhotoUrl = photoUrl;
                }
                addProductForm.txtProduct.Text = selectedRow.Cells[3].Value.ToString();
                addProductForm.txtBarcode.Text = selectedRow.Cells[4].Value.ToString();
                double sellPrice = Convert.ToDouble(selectedRow.Cells[5].Value.ToString().Replace("USD", "").Trim());
                addProductForm.txtSellPrice.Text = sellPrice.ToString();
                string category = selectedRow.Cells[7].Value.ToString();
                if (category == "Deleted")
                {
                    addProductForm.cboCategory.Text = "";
                }
                else
                {
                    addProductForm.cboCategory.Text = category;
                }
                addProductForm.lblAddProduct.Text = "Update Product";
                addProductForm.btnAdd.Text = "Update";
                addProductForm.ShowDialog();
                RefreshUI();
                dgvProducts.ClearSelection();
                dgvProducts.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void DeleteProduct(QueryOperations operation)
        {
            int selectedRowIndex = dgvProducts.SelectedRows[0].Index;
            int lastRowIndex = dgvProducts.Rows.Count - 1;
            var row = dgvProducts.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["colProductId"].Value.ToString());
            string productName = row.Cells["colProduct"].Value.ToString();
            if (MessageBox.Show($"Are you sure you want to delete product : \"{productName}\"?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteProduct(productId);
                RefreshUI();
                dgvProducts.ClearSelection();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvProducts.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvProducts.Rows[lastRowIndex].Selected = true;
                }
            }
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                if (dgvProducts.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateProduct();
                }
                if (dgvProducts.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteProduct(_operation);
                }
            }
        }
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateProduct();
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadProductData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        public void LoadProductData(QueryOperations operation, string searchTerm)
        {
            var products = operation.FetchProductData(searchTerm);
            if (products == null || dgvProducts == null)
            {
                return;
            }
            dgvProducts.Rows.Clear();
            int rowNumber = 0;
            foreach (var product in products)
            {
                rowNumber++;
                int rowIndex = dgvProducts.Rows.Add();
                DataGridViewRow row = dgvProducts.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = product.ProductId;
                try
                {
                    row.Cells[2].Value = Image.FromFile(product.PhotoUrl);
                    row.Cells[14].Value = product.PhotoUrl;
                }
                catch
                {

                }
                row.Cells[3].Value = product.Product;
                row.Cells[4].Value = product.Barcode;
                row.Cells[5].Value = $"{product.SellPrice.ToString("F")} USD";
                row.Cells[6].Value = product.QtyInStock;
                row.Cells[7].Value = product.Category;
                row.Cells[8].Value = product.CreateBy;
                row.Cells[9].Value = Customize.GetDateWithSuffix(product.CreateAt);
                row.Cells[10].Value = product.UpdateAt;
                row.Cells[11].Value = product.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
        }
        private void HandleRowSelection()
        {
            if (dgvProducts.SelectedRows.Count > 0 && dgvProducts.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var row = dgvProducts.SelectedRows[0];
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
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        private void dgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddProduct_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateProduct();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteProduct(_operation);
            }
        }
        #endregion
        #endregion
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colCategory" && e.Value != null)
            {
                if (e.Value.ToString() == "Deleted")
                {
                    if (dgvProducts.Rows[e.RowIndex].Selected)
                    {
                        e.CellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(178, 34, 34);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34);
                    }
                }
            }
        }
        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock();
        }
    }
}
