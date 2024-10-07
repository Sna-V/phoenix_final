using DataAccessLibrary;
using DataAccessLibrary.Models;
using System;
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
    public partial class SaleForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        private List<CustomerModel> customers = new List<CustomerModel>();
        int _rowNumber = 0;
        public SaleForm()
        {
            InitializeComponent();
        }
        private void RefreshUI()
        {
            cboCustomer.SelectedIndex = -1;
            txtCustomerName.Clear();
            txtGender.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtScanBarcode.Clear();
            dgvSales.Rows.Clear();

            txtInputCashReceived.Text = "0";
            lblTotalValue.Text = $"{0:F2} USD";
            lblCashReceivedValue.Text = $"{0:F2} USD";
            lblCashReturnValue.Text = $"{0:F2} USD";
            lblCashReturnValue.ForeColor = Color.Black;
            lblPaymentMessage.Visible = false;
            lblCurrentQuantityInStock.Visible = false;
            lblReachedTheMaximumQuantity.Visible = false;
        }
        private void DisplayCustomerData(QueryOperations operation, ComboBox cboCustomer)
        {
            customers = operation.FetchCustomerData();
            cboCustomer.Items.Clear();
            cboCustomer.DisplayMember = "CustomerName";
            foreach (var customer in customers)
            {
                cboCustomer.Items.Add($"{customer.CustomerName} - {customer.Gender} - {customer.PhoneNumber} - {customer.Address}");
            }
            cboCustomer.SelectedIndexChanged += CboCustomer_SelectedIndexChanged;
        }
        private void ScanBarcode(QueryOperations operation, long barcode)
        {
            var sales = operation.ScanBarcode(barcode);
            if (sales.Count == 0)
            {
                MessageBox.Show("Product is not found!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var sale in sales)
            {
                bool productFound = false;
                if (sale.QtyInStock == 0)
                {
                    MessageBox.Show("Product is not yet in stock!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == sale.Barcode.ToString())
                    {
                        int currentQuantity = Convert.ToInt32(row.Cells[6].Value);
                        int currentQuantityInStock = Convert.ToInt32(row.Cells[9].Value);
                        if (currentQuantity < currentQuantityInStock)
                        {
                            currentQuantity++;
                            row.Cells[6].Value = currentQuantity;
                            row.Cells[8].Value = $"{(currentQuantity * sale.Price):F2} USD";
                        }
                        productFound = true;
                        break;
                    }
                }
                if (productFound == false)
                {
                    _rowNumber++;
                    int rowIndex = dgvSales.Rows.Add();
                    DataGridViewRow row = dgvSales.Rows[rowIndex];
                    row.Cells[0].Value = _rowNumber;
                    row.Cells[1].Value = sale.Barcode;
                    row.Cells[2].Value = sale.ProductId;            
                    if (string.IsNullOrEmpty(sale.PhotoUrl) == true)
                    {
                        row.Cells[3].Value = null;
                    }
                    else
                    {
                        try
                        {
                            row.Cells[3].Value = Image.FromFile(sale.PhotoUrl);
                        }
                        catch
                        {
                            row.Cells[3].Value = null;
                        }
                    }
                    row.Cells[4].Value = sale.PhotoUrl;
                    row.Cells[5].Value = sale.Description;
                    row.Cells[6].Value = sale.Quantity;
                    row.Cells[7].Value = $"{sale.Price:F2} USD";
                    row.Cells[8].Value = $"{(sale.Quantity * sale.Price):F2} USD";
                    row.Cells[9].Value = sale.QtyInStock;
                }
            }
            lblTotalValue.Text = $"{CalculateTotal():F2} USD";
            int lastRowIndex = dgvSales.Rows.Count - 1;
            dgvSales.Rows[lastRowIndex].Selected = true;
            SelectedRow();
        }
        private void CommitSale()
        {
            if (txtInputCashReceived.Text.Trim() == "")
            {
                return;
            }
            if (cboCustomer.SelectedIndex < 0)
            {
                lblPaymentMessage.ForeColor = Color.FromArgb(178, 34, 34);
                lblPaymentMessage.Text = "Please select a customer!";
                lblPaymentMessage.Visible = true;
                cboCustomer.Focus();
                return;
            }
            double total = Convert.ToDouble(lblTotalValue.Text.Replace(" USD", "").Trim());
            double cashReceived = Convert.ToDouble(txtInputCashReceived.Text.Replace(" USD", "").Trim());
            if (cashReceived >= total)
            {
                double cashReturn = cashReceived - total;

                lblCashReceivedValue.ForeColor = Color.Black;
                lblCashReceivedValue.Text = $"{Convert.ToDouble(txtInputCashReceived.Text):F2} USD";

                lblCashReturnValue.ForeColor = Color.FromArgb(9, 121, 105);
                lblCashReturnValue.Text = $"{cashReturn:F2} USD";

                lblPaymentMessage.Visible = false;

                var saleDetails = new List<SaleDetailModel>();

                string phoneNumber = txtPhoneNumber.Text;
                int userId = Program.UserId;
                double totalAmount = Convert.ToDouble(lblTotalValue.Text.Replace(" USD", "").Trim());
                int saleId = _operation.InsertSale(phoneNumber, userId, totalAmount);
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    saleDetails.Add(new SaleDetailModel
                    {
                        ProductId = Convert.ToInt32(row.Cells[2].Value.ToString()),
                        Quantity = Convert.ToInt32(row.Cells[6].Value.ToString()),
                        Price = Convert.ToDouble(row.Cells[7].Value.ToString().Replace(" USD", "").Trim()),
                        SubTotal = Convert.ToDouble(row.Cells[8].Value.ToString().Replace(" USD", "").Trim())
                    });
                }
                if (saleId > 0)
                {
                    if (_operation.InsertSaleDetail(saleId, saleDetails) == true)
                    {
                        lblPaymentMessage.ForeColor = Color.FromArgb(9, 121, 105);
                        lblPaymentMessage.Text = "Payment Successful!";
                        lblPaymentMessage.Visible = true;
                        ViewInvoiceForm invoiceForm = new ViewInvoiceForm(saleId);
                        invoiceForm.ShowDialog();
                    }
                    else
                    {
                        _operation.DeleteSale(saleId);
                    }
                    RefreshUI();
                }
            }
            else if (cashReceived > 0)
            {
                lblCashReceivedValue.ForeColor = Color.FromArgb(178, 34, 34);
                lblCashReceivedValue.Text = $"{Convert.ToDouble(txtInputCashReceived.Text):F2} USD";
                lblCashReturnValue.ForeColor = Color.Black;
                lblCashReturnValue.Text = $"{0:F2} USD";
                txtInputCashReceived.Text = "0";
                lblPaymentMessage.ForeColor = Color.FromArgb(178, 34, 34);
                lblPaymentMessage.Text = "Insufficient Cash: Cash received is less than the total price.";
                lblPaymentMessage.Visible = true;
            }
        }
        private double CalculateTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells[8] != null)
                {
                    string totalString = row.Cells[8].Value.ToString().Replace(" USD", "");
                    if (double.TryParse(totalString, out double totalDouble))
                    {
                        total += totalDouble;
                    }
                }
            }
            return total;
        }
        private void txtCashReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (dgvSales.Rows.Count > 0)
                {
                    if (txtInputCashReceived.Text.Trim() == "")
                    {
                        return;
                    }
                    double total = Convert.ToDouble(lblTotalValue.Text.Replace(" USD", "").Trim());
                    double cashReceived = Convert.ToDouble(txtInputCashReceived.Text.Replace(" USD", "").Trim());
                    if (cashReceived >= total)
                    {
                        double cashReturn = cashReceived - total;
                        lblCashReturnValue.ForeColor = Color.FromArgb(9, 121, 105);
                        lblCashReturnValue.Text = $"{cashReturn:F2} USD";

                    }
                }
            }
        }
        #region Events
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            DisplayCustomerData(_operation, cboCustomer);
        }
        private void SaleForm_Load(object sender, EventArgs e)
        {
            DisplayCustomerData(_operation, cboCustomer);
            SelectedRow();
        }
        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            SelectedRow();
        }
        private void CboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex >= 0)
            {
                var selectedCustomer = customers[cboCustomer.SelectedIndex];
                txtCustomerName.Text = selectedCustomer.CustomerName;
                txtGender.Text = selectedCustomer.Gender;
                txtPhoneNumber.Text = selectedCustomer.PhoneNumber;
                txtAddress.Text = selectedCustomer.Address;
            }
        }
        private void txtScanBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (backspace, delete etc.)
            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
            {
                // If it's not a control key ot digit, suppress the key press
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtScanBarcode.Text) == false)
                {
                    ScanBarcode(_operation, Convert.ToInt64(txtScanBarcode.Text));
                }
            }
        }
        private void txtInputCashReceived_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0: // Numpad '0' key
                    btnNum0.PerformClick();
                    break;
                case Keys.D1: // Numpad '1' key
                    btnNum1.PerformClick();
                    break;
                case Keys.D2: // Numpad '2' key
                    btnNum2.PerformClick();
                    break;
                case Keys.D3: // Numpad '3' key
                    btnNum3.PerformClick();
                    break;
                case Keys.D4: // Numpad '4' key
                    btnNum4.PerformClick();
                    break;
                case Keys.D5: // Numpad '5' key
                    btnNum5.PerformClick();
                    break;
                case Keys.D6: // Numpad '6' key
                    btnNum6.PerformClick();
                    break;
                case Keys.D7: // Numpad '7' key
                    btnNum7.PerformClick();
                    break;
                case Keys.D8: // Numpad '8' key
                    btnNum8.PerformClick();
                    break;
                case Keys.D9: // Numpad '9' key
                    btnNum9.PerformClick();
                    break;
                case Keys.OemPeriod: // '.' key
                case Keys.Decimal:   // Numpad '.' key
                    btnDot.PerformClick();
                    break;
                case Keys.Back: // Backspace key
                    btnDel.PerformClick();
                    break;
                case Keys.Enter: // Enter key
                    btnEnter.PerformClick();
                    break;
                case Keys.Delete: // Delete key (Clear entry)
                    btnCE.PerformClick();
                    break;
            }
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "1";
            }
            else
            {
                txtInputCashReceived.Text = "1";
            }
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "2";
            }
            else
            {
                txtInputCashReceived.Text = "2";
            }
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "3";
            }
            else
            {
                txtInputCashReceived.Text = "3";
            }
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "4";
            }
            else
            {
                txtInputCashReceived.Text = "4";
            }
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "5";
            }
            else
            {
                txtInputCashReceived.Text = "5";
            }
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "6";
            }
            else
            {
                txtInputCashReceived.Text = "6";
            }
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "7";
            }
            else
            {
                txtInputCashReceived.Text = "7";
            }
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "8";
            }
            else
            {
                txtInputCashReceived.Text = "8";
            }
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "9";
            }
            else
            {
                txtInputCashReceived.Text = "9";
            }
        }
        private void btn00_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "00";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text != "0")
            {
                txtInputCashReceived.Text += "0";
            }
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text.Contains(".") == false)
            {
                txtInputCashReceived.Text += ".";
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtInputCashReceived.Text.Length > 0)
            {
                txtInputCashReceived.Text = txtInputCashReceived.Text.Remove(txtInputCashReceived.Text.Length - 1);
                if (txtInputCashReceived.Text.Length == 0)
                {
                    txtInputCashReceived.Text = "0";
                }
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtInputCashReceived.Text = "0";
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (dgvSales.Rows.Count > 0)
            {
                CommitSale();  
            }
        }
        #endregion
        private void CurrentQuantityInStockLabelVisibility()
        {
            if (_rowNumber > 0)
            {
                lblCurrentQuantityInStock.Visible = true;
            }
            else
            {
                lblCurrentQuantityInStock.Visible = false;
            }
        }
        private void SelectedRow()
        {
            if (dgvSales.SelectedRows.Count > 0 && dgvSales.CurrentRow?.Index >= 0)
            {
                var selectedRow = dgvSales.SelectedRows[0];
                if (selectedRow.Cells[9].Value != null)
                {
                    int currentQty = Convert.ToInt32(selectedRow.Cells[6].Value);
                    int currentQtyInStock = Convert.ToInt32(selectedRow.Cells[9].Value);
                    if (currentQty == currentQtyInStock)
                    {
                        lblReachedTheMaximumQuantity.Visible = true;
                    }
                    else
                    {
                        lblReachedTheMaximumQuantity.Visible = false;
                    }
                    lblCurrentQuantityInStock.Text = $"Current quantity in stock: {currentQtyInStock}";
                    CurrentQuantityInStockLabelVisibility();
                }
            }
        }
    }
}
