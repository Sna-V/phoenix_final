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
    public partial class CategoryForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvCategories.SelectedRows[0].Index;
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
            RefreshUI();
            dgvCategories.ClearSelection();
            dgvCategories.Rows[selectedRowIndex].Selected = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                if (dgvCategories.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    UpdateCategory();
                }
                else if (dgvCategories.CurrentCell.OwningColumn.Name == "colDelete")
                {
                    DeleteCategory(_operation);
                }
            }
        }
        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure we're clicking on a cell, not a header
            {
                UpdateCategory();
            }
        }
        private void UpdateCategory()
        {
            if (dgvCategories.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategories.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                AddCategoryForm addCategoryForm = new AddCategoryForm();
                addCategoryForm.TransferDataGridView(dgvCategories);
                addCategoryForm.txtCategory.Text = selectedRow.Cells[2].Value.ToString();
                string status = selectedRow.Cells[3].Value.ToString();
                if (status == "True")
                {
                    addCategoryForm.rTrue.Checked = true;
                }
                else
                {
                    addCategoryForm.rFalse.Checked = true;
                }
                addCategoryForm.lblAddCategory.Text = "Update Category";
                addCategoryForm.btnAdd.Text = "Update";
                addCategoryForm.ShowDialog();
                RefreshUI();
                dgvCategories.ClearSelection();
                dgvCategories.Rows[selectedRowIndex].Selected = true;
            }
        }
        private void DeleteCategory(QueryOperations operation)
        {
            int selectedRowIndex = dgvCategories.SelectedRows[0].Index;
            int lastRowIndex = dgvCategories.Rows.Count - 1;
            var selectedRow = dgvCategories.SelectedRows[0];
            int categoryId = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
            if (MessageBox.Show("Are you sure you want to delete this category?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                operation.DeleteCategory(categoryId);
                RefreshUI();
                if (selectedRowIndex != lastRowIndex)
                {
                    dgvCategories.Rows[selectedRowIndex].Selected = true;
                }
                else
                {
                    lastRowIndex--;
                    dgvCategories.Rows[lastRowIndex].Selected = true;
                }
            }
        }
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            LoadCategoryData(_operation, txtSearch.Text);
            HandleRowSelection();
            InvisibleUpdateLabel();
        }
        private void LoadCategoryData(QueryOperations operation, string searchTerm)
        {
            var categories = operation.FetchCategoryData(searchTerm);
            if (categories == null || dgvCategories == null)
            {
                return;
            }
            dgvCategories.Rows.Clear();
            int rowNumber = 0;
            foreach ( var category in categories)
            {
                rowNumber++;
                int rowIndex = dgvCategories.Rows.Add();
                var row = dgvCategories.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = category.CategoryId;
                row.Cells[2].Value = category.Category;
                row.Cells[3].Value = category.Status;
                row.Cells[4].Value = category.CreateBy;
                row.Cells[5].Value = Customize.GetDateWithSuffix(category.CreateAt);
                row.Cells[6].Value = category.UpdateAt;
                row.Cells[7].Value = category.UpdateBy;
            }
            lblTotalRows.Text = $"Total: {rowNumber} row{(rowNumber == 1 || rowNumber == 0 ? "" : "s")}";
        }
        private void HandleRowSelection()
        {
            if (dgvCategories.SelectedRows.Count > 0 && dgvCategories.CurrentRow?.Index >= 0)
            {
                UpdateLatestUpdateLabel();
            }
        }
        private void UpdateLatestUpdateLabel()
        {
            var row = dgvCategories.SelectedRows[0];
            if (row.Cells[7].Value != null && row.Cells[6].Value != null && dgvCategories != null) // Cells[7] = Cell["colUpdateAt"], Cells[8] = Cells["colUpdateBy"]
            {
                if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime updateAt))
                {
                    string updateBy = row.Cells[7].Value.ToString();
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
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            HandleRowSelection();
        }
        private void dgvCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert || e.KeyCode == Keys.A || e.KeyCode == Keys.I)
            {
                btnAddCategory_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                UpdateCategory();
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.D)
            {
                DeleteCategory(_operation);
            }
        }
        private void dgvCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "colStatus" column
            if (dgvCategories.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                if (e.Value.ToString() == "False")
                {
                    if (dgvCategories.Rows[e.RowIndex].Selected) // Row is selected
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
        #endregion
        #endregion
    }
}
