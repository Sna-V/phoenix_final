using DataAccessLibrary;
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
    public partial class AddStockForm : Form
    {
        QueryOperations _operation = new QueryOperations(Program.GetConnectionString());
        public AddStockForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string supplier = cboSupplier.Text;
            int productId = Convert.ToInt32(txtProductId.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double cost = Convert.ToDouble(txtCost.Text);
            double total = quantity * cost;
            int createBy = Program.UserId;
            if(InsertAddStock(_operation, supplier, productId, quantity, cost, total, createBy) == true)
            {
                MessageBox.Show($"Stock is added successfully!", "P H O E N I X", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUI();
            }
        }
        private bool InsertAddStock(QueryOperations operation,string supplier, int productId, int quantity, double cost, double total, int createBy)
        {
            return operation.InsertAddStock(supplier, productId, quantity, cost, total, createBy);
        }
        private void LoadSupplierData(QueryOperations operation, ComboBox cboSupplier)
        {
            var suppliers = operation.FetchSupplierData();
            foreach (var supplier in suppliers)
            {
                cboSupplier.Items.Add(supplier.SupplierName);
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupplierForm = new AddSupplierForm();
            addSupplierForm.ShowDialog();
            cboSupplier.Items.Clear();
            LoadSupplierData(_operation, cboSupplier);
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {
            LoadSupplierData(_operation, cboSupplier);
        }
        private void RefreshUI()
        {
            cboSupplier.Items.Clear();
            LoadSupplierData(_operation, cboSupplier);
            txtCost.Clear();
            txtQuantity.Clear();
        }
    }
}
