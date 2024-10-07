using DataAccessLibrary;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Midterm_POS_SU4.views
{
    public partial class InvoiceForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public InvoiceForm()
        {
            InitializeComponent();
            LoadInvoiceData(txtSearch.Text);
        }
        private void LoadInvoiceData(string searchTerm)
        {
            dgvInvoices.Rows.Clear();
            List<InvoiceModel> invoices = _operation.FetchInvoiceData(searchTerm);
            int rowNumber = 0;
            foreach (InvoiceModel invoice in invoices)
            {
                rowNumber++;
                int rowIndex = dgvInvoices.Rows.Add();
                DataGridViewRow row = dgvInvoices.Rows[rowIndex];
                row.Cells[0].Value = rowNumber;
                row.Cells[1].Value = invoice.SaleId;
                row.Cells[2].Value = invoice.CustomerName;
                row.Cells[3].Value = Customize.GetDateWithSuffix(invoice.SaleDate);
                row.Cells[4].Value = $"{invoice.Total:F2} USD";
            }
        }

        private void moreInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInvoices.SelectedRows[0];
            int saleId = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
            ViewInvoiceForm viewInvoiceForm = new ViewInvoiceForm(saleId);
            viewInvoiceForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadInvoiceData(txtSearch.Text);
        }
    }
}
