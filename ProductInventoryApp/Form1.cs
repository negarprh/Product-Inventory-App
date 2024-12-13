using System.Globalization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductInventoryApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void LoadProducts()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT ProductID, ProductName, Category, Price, StockLevel FROM Products";
            dgvProducts.DataSource = db.ExecuteQuery(query);
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string category = txtCategory.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int stockLevel = Convert.ToInt32(txtStockLevel.Text);

            string query = $"INSERT INTO Products (ProductName, Category, Price, StockLevel) VALUES ('{productName}', '{category}', {price}, {stockLevel})";

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Product added successfully!");

            // Refresh product list
            LoadProducts();
            ClearAddProductFields();
        }

        // Clear the input fields after saving
        private void ClearAddProductFields()
        {
            txtProductName.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
            txtStockLevel.Text = "";
        }

        private void LoadProductsToDropdown()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT ProductID, ProductName FROM Products";
            DataTable table = db.ExecuteQuery(query);

            comboBoxSelectProduct.DataSource = table;
            comboBoxSelectProduct.DisplayMember = "ProductName";
            comboBoxSelectProduct.ValueMember = "ProductID";
        }



        private void comboBoxSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectProduct.SelectedValue != null)
            {
                int productId = Convert.ToInt32(((DataRowView)comboBoxSelectProduct.SelectedItem)["ProductID"]);


                string query = $"SELECT ProductName, Category, Price, StockLevel FROM Products WHERE ProductID = {productId}";

                DatabaseHelper db = new DatabaseHelper();
                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    txtUpdateProductName.Text = table.Rows[0]["ProductName"].ToString();
                    txtUpdateCategory.Text = table.Rows[0]["Category"].ToString();
                    txtUpdatePrice.Text = table.Rows[0]["Price"].ToString();
                    txtUpdateStockLevel.Text = table.Rows[0]["StockLevel"].ToString();
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string productName = txtUpdateProductName.Text;
            string category = txtUpdateCategory.Text;
            decimal price = Convert.ToDecimal(txtUpdatePrice.Text);
            int stockLevel = Convert.ToInt32(txtUpdateStockLevel.Text);

            int productId = (int)comboBoxSelectProduct.SelectedValue;

            string query = $"UPDATE Products " +
                           $"SET ProductName = '{productName}', Category = '{category}', Price = {price}, StockLevel = {stockLevel} " +
                           $"WHERE ProductID = {productId}";

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Product updated successfully!");

            // Refresh product list and clear fields
            LoadProducts();
            LoadProductsToDropdown();
            ClearUpdateProductFields();

        }


        // Clear the input fields after saving
        private void ClearUpdateProductFields()
        {
            txtUpdateProductName.Text = "";
            txtUpdateCategory.Text = "";
            txtUpdatePrice.Text = "";
            txtUpdateStockLevel.Text = "";
        }

        private void LoadProductsToGrid()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT ProductName, Category, Price, StockLevel FROM Products";
            dgvProducts.DataSource = db.ExecuteQuery(query);
        }

        private void LoadCategoriesToDropdown()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT DISTINCT Category FROM Products";

            DataTable table = db.ExecuteQuery(query);

            // Temporarily remove the event handler
            comboBoxSearchCategory.SelectedIndexChanged -= comboBoxSearchCategory_SelectedIndexChanged;

            comboBoxSearchCategory.DataSource = table;
            comboBoxSearchCategory.DisplayMember = "Category";
            comboBoxSearchCategory.ValueMember = "Category";

            // Reattach the event handler
            comboBoxSearchCategory.SelectedIndexChanged += comboBoxSearchCategory_SelectedIndexChanged;
        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxSearchCategory.SelectedValue.ToString();
            string query = $"SELECT ProductName, Category, Price, StockLevel FROM Products WHERE Category = '{selectedCategory}'";

            DatabaseHelper db = new DatabaseHelper();
            dgvProducts.DataSource = db.ExecuteQuery(query);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchCategory.SelectedValue != null)
            {
                string selectedCategory = comboBoxSearchCategory.SelectedValue.ToString();

                string query = $"SELECT ProductName, Category, Price, StockLevel FROM Products WHERE Category = '{selectedCategory}'";

                DatabaseHelper db = new DatabaseHelper();
                dgvProducts.DataSource = db.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Please select a category to search.");
            }
        }

        /// <summary>
        /// /
        /// </summary>

        private void LoadProductsToSalesDropdown()
        {
            // Temporarily detach the event
            comboBoxSelectProductSale.SelectedIndexChanged -= comboBoxSelectProductSale_SelectedIndexChanged;

            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT ProductID, ProductName FROM Products";

            DataTable table = db.ExecuteQuery(query);

            comboBoxSelectProductSale.DataSource = table;
            comboBoxSelectProductSale.DisplayMember = "ProductName"; // What to display
            comboBoxSelectProductSale.ValueMember = "ProductID";     // Actual value

            // Reattach the event
            comboBoxSelectProductSale.SelectedIndexChanged += comboBoxSelectProductSale_SelectedIndexChanged;

        }


        private void LoadCustomersToDropdown()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT CustomerID, CustomerName FROM Customers";

            DataTable table = db.ExecuteQuery(query);

            comboBoxSelectCustomer.DataSource = table;
            comboBoxSelectCustomer.DisplayMember = "CustomerName";
            comboBoxSelectCustomer.ValueMember = "CustomerID";

            // For Delete Customer Dropdown
            comboBoxDeleteCustomer.DataSource = table;
            comboBoxDeleteCustomer.DisplayMember = "CustomerName";
            comboBoxDeleteCustomer.ValueMember = "CustomerID";

            // Update ComboBox for Updating Customer
            comboBoxUpdateCustomer.DataSource = table;
            comboBoxUpdateCustomer.DisplayMember = "CustomerName";
            comboBoxUpdateCustomer.ValueMember = "CustomerID";

        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectProductSale.SelectedValue != null && comboBoxSelectCustomer.SelectedValue != null)
            {
                int productId = (int)comboBoxSelectProductSale.SelectedValue;
                int customerId = (int)comboBoxSelectCustomer.SelectedValue;
                int quantitySold = Convert.ToInt32(txtQuantitySold.Text);
                DateTime saleDate = dateTimePickerSaleDate.Value;

                DatabaseHelper db = new DatabaseHelper();

                // Insert the sale into the Sales table
                string insertQuery = $"INSERT INTO Sales (ProductID, CustomerID, QuantitySold, SaleDate) " +
                                     $"VALUES ({productId}, {customerId}, {quantitySold}, '{saleDate}')";

                db.ExecuteNonQuery(insertQuery);

                // Update the stock level in the Products table
                string updateQuery = $"UPDATE Products " +
                                     $"SET StockLevel = StockLevel - {quantitySold} " +
                                     $"WHERE ProductID = {productId}";

                db.ExecuteNonQuery(updateQuery);

                MessageBox.Show("Sale recorded successfully and stock updated!");

                // Refresh low stock alert and product grid
                LoadLowStockAlert();
            }
            else
            {
                MessageBox.Show("Please select a product and customer.");
            }
        }

        private void LoadLowStockAlert()
        {
            DatabaseHelper db = new DatabaseHelper();
            string query = "SELECT ProductID, ProductName, StockLevel FROM Products WHERE StockLevel < 10";

            DataTable table = db.ExecuteQuery(query);

            dgvLowStockAlert.DataSource = table;
        }








        private void comboBoxSelectProductSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectProductSale.SelectedValue != null)
            {
                // Get the selected ProductID
                int productId = Convert.ToInt32(((DataRowView)comboBoxSelectProductSale.SelectedItem)["ProductID"]);

                // Query to fetch the product details
                string query = $"SELECT ProductName, Category, Price, StockLevel FROM Products WHERE ProductID = {productId}";

                DatabaseHelper db = new DatabaseHelper();
                DataTable table = db.ExecuteQuery(query);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProductsToDropdown();
            LoadProductsToGrid();
            LoadProductsToSalesDropdown();
            LoadCustomersToDropdown();
            LoadLowStockAlert();
            LoadCategoriesToDropdown();

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtAddCustomerName.Text;
            string phoneNumber = txtAddCustomerPhone.Text;
            string email = txtAddCustomerEmail.Text;

            string query = $"INSERT INTO Customers (CustomerName, PhoneNumber, Email) " +
                           $"VALUES ('{customerName}', '{phoneNumber}', '{email}')";

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Customer added successfully!");

            LoadCustomersToDropdown(); // Refresh dropdowns
            ClearAddCustomerFields();
        }

        private void ClearAddCustomerFields()
        {
            txtAddCustomerName.Text = "";
            txtAddCustomerPhone.Text = "";
            txtAddCustomerEmail.Text = "";
        }

        private void comboBoxUpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateCustomer.SelectedValue != null)
            {
                int customerId = Convert.ToInt32(((DataRowView)comboBoxUpdateCustomer.SelectedItem)["CustomerID"]);


                string query = $"SELECT CustomerName, PhoneNumber, Email FROM Customers WHERE CustomerID = {customerId}";
                DatabaseHelper db = new DatabaseHelper();
                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count > 0)
                {
                    txtUpdateCustomerName.Text = table.Rows[0]["CustomerName"].ToString();
                    txtUpdateCustomerPhone.Text = table.Rows[0]["PhoneNumber"].ToString();
                    txtUpdateCustomerEmail.Text = table.Rows[0]["Email"].ToString();
                }
            }
        }




        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int customerId = (int)comboBoxUpdateCustomer.SelectedValue;
            string customerName = txtUpdateCustomerName.Text;
            string phoneNumber = txtUpdateCustomerPhone.Text;
            string email = txtUpdateCustomerEmail.Text;

            string query = $"UPDATE Customers " +
                           $"SET CustomerName = '{customerName}', PhoneNumber = '{phoneNumber}', Email = '{email}' " +
                           $"WHERE CustomerID = {customerId}";

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Customer updated successfully!");

            LoadCustomersToDropdown();
            ClearUpdateCustomerFields();
        }



        private void ClearUpdateCustomerFields()
        {
            txtUpdateCustomerName.Text = "";
            txtUpdateCustomerPhone.Text = "";
            txtUpdateCustomerEmail.Text = "";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = (int)comboBoxDeleteCustomer.SelectedValue;

            string query = $"DELETE FROM Customers WHERE CustomerID = {customerId}";

            DatabaseHelper db = new DatabaseHelper();
            db.ExecuteNonQuery(query);

            MessageBox.Show("Customer deleted successfully!");

            LoadCustomersToDropdown();
        }
    }
}
