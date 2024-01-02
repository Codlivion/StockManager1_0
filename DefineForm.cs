using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockManager1_0
{
    public partial class DefineForm : Form
    {
        MainForm mainForm;

        List<string> pNames = new List<string>();
        List<string> bNames = new List<string>();
        List<string> mNames = new List<string>();
        List<string> sNames = new List<string>();

        string connectionString => mainForm.connectionString;

        public DefineForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;

            List<KeyValuePair<string, int>> pairs = mainForm.GetIDNames("Product");
            foreach (var pair in pairs)
            { pNames.Add(pair.Key); }

            List<KeyValuePair<string, int>> bPairs = mainForm.GetIDNames("Brand");
            pBrandBox.DataSource = bPairs;
            pBrandBox.DisplayMember = "Key";
            pBrandBox.ValueMember = "Value";
            foreach (var pair in bPairs)
            { bNames.Add(pair.Key); }

            List<KeyValuePair<string, int>> mPairs = mainForm.GetIDNames("Manufacturer");
            bManufacturerBox.DataSource = mPairs;
            bManufacturerBox.DisplayMember = "Key";
            bManufacturerBox.ValueMember = "Value";
            foreach (var pair in mPairs)
            { mNames.Add(pair.Key); }

            List<KeyValuePair<string, int>> sPairs = mainForm.GetIDNames("Supplier");
            bSupplierBox.DataSource = sPairs;
            bSupplierBox.DisplayMember = "Key";
            bSupplierBox.ValueMember = "Value";
            foreach (var pair in sPairs)
            { sNames.Add(pair.Key); }
        }

        public void AddProductClick(object sender, EventArgs e)
        {
            if (pNameBox.Text == "")
            { MessageBox.Show("Product Name is not defined!"); return; }
            if (pNames.Contains(pNameBox.Text))
            { MessageBox.Show("Product Name is a duplicate!"); return; }
            if (pBrandBox.SelectedItem == null)
            { MessageBox.Show("Product Brand is not defined!"); return; }
            if (pPriceBox.Value == 0 || pCostBox.Value == 0)
            { MessageBox.Show("Product Price/Cost is not defined!"); return; }
            if (pPriceBox.Value < pCostBox.Value)
            {
                string message = "Product Sell Price is lesser than Product Buy Cost. Do you want to proceed?";
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = "INSERT INTO PRODUCT (Name, BrandID, Quantity, Price, Cost)" +
                    "VALUES (@Name, @BrandID, @Quantity, @Price, @Cost)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", pNameBox.Text);
                    command.Parameters.AddWithValue("@BrandID", pBrandBox.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", 0);
                    command.Parameters.AddWithValue("@Price", pPriceBox.Value);
                    command.Parameters.AddWithValue("@Cost", pCostBox.Value);
                    command.ExecuteNonQuery();
                }
            }
            pNames.Add(pNameBox.Text);
            pNameBox.Clear();
            pPriceBox.Value = pPriceBox.Minimum;
            pCostBox.Value = pCostBox.Minimum;
        }

        public void AddBrandClick(object sender, EventArgs e)
        {
            if (bNameBox.Text == "")
            { MessageBox.Show("Brand Name is not defined!"); return; }
            if (bNames.Contains(bNameBox.Text))
            { MessageBox.Show("Brand Name is a duplicate!"); return; }
            if (bManufacturerBox.SelectedItem == null || bSupplierBox.SelectedItem == null)
            { MessageBox.Show("Brand Manufacturer/Supplier is not defined!"); return; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = "INSERT INTO BRAND (Name, ManufacturerID, SupplierID)" +
                    "VALUES (@Name, @ManufacturerID, @SupplierID)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", bNameBox.Text);
                    command.Parameters.AddWithValue("@ManufacturerID", bManufacturerBox.SelectedValue);
                    command.Parameters.AddWithValue("@SupplierID", bSupplierBox.SelectedValue);
                    command.ExecuteNonQuery();
                }
            }
            pBrandBox.DataSource = mainForm.GetIDNames("Brand");
            bNames.Add(bNameBox.Text);
            bNameBox.Clear();
        }

        public void AddManufacturerClick(object sender, EventArgs e)
        {
            if (mNameBox.Text == "")
            { MessageBox.Show("Manufacturer Name is not defined!"); return; }
            if (mNames.Contains(mNameBox.Text))
            { MessageBox.Show("Manufacturer Name is a duplicate!"); return; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = "INSERT INTO Manufacturer (Name, Contact)" +
                    "VALUES (@Name, @Contact)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", mNameBox.Text);
                    command.Parameters.AddWithValue("@Contact", mContactBox.Text);
                    command.ExecuteNonQuery();
                }
            }
            bManufacturerBox.DataSource = mainForm.GetIDNames("Manufacturer");
            mNames.Add(mNameBox.Text);
            mNameBox.Clear();
            mContactBox.Clear();
        }

        public void AddSupplierClick(object sender, EventArgs e)
        {
            if (sNameBox.Text == "")
            { MessageBox.Show("Supplier Name is not defined!"); return; }
            if (sNames.Contains(sNameBox.Text))
            { MessageBox.Show("Supplier Name is a duplicate!"); return; }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmd = "INSERT INTO Supplier (Name, Contact)" +
                    "VALUES (@Name, @Contact)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@Name", sNameBox.Text);
                    command.Parameters.AddWithValue("@Contact", sContactBox.Text);
                    command.ExecuteNonQuery();
                }
            }
            bSupplierBox.DataSource = mainForm.GetIDNames("Supplier");
            sNames.Add(sNameBox.Text);
            sNameBox.Clear();
            sContactBox.Clear();
        }

        public void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}