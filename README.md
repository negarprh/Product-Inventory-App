🚀 Product Inventory Management System
A Windows Forms application built with C# .NET and SQL Server to manage products, customers, and sales seamlessly.

🎯 About the Project
The Product Inventory Management System simplifies the process of managing products, customers, and sales. Designed with a clean UI and intuitive workflows, this application enables quick record addition, updates, deletion, and product search functionality.

✨ Key Features
🔹 Customer Management: Add, update, and delete customer records.
🔹 Product Management: Manage product details, including category, price, and stock levels.
🔹 Sales Management: Track sales and monitor inventory.
🔹 Search Functionality: Quickly search products by category with dropdown filters.
🔹 Low Stock Alerts: Get notified when product stock levels run low.
🛠️ Tech Stack
Frontend: Windows Forms (WinForms)
Backend: C# .NET
Database: SQL Server
IDE: Visual Studio
📸 Screenshots
1. Customer Management

2. Product Management

3. Search Products by Category

⚙️ Installation
Follow these steps to set up and run the project locally:

1. Clone the Repository
bash
Copy code
git clone https://github.com/yourusername/product-inventory-management.git
cd product-inventory-management
2. Set Up SQL Server Database
Open SQL Server Management Studio (SSMS).
Execute the provided DatabaseScript.sql to create necessary tables and insert sample data.
3. Configure the Connection String
Update the connection string in DatabaseHelper.cs:

csharp
Copy code
"Server=YOUR_SERVER_NAME;Database=InventoryDB;Trusted_Connection=True;"
4. Build and Run the Project
Open the solution in Visual Studio.
Build the project using Ctrl + Shift + B.
Run the project with F5.
🚀 Usage
Manage Customers

Add new customers with name, phone number, and email.
Update or delete existing customers.
Manage Products

Add products with details like name, category, price, and stock.
Update product details or delete products.
Search Products

Use the Category dropdown to filter and view products in a grid.
Track Sales and Inventory

Monitor sales records.
View low-stock alerts for proactive restocking.
📂 Project Structure
bash
Copy code
ProductInventoryManagement/
├── DatabaseScript.sql       # SQL script for database setup
├── DatabaseHelper.cs        # Helper class for database operations
├── Form1.cs                 # Main application logic
├── Form1.Designer.cs        # UI designer file
├── ProductInventoryApp.sln  # Visual Studio solution file
└── README.md                # Project documentation
🗄️ Database Schema
Table Name	Columns
Customers	CustomerID, CustomerName, PhoneNumber, Email
Products	ProductID, ProductName, Category, Price, StockLevel
Sales	SaleID, ProductID, Quantity, Date
🚧 Future Enhancements
📊 Generate reports for sales and inventory.
🔔 Add real-time notifications for critical stock levels.
🌐 Implement data export to Excel/PDF.
🛡 Add user authentication for enhanced security.
👤 Author
Your Name

💼 LinkedIn: Your LinkedIn
💻 GitHub: Your GitHub
📧 Email: youremail@example.com
⭐ Show Your Support
If you found this project useful, please ⭐ star the repository on GitHub!
Contributions, feedback, and suggestions are always welcome! 🚀
