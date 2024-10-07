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
using System.Collections;
using DataAccessLibrary;

namespace Midterm_POS_SU4.views
{
    public partial class AddProductForm : Form
    {
        private int _productId = 0;
        private string _oldProduct;
        private string _oldBarcode;
        private string _oldSellPrice;
        private string _oldPhotoUrl;
        private string _oldCategory;
        private string _photoUrl;
        public string OldPhotoUrl 
        { 
            get
            {
                return _oldPhotoUrl;
            }
            set
            {
                _oldPhotoUrl = value;
            }
        }
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddProductForm()
        {
            InitializeComponent();
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            DisplayCategoryData(_operation, cboCategory);
            _oldProduct = txtProduct.Text;
            _oldBarcode = txtBarcode.Text;
            _oldSellPrice = txtSellPrice.Text;
            _oldCategory = cboCategory.Text;
        }
        public void TransferDataGridView(DataGridView dgvProducts)
        {
            var selectedRow = dgvProducts.SelectedRows[0];
            _productId = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
        }
        private bool CheckIfProductExists(QueryOperations operation,string product)
        {
            return operation.CheckIfProductExists(product);
        }
        private bool CheckIfBarcodeExist(QueryOperations operation, long barcode)
        {
            return operation.CheckIfBarcodeExists(barcode);
        }
        private void DisplayCategoryData(QueryOperations operation, ComboBox cboCategory)
        {
            var categories = operation.FetchCategoryData();
            foreach (var category in categories)
            {
                cboCategory.Items.Add(category.Category);
            }
        }
        private bool InsertProduct(QueryOperations operation, string product, long barcode, double sellPrice, string photoUrl, string category, int createBy)
        {
            return operation.InsertProduct(product, barcode, sellPrice, photoUrl, category, createBy);
        }
        private bool UpdateProduct(QueryOperations operation, int productId, string product, long barcode, double sellPrice, string photoUrl, string category, int updateBy)
        {
            return operation.UpdateProduct(productId, product, barcode, sellPrice, photoUrl, category, updateBy);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Validating values and initializing relevant variables
            if (txtProduct.Text == "")
            {
                txtProduct.Focus();
                return;
            }
            if (txtBarcode.Text == "")
            {
                txtBarcode.Focus();
                return;
            }
            if (!long.TryParse(txtBarcode.Text, out long barcode))
            {
                txtBarcode.Clear();
                txtBarcode.Focus();
                return;
            }
            if (txtSellPrice.Text == "")
            {
                txtSellPrice.Focus();
                return;
            }
            if (!double.TryParse(txtSellPrice.Text, out double sellPrice))
            {
                txtSellPrice.Clear();
                txtSellPrice.Focus();
                return;
            }
            if (cboCategory.Text == "")
            {
                cboCategory.Focus();
                return;
            }
            string product = txtProduct.Text;
            barcode = Convert.ToInt64(txtBarcode.Text);
            sellPrice = Convert.ToDouble(txtSellPrice.Text);
            string category = cboCategory.Text;
            if (_photoUrl == null)
            {
                _photoUrl = _oldPhotoUrl;
            }
            int createBy = Program.UserId;
            int updateBy = Program.UserId;
            #endregion
            try
            {
                if (_productId == 0)
                {
                    if (CheckIfProductExists(_operation, txtProduct.Text) == true)
                    {
                        MessageBox.Show($"Product : \"{txtProduct.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProduct.Focus();
                        return;
                    }
                    if (CheckIfBarcodeExist(_operation, Convert.ToInt64(txtBarcode.Text)) == true)
                    {
                        MessageBox.Show($"Barcode : \"{txtBarcode.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBarcode.Focus();
                        return;
                    }
                    if (InsertProduct(_operation, product, barcode, sellPrice, _photoUrl, category, createBy) == true)
                    {
                        MessageBox.Show($"Product : \"{txtProduct.Text}\" is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (CheckIfProductExists(_operation, txtProduct.Text) == true && _oldProduct != txtProduct.Text)
                    {
                        MessageBox.Show($"Product : \"{txtProduct.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProduct.Focus();
                        return;
                    }
                    if (CheckIfBarcodeExist(_operation, Convert.ToInt64(txtBarcode.Text)) == true && _oldBarcode != txtBarcode.Text)
                    {
                        MessageBox.Show($"Barcode : \"{txtBarcode.Text}\" already exists.", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBarcode.Focus();
                        return;
                    }
                    if (_oldProduct == txtProduct.Text && _oldBarcode == txtBarcode.Text && _oldSellPrice == txtSellPrice.Text && _oldPhotoUrl == _photoUrl && _oldCategory == cboCategory.Text)
                    {
                        return;
                    }
                    else
                    {
                        if (UpdateProduct(_operation, _productId, product, barcode, sellPrice, _photoUrl, category, updateBy) == true)
                        {
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
        private void RefreshUI()
        {
            txtProduct.Clear();
            txtBarcode.Clear();
            txtSellPrice.Clear();
            cboCategory.Text = "";
            pbProduct.Image = null;
            txtProduct.Focus();
        }
        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnAdd_Click(sender, e);
            }
        }
        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void numQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void txtPhotoURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void cboCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterKey(sender, e);
        }
        private void SelectImage()
        {
            OpenFileDialog selectedImage = new OpenFileDialog();
            if (selectedImage.ShowDialog(this) == DialogResult.OK)
            {
                _photoUrl = selectedImage.FileName;
                pbProduct.Image = Image.FromFile(selectedImage.FileName);            
            }
        }
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            SelectImage();
        }
        private void pbProduct_Click(object sender, EventArgs e)
        {
            SelectImage();
        }
    }
}
