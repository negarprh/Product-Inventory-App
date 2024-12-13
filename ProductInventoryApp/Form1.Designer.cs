namespace ProductInventoryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox8 = new GroupBox();
            label15 = new Label();
            comboBoxDeleteCustomer = new ComboBox();
            btnDeleteCustomer = new Button();
            groupBox7 = new GroupBox();
            label20 = new Label();
            comboBoxUpdateCustomer = new ComboBox();
            btnUpdateCustomer = new Button();
            label22 = new Label();
            label23 = new Label();
            txtUpdateCustomerPhone = new TextBox();
            txtUpdateCustomerEmail = new TextBox();
            txtUpdateCustomerName = new TextBox();
            label24 = new Label();
            groupBox6 = new GroupBox();
            btnAddCustomer = new Button();
            label17 = new Label();
            label18 = new Label();
            txtAddCustomerPhone = new TextBox();
            txtAddCustomerEmail = new TextBox();
            txtAddCustomerName = new TextBox();
            label19 = new Label();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            dgvLowStockAlert = new DataGridView();
            button4 = new Button();
            groupBox4 = new GroupBox();
            comboBoxSelectProductSale = new ComboBox();
            comboBoxSelectCustomer = new ComboBox();
            dateTimePickerSaleDate = new DateTimePicker();
            btnRecordSale = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtQuantitySold = new TextBox();
            label14 = new Label();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            dgvProducts = new DataGridView();
            btnSearchProduct = new Button();
            label10 = new Label();
            comboBoxSearchCategory = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            comboBoxSelectProduct = new ComboBox();
            btnUpdateProduct = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUpdateStockLevel = new TextBox();
            txtUpdateCategory = new TextBox();
            txtUpdatePrice = new TextBox();
            txtUpdateProductName = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnSaveProduct = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtStockLevel = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockAlert).BeginInit();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 575);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox8);
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 542);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Managment";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(comboBoxDeleteCustomer);
            groupBox8.Controls.Add(btnDeleteCustomer);
            groupBox8.Location = new Point(153, 314);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(457, 225);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "Delete Customer";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(43, 52);
            label15.Name = "label15";
            label15.Size = new Size(116, 20);
            label15.TabIndex = 11;
            label15.Text = "Select Customer";
            // 
            // comboBoxDeleteCustomer
            // 
            comboBoxDeleteCustomer.FormattingEnabled = true;
            comboBoxDeleteCustomer.Location = new Point(221, 44);
            comboBoxDeleteCustomer.Name = "comboBoxDeleteCustomer";
            comboBoxDeleteCustomer.Size = new Size(125, 28);
            comboBoxDeleteCustomer.TabIndex = 10;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(136, 132);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(136, 29);
            btnDeleteCustomer.TabIndex = 9;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label20);
            groupBox7.Controls.Add(comboBoxUpdateCustomer);
            groupBox7.Controls.Add(btnUpdateCustomer);
            groupBox7.Controls.Add(label22);
            groupBox7.Controls.Add(label23);
            groupBox7.Controls.Add(txtUpdateCustomerPhone);
            groupBox7.Controls.Add(txtUpdateCustomerEmail);
            groupBox7.Controls.Add(txtUpdateCustomerName);
            groupBox7.Controls.Add(label24);
            groupBox7.Location = new Point(404, 6);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(379, 295);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Update Customer";
           
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(35, 29);
            label20.Name = "label20";
            label20.Size = new Size(116, 20);
            label20.TabIndex = 11;
            label20.Text = "Select Customer";
            // 
            // comboBoxUpdateCustomer
            // 
            comboBoxUpdateCustomer.FormattingEnabled = true;
            comboBoxUpdateCustomer.Location = new Point(190, 21);
            comboBoxUpdateCustomer.Name = "comboBoxUpdateCustomer";
            comboBoxUpdateCustomer.Size = new Size(125, 28);
            comboBoxUpdateCustomer.TabIndex = 10;
            comboBoxUpdateCustomer.SelectedIndexChanged += comboBoxUpdateCustomer_SelectedIndexChanged;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(162, 243);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(136, 29);
            btnUpdateCustomer.TabIndex = 9;
            btnUpdateCustomer.Text = "Update Details";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(35, 170);
            label22.Name = "label22";
            label22.Size = new Size(46, 20);
            label22.TabIndex = 7;
            label22.Text = "Email";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(35, 122);
            label23.Name = "label23";
            label23.Size = new Size(94, 20);
            label23.TabIndex = 6;
            label23.Text = "Phone Name";
            // 
            // txtUpdateCustomerPhone
            // 
            txtUpdateCustomerPhone.Location = new Point(190, 115);
            txtUpdateCustomerPhone.Name = "txtUpdateCustomerPhone";
            txtUpdateCustomerPhone.Size = new Size(125, 27);
            txtUpdateCustomerPhone.TabIndex = 4;
            // 
            // txtUpdateCustomerEmail
            // 
            txtUpdateCustomerEmail.Location = new Point(190, 170);
            txtUpdateCustomerEmail.Name = "txtUpdateCustomerEmail";
            txtUpdateCustomerEmail.Size = new Size(125, 27);
            txtUpdateCustomerEmail.TabIndex = 2;
            // 
            // txtUpdateCustomerName
            // 
            txtUpdateCustomerName.Location = new Point(190, 69);
            txtUpdateCustomerName.Name = "txtUpdateCustomerName";
            txtUpdateCustomerName.Size = new Size(125, 27);
            txtUpdateCustomerName.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(35, 76);
            label24.Name = "label24";
            label24.Size = new Size(116, 20);
            label24.TabIndex = 1;
            label24.Text = "Customer Name";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnAddCustomer);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(txtAddCustomerPhone);
            groupBox6.Controls.Add(txtAddCustomerEmail);
            groupBox6.Controls.Add(txtAddCustomerName);
            groupBox6.Controls.Add(label19);
            groupBox6.Location = new Point(6, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(379, 295);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Add a Customer";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(133, 216);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(136, 29);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(35, 149);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 7;
            label17.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(35, 104);
            label18.Name = "label18";
            label18.Size = new Size(108, 20);
            label18.TabIndex = 6;
            label18.Text = "Phone Number";
            // 
            // txtAddCustomerPhone
            // 
            txtAddCustomerPhone.Location = new Point(190, 97);
            txtAddCustomerPhone.Name = "txtAddCustomerPhone";
            txtAddCustomerPhone.Size = new Size(125, 27);
            txtAddCustomerPhone.TabIndex = 4;
            // 
            // txtAddCustomerEmail
            // 
            txtAddCustomerEmail.Location = new Point(190, 142);
            txtAddCustomerEmail.Name = "txtAddCustomerEmail";
            txtAddCustomerEmail.Size = new Size(125, 27);
            txtAddCustomerEmail.TabIndex = 2;
            // 
            // txtAddCustomerName
            // 
            txtAddCustomerName.Location = new Point(190, 57);
            txtAddCustomerName.Name = "txtAddCustomerName";
            txtAddCustomerName.Size = new Size(125, 27);
            txtAddCustomerName.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(35, 64);
            label19.Name = "label19";
            label19.Size = new Size(116, 20);
            label19.TabIndex = 1;
            label19.Text = "Customer Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 542);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sales Managment";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvLowStockAlert);
            groupBox5.Controls.Add(button4);
            groupBox5.Location = new Point(6, 311);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(761, 228);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Low Stock Alert";
            // 
            // dgvLowStockAlert
            // 
            dgvLowStockAlert.AllowUserToAddRows = false;
            dgvLowStockAlert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStockAlert.Location = new Point(0, 38);
            dgvLowStockAlert.Name = "dgvLowStockAlert";
            dgvLowStockAlert.RowHeadersWidth = 51;
            dgvLowStockAlert.Size = new Size(572, 184);
            dgvLowStockAlert.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(204, 243);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBoxSelectProductSale);
            groupBox4.Controls.Add(comboBoxSelectCustomer);
            groupBox4.Controls.Add(dateTimePickerSaleDate);
            groupBox4.Controls.Add(btnRecordSale);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtQuantitySold);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(6, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(777, 295);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Record Sales";
            // 
            // comboBoxSelectProductSale
            // 
            comboBoxSelectProductSale.FormattingEnabled = true;
            comboBoxSelectProductSale.Location = new Point(173, 36);
            comboBoxSelectProductSale.Name = "comboBoxSelectProductSale";
            comboBoxSelectProductSale.Size = new Size(164, 28);
            comboBoxSelectProductSale.TabIndex = 12;
            comboBoxSelectProductSale.SelectedIndexChanged += comboBoxSelectProductSale_SelectedIndexChanged;
            // 
            // comboBoxSelectCustomer
            // 
            comboBoxSelectCustomer.FormattingEnabled = true;
            comboBoxSelectCustomer.Location = new Point(173, 76);
            comboBoxSelectCustomer.Name = "comboBoxSelectCustomer";
            comboBoxSelectCustomer.Size = new Size(164, 28);
            comboBoxSelectCustomer.TabIndex = 11;
            // 
            // dateTimePickerSaleDate
            // 
            dateTimePickerSaleDate.Location = new Point(173, 176);
            dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            dateTimePickerSaleDate.Size = new Size(164, 27);
            dateTimePickerSaleDate.TabIndex = 10;
            // 
            // btnRecordSale
            // 
            btnRecordSale.Location = new Point(207, 243);
            btnRecordSale.Name = "btnRecordSale";
            btnRecordSale.Size = new Size(94, 29);
            btnRecordSale.TabIndex = 9;
            btnRecordSale.Text = "Record";
            btnRecordSale.UseVisualStyleBackColor = true;
            btnRecordSale.Click += btnRecordSale_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 176);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 8;
            label11.Text = "Sale Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 129);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 7;
            label12.Text = "Quantity Sold";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 84);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 6;
            label13.Text = "Customer";
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.Location = new Point(173, 122);
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.Size = new Size(164, 27);
            txtQuantitySold.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(35, 44);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 1;
            label14.Text = "Product";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(790, 542);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Managment";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvProducts);
            groupBox3.Controls.Add(btnSearchProduct);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(comboBoxSearchCategory);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(9, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(761, 228);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "View Product Details";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(0, 56);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(572, 166);
            dgvProducts.TabIndex = 13;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(364, 21);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(94, 29);
            btnSearchProduct.TabIndex = 12;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 29);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 11;
            label10.Text = "Select Product";
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Location = new Point(190, 21);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(125, 28);
            comboBoxSearchCategory.TabIndex = 10;
            comboBoxSearchCategory.SelectedIndexChanged += comboBoxSearchCategory_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(204, 243);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBoxSelectProduct);
            groupBox2.Controls.Add(btnUpdateProduct);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtUpdateStockLevel);
            groupBox2.Controls.Add(txtUpdateCategory);
            groupBox2.Controls.Add(txtUpdatePrice);
            groupBox2.Controls.Add(txtUpdateProductName);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(391, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 295);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 29);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 11;
            label9.Text = "Select Product";
            // 
            // comboBoxSelectProduct
            // 
            comboBoxSelectProduct.FormattingEnabled = true;
            comboBoxSelectProduct.Location = new Point(190, 21);
            comboBoxSelectProduct.Name = "comboBoxSelectProduct";
            comboBoxSelectProduct.Size = new Size(125, 28);
            comboBoxSelectProduct.TabIndex = 10;
            comboBoxSelectProduct.SelectedIndexChanged += comboBoxSelectProduct_SelectedIndexChanged;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(204, 243);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(94, 29);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 196);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "Stock Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 149);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 104);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Category";
            // 
            // txtUpdateStockLevel
            // 
            txtUpdateStockLevel.Location = new Point(190, 193);
            txtUpdateStockLevel.Name = "txtUpdateStockLevel";
            txtUpdateStockLevel.Size = new Size(125, 27);
            txtUpdateStockLevel.TabIndex = 5;
            // 
            // txtUpdateCategory
            // 
            txtUpdateCategory.Location = new Point(190, 97);
            txtUpdateCategory.Name = "txtUpdateCategory";
            txtUpdateCategory.Size = new Size(125, 27);
            txtUpdateCategory.TabIndex = 4;
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(190, 142);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(125, 27);
            txtUpdatePrice.TabIndex = 2;
            // 
            // txtUpdateProductName
            // 
            txtUpdateProductName.Location = new Point(190, 57);
            txtUpdateProductName.Name = "txtUpdateProductName";
            txtUpdateProductName.Size = new Size(125, 27);
            txtUpdateProductName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 64);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 1;
            label8.Text = "Product Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveProduct);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStockLevel);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(207, 243);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(94, 29);
            btnSaveProduct.TabIndex = 9;
            btnSaveProduct.Text = "Save";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 176);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Stock Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 129);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 84);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Category";
            // 
            // txtStockLevel
            // 
            txtStockLevel.Location = new Point(190, 176);
            txtStockLevel.Name = "txtStockLevel";
            txtStockLevel.Size = new Size(125, 27);
            txtStockLevel.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(190, 81);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(190, 122);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(190, 44);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 44);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 578);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStockAlert).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private Button btnSaveProduct;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStockLevel;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox comboBoxSelectProduct;
        private Button btnUpdateProduct;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUpdateStockLevel;
        private TextBox txtUpdateCategory;
        private TextBox txtUpdatePrice;
        private TextBox txtUpdateProductName;
        private Label label8;
        private GroupBox groupBox3;
        private Button btnSearchProduct;
        private Label label10;
        private ComboBox comboBoxSearchCategory;
        private Button button1;
        private DataGridView dgvProducts;
        private GroupBox groupBox4;
        private DateTimePicker dateTimePickerSaleDate;
        private Button btnRecordSale;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtQuantitySold;
        private Label label14;
        private ComboBox comboBoxSelectProductSale;
        private ComboBox comboBoxSelectCustomer;
        private GroupBox groupBox5;
        private DataGridView dgvLowStockAlert;
        private Button button4;
        private GroupBox groupBox7;
        private Label label20;
        private ComboBox comboBoxUpdateCustomer;
        private Button btnUpdateCustomer;
        private Label label22;
        private Label label23;
        private TextBox txtUpdateCustomerPhone;
        private TextBox txtUpdateCustomerEmail;
        private TextBox txtUpdateCustomerName;
        private Label label24;
        private GroupBox groupBox6;
        private Button btnAddCustomer;
        private Label label17;
        private Label label18;
        private TextBox txtAddCustomerPhone;
        private TextBox txtAddCustomerEmail;
        private TextBox txtAddCustomerName;
        private Label label19;
        private GroupBox groupBox8;
        private Label label15;
        private ComboBox comboBoxDeleteCustomer;
        private Button btnDeleteCustomer;
    }
}
