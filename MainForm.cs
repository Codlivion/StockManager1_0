using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockManager1_0
{
    public partial class MainForm : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\NonSerializedStockDB.mdf;Integrated Security=True";

        Font stdFont = new Font("Arial", 12);
        int scrollPos = 0;
        int lineLimit = 16;
        List<string> outputText = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            outputPanel.MouseWheel += OutputWheel;
        }

        public void DrawOutput(object sender, PaintEventArgs e)
        {
            if (outputText.Count == 0) return;

            int endIndex = Math.Min(scrollPos + lineLimit, outputText.Count);
            for (int i = scrollPos; i < endIndex; i++)
            {
                int iPos = i - scrollPos;
                e.Graphics.DrawString(outputText[i], stdFont, Brushes.Black, 10, iPos * 22 + 10);
            }
        }

        public void OutputWheel(object sender, MouseEventArgs e)
        {
            scrollPos -= e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            if (scrollPos < 0) scrollPos = 0;
            if (outputText.Count >= lineLimit)
            {
                if (scrollPos > outputText.Count - lineLimit) scrollPos = outputText.Count - lineLimit;
            }
            else scrollPos = 0;
            outputPanel.Invalidate();
        }

        public void DefineButtonClick(object sender, EventArgs e)
        {
            DefineForm form = new DefineForm(this);
            form.ShowDialog();
        }

        public void StocksButtonClick(object sender, EventArgs e)
        {
            outputText.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Product JOIN Brand ON Product.BrandID = Brand.ID " +
                    "JOIN Manufacturer ON Brand.ManufacturerID = Manufacturer.ID JOIN Supplier ON Brand.SupplierID = Supplier.ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(1);
                            string brandName = reader.GetString(7);
                            int quantity = reader.GetInt32(3);
                            double price = (double)reader.GetDecimal(4);
                            double cost = (double)reader.GetDecimal(5);
                            string manufacturerName = reader.GetString(11);
                            string supplierName = reader.GetString(14);
                            outputText.Add($"Product: {productName} | Brand: {brandName} | Manufacturer: {manufacturerName} | Supplier: {supplierName}");
                            outputText.Add($"(Quantity: {quantity} | Unit Price: {price} | Stock Price: {cost})");
                        }
                    }
                }
            }
            outputPanel.Invalidate();
        }

        public void RestockButtonClick(object sender, EventArgs e)
        {
            RestockForm form = new RestockForm(this);
            form.ShowDialog();
        }

        public void SimulationButtonClick(object sender, EventArgs e)
        {
            outputText.Clear();
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Name, Quantity, Price, Cost FROM Product";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader =command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int quantity = reader.GetInt32(2);
                            double price = (double)reader.GetDecimal(3);
                            double cost = (double)reader.GetDecimal(4);
                            products.Add(new Product(id, name, quantity, price, cost));
                        }
                    }
                }
            }
            if (products.Count > 0)
            {
                foreach (Product product in products)
                {
                    if (product.Quantity > 0)
                    {
                        Random random = new Random();
                        int r = random.Next(product.Quantity + 1);
                        if (r > 0)
                        {
                            product.Quantity -= r;
                            double cash = product.Price * r;
                            product.Changed = true;
                            outputText.Add($"{r} units of {product.Name} was sold for ${cash}, {product.Quantity} units remain");
                        }
                    }
                }

                foreach (Product product in products)
                {
                    if (product.Changed)
                    {
                        string cmd = "UPDATE Product SET Quantity = @Q WHERE ID = @ID";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(cmd, connection))
                            {
                                command.Parameters.AddWithValue("@ID", product.ID);
                                command.Parameters.AddWithValue("@Q", product.Quantity);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            else MessageBox.Show("There were no Products in the Database!");

            outputPanel.Invalidate();
        }

        public List<KeyValuePair<string, int>> GetIDNames(string table)
        {
            if (table != "Product" && table != "Brand" && table != "Manufacturer" && table != "Supplier")
            { MessageBox.Show("Invalid request!"); return null; }
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = $"SELECT ID, Name FROM {table}";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            result.Add(new KeyValuePair<string, int>(name, id));
                        }
                    }
                }
            }
            return result;
        }

        public List<Product> GetProducts()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Product";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int quantity = reader.GetInt32(3);
                            double price = (double)reader.GetDecimal(4);
                            double cost = (double)reader.GetDecimal(5);
                            Product p = new Product(id, name, quantity, price, cost);
                            result.Add(p);
                        }
                    }
                }
            }
            return result;
        }
    }
}