namespace Midterm_POS_SU4.views
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblScanBarcode = new System.Windows.Forms.Label();
            this.txtScanBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaymentMessage = new System.Windows.Forms.Label();
            this.lblCashReceivedValue = new System.Windows.Forms.Label();
            this.lblCashReturnValue = new System.Windows.Forms.Label();
            this.lblCashReturn = new System.Windows.Forms.Label();
            this.lblCashReceived = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInputCashReceived = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum00 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.cmsNumber = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddCustomer = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblCurrentQuantityInStock = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPhotoUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReachedTheMaximumQuantity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScanBarcode
            // 
            this.lblScanBarcode.AutoSize = true;
            this.lblScanBarcode.Location = new System.Drawing.Point(12, 133);
            this.lblScanBarcode.Name = "lblScanBarcode";
            this.lblScanBarcode.Size = new System.Drawing.Size(100, 16);
            this.lblScanBarcode.TabIndex = 15;
            this.lblScanBarcode.Text = "Scan Barcode:";
            // 
            // txtScanBarcode
            // 
            this.txtScanBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScanBarcode.Location = new System.Drawing.Point(133, 130);
            this.txtScanBarcode.Name = "txtScanBarcode";
            this.txtScanBarcode.Size = new System.Drawing.Size(601, 23);
            this.txtScanBarcode.TabIndex = 14;
            this.txtScanBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanBarcode_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPaymentMessage);
            this.panel1.Controls.Add(this.lblCashReceivedValue);
            this.panel1.Controls.Add(this.lblCashReturnValue);
            this.panel1.Controls.Add(this.lblCashReturn);
            this.panel1.Controls.Add(this.lblCashReceived);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(742, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 131);
            this.panel1.TabIndex = 17;
            // 
            // lblPaymentMessage
            // 
            this.lblPaymentMessage.Font = new System.Drawing.Font("Arial", 6.5F);
            this.lblPaymentMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPaymentMessage.Location = new System.Drawing.Point(7, 106);
            this.lblPaymentMessage.Name = "lblPaymentMessage";
            this.lblPaymentMessage.Size = new System.Drawing.Size(259, 12);
            this.lblPaymentMessage.TabIndex = 8;
            this.lblPaymentMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPaymentMessage.Visible = false;
            // 
            // lblCashReceivedValue
            // 
            this.lblCashReceivedValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReceivedValue.Location = new System.Drawing.Point(149, 52);
            this.lblCashReceivedValue.Name = "lblCashReceivedValue";
            this.lblCashReceivedValue.Size = new System.Drawing.Size(124, 22);
            this.lblCashReceivedValue.TabIndex = 7;
            this.lblCashReceivedValue.Text = "0.00 USD";
            this.lblCashReceivedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCashReturnValue
            // 
            this.lblCashReturnValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReturnValue.Location = new System.Drawing.Point(153, 78);
            this.lblCashReturnValue.Name = "lblCashReturnValue";
            this.lblCashReturnValue.Size = new System.Drawing.Size(120, 22);
            this.lblCashReturnValue.TabIndex = 6;
            this.lblCashReturnValue.Text = "0.00 USD";
            this.lblCashReturnValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCashReturn
            // 
            this.lblCashReturn.AutoSize = true;
            this.lblCashReturn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReturn.Location = new System.Drawing.Point(3, 78);
            this.lblCashReturn.Name = "lblCashReturn";
            this.lblCashReturn.Size = new System.Drawing.Size(115, 22);
            this.lblCashReturn.TabIndex = 5;
            this.lblCashReturn.Text = "Cash Return";
            // 
            // lblCashReceived
            // 
            this.lblCashReceived.AutoSize = true;
            this.lblCashReceived.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashReceived.Location = new System.Drawing.Point(3, 52);
            this.lblCashReceived.Name = "lblCashReceived";
            this.lblCashReceived.Size = new System.Drawing.Size(140, 22);
            this.lblCashReceived.TabIndex = 2;
            this.lblCashReceived.Text = "Cash Received";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(76, 17);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalValue.Size = new System.Drawing.Size(196, 32);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0.00 USD";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 32);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInputCashReceived);
            this.panel2.Controls.Add(this.btnDot);
            this.panel2.Controls.Add(this.btnNum0);
            this.panel2.Controls.Add(this.btnNum00);
            this.panel2.Controls.Add(this.btnEnter);
            this.panel2.Controls.Add(this.btnCE);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnNum3);
            this.panel2.Controls.Add(this.btnNum2);
            this.panel2.Controls.Add(this.btnNum1);
            this.panel2.Controls.Add(this.btnNum6);
            this.panel2.Controls.Add(this.btnNum5);
            this.panel2.Controls.Add(this.btnNum4);
            this.panel2.Controls.Add(this.btnNum9);
            this.panel2.Controls.Add(this.btnNum8);
            this.panel2.Controls.Add(this.btnNum7);
            this.panel2.Location = new System.Drawing.Point(742, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 313);
            this.panel2.TabIndex = 18;
            // 
            // txtInputCashReceived
            // 
            this.txtInputCashReceived.BackColor = System.Drawing.Color.White;
            this.txtInputCashReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputCashReceived.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputCashReceived.Location = new System.Drawing.Point(7, 9);
            this.txtInputCashReceived.Name = "txtInputCashReceived";
            this.txtInputCashReceived.ReadOnly = true;
            this.txtInputCashReceived.Size = new System.Drawing.Size(258, 29);
            this.txtInputCashReceived.TabIndex = 24;
            this.txtInputCashReceived.Text = "0";
            this.txtInputCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputCashReceived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputCashReceived_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(139, 242);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 60);
            this.btnDot.TabIndex = 23;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum0.ForeColor = System.Drawing.Color.White;
            this.btnNum0.Location = new System.Drawing.Point(73, 242);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(60, 60);
            this.btnNum0.TabIndex = 22;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnNum00
            // 
            this.btnNum00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum00.FlatAppearance.BorderSize = 0;
            this.btnNum00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum00.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum00.ForeColor = System.Drawing.Color.White;
            this.btnNum00.Location = new System.Drawing.Point(7, 242);
            this.btnNum00.Name = "btnNum00";
            this.btnNum00.Size = new System.Drawing.Size(60, 60);
            this.btnNum00.TabIndex = 21;
            this.btnNum00.Text = "00";
            this.btnNum00.UseVisualStyleBackColor = false;
            this.btnNum00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Gray;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Image = global::Midterm_POS_SU4.Properties.Resources.enter_button_white_16px;
            this.btnEnter.Location = new System.Drawing.Point(205, 176);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(60, 126);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(205, 110);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(60, 60);
            this.btnCE.TabIndex = 19;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::Midterm_POS_SU4.Properties.Resources.delete_button_white_16px;
            this.btnDel.Location = new System.Drawing.Point(205, 44);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 60);
            this.btnDel.TabIndex = 18;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum3.ForeColor = System.Drawing.Color.White;
            this.btnNum3.Location = new System.Drawing.Point(139, 176);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(60, 60);
            this.btnNum3.TabIndex = 17;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum2.ForeColor = System.Drawing.Color.White;
            this.btnNum2.Location = new System.Drawing.Point(73, 176);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(60, 60);
            this.btnNum2.TabIndex = 16;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum1.ForeColor = System.Drawing.Color.White;
            this.btnNum1.Location = new System.Drawing.Point(7, 176);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(60, 60);
            this.btnNum1.TabIndex = 15;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum6.ForeColor = System.Drawing.Color.White;
            this.btnNum6.Location = new System.Drawing.Point(139, 110);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(60, 60);
            this.btnNum6.TabIndex = 14;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum5.ForeColor = System.Drawing.Color.White;
            this.btnNum5.Location = new System.Drawing.Point(73, 110);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(60, 60);
            this.btnNum5.TabIndex = 13;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum4.ForeColor = System.Drawing.Color.White;
            this.btnNum4.Location = new System.Drawing.Point(7, 110);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(60, 60);
            this.btnNum4.TabIndex = 12;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum9.ForeColor = System.Drawing.Color.White;
            this.btnNum9.Location = new System.Drawing.Point(139, 44);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(60, 60);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNum8.ForeColor = System.Drawing.Color.White;
            this.btnNum8.Location = new System.Drawing.Point(73, 44);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(60, 60);
            this.btnNum8.TabIndex = 10;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.ForeColor = System.Drawing.Color.White;
            this.btnNum7.Location = new System.Drawing.Point(7, 44);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(60, 60);
            this.btnNum7.TabIndex = 9;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // cmsNumber
            // 
            this.cmsNumber.Name = "cmsNumber";
            this.cmsNumber.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(478, 71);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(256, 23);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.Location = new System.Drawing.Point(12, 32);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(115, 16);
            this.lblSelectCustomer.TabIndex = 20;
            this.lblSelectCustomer.Text = "Select Customer:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(133, 28);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(558, 24);
            this.cboCustomer.TabIndex = 21;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(367, 74);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(105, 16);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(133, 71);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(228, 23);
            this.txtCustomerName.TabIndex = 23;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(112, 16);
            this.lblCustomerName.TabIndex = 24;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(478, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(256, 23);
            this.txtAddress.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(367, 103);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 16);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address:";
            // 
            // txtGender
            // 
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(133, 100);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(228, 23);
            this.txtGender.TabIndex = 28;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 97);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 16);
            this.lblGender.TabIndex = 29;
            this.lblGender.Text = "Gender:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = global::Midterm_POS_SU4.Properties.Resources.add_green_512px;
            this.btnAddCustomer.Location = new System.Drawing.Point(697, 22);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(37, 37);
            this.btnAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCustomer.TabIndex = 27;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblCurrentQuantityInStock
            // 
            this.lblCurrentQuantityInStock.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuantityInStock.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentQuantityInStock.Location = new System.Drawing.Point(9, 475);
            this.lblCurrentQuantityInStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentQuantityInStock.Name = "lblCurrentQuantityInStock";
            this.lblCurrentQuantityInStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentQuantityInStock.Size = new System.Drawing.Size(352, 16);
            this.lblCurrentQuantityInStock.TabIndex = 30;
            this.lblCurrentQuantityInStock.Text = "Current quantity in stock:";
            this.lblCurrentQuantityInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentQuantityInStock.Visible = false;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeColumns = false;
            this.dgvSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(182)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colBarcode,
            this.colProductId,
            this.colPhoto,
            this.colPhotoUrl,
            this.colDescription,
            this.colQuantity,
            this.colPrice,
            this.colSubTotal,
            this.colQtyInStock});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvSales.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvSales.Location = new System.Drawing.Point(12, 159);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.ShowCellErrors = false;
            this.dgvSales.ShowCellToolTips = false;
            this.dgvSales.ShowEditingIcon = false;
            this.dgvSales.ShowRowErrors = false;
            this.dgvSales.Size = new System.Drawing.Size(722, 313);
            this.dgvSales.TabIndex = 16;
            this.dgvSales.SelectionChanged += new System.EventHandler(this.dgvSales_SelectionChanged);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No#";
            this.colNo.MinimumWidth = 38;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 38;
            // 
            // colBarcode
            // 
            this.colBarcode.HeaderText = "Barcode";
            this.colBarcode.MinimumWidth = 100;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            this.colBarcode.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProductId.HeaderText = "Product Id";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colPhoto
            // 
            this.colPhoto.HeaderText = "";
            this.colPhoto.Image = ((System.Drawing.Image)(resources.GetObject("colPhoto.Image")));
            this.colPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPhoto.MinimumWidth = 24;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.ReadOnly = true;
            this.colPhoto.Width = 24;
            // 
            // colPhotoUrl
            // 
            this.colPhotoUrl.HeaderText = "Photo Url";
            this.colPhotoUrl.Name = "colPhotoUrl";
            this.colPhotoUrl.ReadOnly = true;
            this.colPhotoUrl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPhotoUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPhotoUrl.Visible = false;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 100;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 79;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 83;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 100;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colQtyInStock
            // 
            this.colQtyInStock.HeaderText = "colQtyInStock";
            this.colQtyInStock.Name = "colQtyInStock";
            this.colQtyInStock.ReadOnly = true;
            this.colQtyInStock.Visible = false;
            // 
            // lblReachedTheMaximumQuantity
            // 
            this.lblReachedTheMaximumQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReachedTheMaximumQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(105)))));
            this.lblReachedTheMaximumQuantity.Location = new System.Drawing.Point(370, 475);
            this.lblReachedTheMaximumQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblReachedTheMaximumQuantity.Name = "lblReachedTheMaximumQuantity";
            this.lblReachedTheMaximumQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReachedTheMaximumQuantity.Size = new System.Drawing.Size(364, 16);
            this.lblReachedTheMaximumQuantity.TabIndex = 31;
            this.lblReachedTheMaximumQuantity.Text = "Reached the maximum quantity";
            this.lblReachedTheMaximumQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReachedTheMaximumQuantity.Visible = false;
            // 
            // SaleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 500);
            this.Controls.Add(this.lblReachedTheMaximumQuantity);
            this.Controls.Add(this.lblCurrentQuantityInStock);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblSelectCustomer);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblScanBarcode);
            this.Controls.Add(this.txtScanBarcode);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblScanBarcode;
        private System.Windows.Forms.TextBox txtScanBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblCashReceived;
        private System.Windows.Forms.Label lblCashReturn;
        private System.Windows.Forms.Label lblCashReturnValue;
        private System.Windows.Forms.Label lblCashReceivedValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnNum00;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.ContextMenuStrip cmsNumber;
        private System.Windows.Forms.TextBox txtInputCashReceived;
        private System.Windows.Forms.Label lblPaymentMessage;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox btnAddCustomer;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCurrentQuantityInStock;
        public System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewImageColumn colPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhotoUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyInStock;
        private System.Windows.Forms.Label lblReachedTheMaximumQuantity;
    }
}