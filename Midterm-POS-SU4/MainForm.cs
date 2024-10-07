using Midterm_POS_SU4.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_POS_SU4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblUserName.Text = Main.UserName;
            _instance = this;
        }
        static MainForm _instance;
        public static MainForm Instance
        {
            get
            {
                return _instance;
            }
        }
        public void AddForms(Form form)
        {
            pnMiddle.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnMiddle.Controls.Add(form);
            form.Show();
        }
        public void ButtonDefaultProperties()
        {
            btnUsers.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnRoles.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnCategories.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnProducts.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnSuppliers.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnCustomers.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnSales.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
            btnInvoices.BackColor = System.Drawing.Color.FromArgb(218, 182, 98);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnUsers.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new UserForm());
        }
        private void btnRoles_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnRoles.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new RoleForm());
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnCategories.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new CategoryForm());
        }
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnSuppliers.BackColor = System.Drawing.Color.FromArgb(198 , 162, 78);
            AddForms(new SupplierForm());
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnSales.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new SaleForm());
        }
        public void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wanna logout?", "P H O E N I X", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnProducts.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new ProductForm());
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnCustomers.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            btnCustomers.Image = global::Midterm_POS_SU4.Properties.Resources.customer_white_24px;
            btnCustomers.ForeColor = System.Drawing.Color.White;
            AddForms(new CustomerForm());
        }
        public void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            ButtonDefaultProperties();
            btnInvoices.BackColor = System.Drawing.Color.FromArgb(198, 162, 78);
            AddForms(new InvoiceForm());
        }
    }
}
