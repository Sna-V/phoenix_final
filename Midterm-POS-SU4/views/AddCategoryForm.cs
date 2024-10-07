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
    public partial class AddCategoryForm : Form
    {
        public int _categoryId = 0;
        public string _oldCategory;
        public bool _oldStatus;
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddCategoryForm()
        {
            InitializeComponent();
        }
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            _oldCategory = txtCategory.Text;
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
            if (txtCategory.Text == "")
            {
                txtCategory.Focus();
                return;
            }
            string category = txtCategory.Text;
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
                if (_categoryId == 0)
                {
                    if (CheckIfCategoryExists(_operation, txtCategory.Text) == true)
                    {
                        MessageBox.Show($"Category : \"{txtCategory.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategory.Focus();
                        return;
                    }
                    if (InsertCategory(_operation, category, status, createBy) == true)
                    {
                        MessageBox.Show($"Category : \"{txtCategory.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (CheckIfCategoryExists(_operation, txtCategory.Text) == true && _oldCategory != txtCategory.Text)
                    {
                        MessageBox.Show($"Category : \"{txtCategory.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategory.Focus();
                        return;
                    }
                    if (UpdateCategory(_operation, _categoryId, category, status, updateBy) == true)
                    {
                        if (_oldCategory == txtCategory.Text && _oldStatus == rTrue.Checked)
                        {
                            return;
                        }
                        if (_oldStatus == false && rTrue.Checked == true)
                        {
                            MessageBox.Show($"Category : \"{txtCategory.Text}\" is now enabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (_oldStatus == true && rTrue.Checked == false)
                        {
                            MessageBox.Show($"Category : \"{txtCategory.Text}\" is now disabled!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool InsertCategory(QueryOperations operation, string category, int status, int createBy)
        {
            return operation.InsertCategory(category, status, createBy);
        }
        private bool UpdateCategory(QueryOperations operation, int CategoryId, string category, int status, int updateBy)
        {
            return operation.UpdateCategory(CategoryId, category, status, updateBy);
        }
        #endregion
        #region -------------------------------------------------- Utilities -------------------------------------------------------
        #region Methods
        private void RefreshUI()
        {
            txtCategory.Clear();
            rTrue.Checked = true;
            txtCategory.Focus();
        }
        private bool CheckIfCategoryExists(QueryOperations operation, string category)
        {
            if (operation.CheckIfCategoryExists(category) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TransferDataGridView(DataGridView dgvCategories)
        {
            var row = dgvCategories.SelectedRows[0];
            _categoryId = Convert.ToInt32(row.Cells["colCategoryId"].Value.ToString());
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
        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
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
