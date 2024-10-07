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
    public partial class ViewInvoiceForm : Form
    {
        QueryOperations _operation = new QueryOperations(Main.GetConnectionString());

        public ViewInvoiceForm()
        {
            InitializeComponent();
        }
        public ViewInvoiceForm(int saleId)
        {
            InitializeComponent();

            InvoiceModel invoice = _operation.FetchInvoiceHeader(saleId);

            List<InvoiceModel> invoices = _operation.FetchInvoiceDataGridView(saleId);

            double total = _operation.GetInvoiceTotal(saleId);

            LoadInvoiceForm(saleId, invoice, invoices, total);
        }
        private void LoadInvoiceForm(int saleId, InvoiceModel invoice, List<InvoiceModel> invoices, double total)
        {
            lblCustomerName.Text = $"Name: {invoice.CustomerName}";
            lblGender.Text = $"Gender: {invoice.Gender}";
            lblPhoneNumber.Text = $"Phone Number: {invoice.PhoneNumber}";
            lblAddress.Text = $"Address: {invoice.Address}";

            lblInvoiceNumber.Text = $"Invoice Number: {saleId}";
            lblRepName.Text = $"Sale Rep: {invoice.RepName}";
            lblDate.Text = $"Date: {Customize.GetDateWithSuffix(invoice.SaleDate)}";

            int rowNumber = 0;
            foreach (InvoiceModel inv in invoices)
            {
                rowNumber++;
                int rowIndex = dgvSales.Rows.Add();
                DataGridViewRow row = dgvSales.Rows[rowIndex];

                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = inv.Description;
                row.Cells[2].Value = inv.Quantity;
                row.Cells[3].Value = $"{inv.Price:F2} USD";
                row.Cells[4].Value = $"{inv.SubTotal:F2} USD";

            }

            lblTotalValue.Text = $"{total:F2} USD";

        }
    }
}
