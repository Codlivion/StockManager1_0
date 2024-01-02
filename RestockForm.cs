using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StockManager1_0
{
    public partial class RestockForm : Form
    {
        MainForm mainForm;

        Font stdFont = new Font("Arial", 12);
        int scrollPos = 0;
        int lineLimit = 16;
        int boxHeight = 27;
        List<Product> products = new List<Product>();

        Mode mode = new Mode();
        enum Mode { Quantity, Price, Cost }

        string connectionString => mainForm.connectionString;

        public RestockForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            mode = Mode.Quantity;
            products = mainForm.GetProducts();
            editPanel.MouseWheel += EditPanelWheel;
        }

        public void DrawEditPanel(object sender, PaintEventArgs e)
        {
            if (products.Count == 0) return;

            int endIndex = Math.Min(scrollPos + lineLimit, products.Count);
            for (int i = scrollPos; i < endIndex; i++)
            {
                string pValue = "";
                switch (mode)
                {
                    case Mode.Quantity: pValue = products[i].Quantity.ToString(); break;
                    case Mode.Price: pValue = products[i].Price.ToString(); break;
                    case Mode.Cost: pValue = products[i].Cost.ToString(); break;
                }

                int iPos = i - scrollPos;
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(5, iPos * boxHeight + 5, 150, boxHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(155, iPos * boxHeight + 5, 50, boxHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(205, iPos * boxHeight + 5, 145, boxHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(350, iPos * boxHeight + 5, 50, boxHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(400, iPos * boxHeight + 5, 150, boxHeight));
                e.Graphics.DrawString(products[i].Name, stdFont, Brushes.Black, 10, iPos * boxHeight + 10);
                e.Graphics.DrawString("<", stdFont, Brushes.Black, 175, iPos * boxHeight + 10);
                e.Graphics.DrawString(pValue.ToString(), stdFont, Brushes.Black, 275, iPos * boxHeight + 10);
                e.Graphics.DrawString(">", stdFont, Brushes.Black, 370, iPos * boxHeight + 10);
                if (products[i].Changed) e.Graphics.DrawString("UPDATE", stdFont, Brushes.Black, 440, iPos * boxHeight + 10);
            }
        }

        public void EditPanelClick(object sender, MouseEventArgs e)
        {
            int i = (e.Y / boxHeight) + scrollPos;
            if (i < products.Count)
            {
                if (e.X > 155 && e.X < 205)
                {
                    switch (mode)
                    {
                        case Mode.Quantity: products[i].Quantity--; break;
                        case Mode.Price: products[i].Price--; break;
                        case Mode.Cost: products[i].Cost--; break;
                    }
                    products[i].Changed = true;
                }
                if (e.X > 350 && e.X < 400)
                {
                    switch (mode)
                    {
                        case Mode.Quantity: products[i].Quantity++; break;
                        case Mode.Price: products[i].Price++; break;
                        case Mode.Cost: products[i].Cost++; break;
                    }
                    products[i].Changed = true;
                }

                if (e.X > 400 && e.X < 550)
                {
                    if (products[i].Changed)
                    {
                        UpdateProduct(i);
                    }
                }

                editPanel.Invalidate();
            }
        }

        public void EditPanelWheel(object sender, MouseEventArgs e)
        {
            scrollPos -= e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            if (scrollPos < 0) scrollPos = 0;
            if (products.Count >= lineLimit)
            {
                if (scrollPos > products.Count - lineLimit) scrollPos = products.Count - lineLimit;
            }
            else scrollPos = 0;
            editPanel.Invalidate();
        }

        public void QuantityButtonClick(object sender, EventArgs e)
        {
            mode = Mode.Quantity;
            editPanel.Invalidate();
        }

        public void PriceButtonClick(object sender, EventArgs e)
        {
            mode = Mode.Price;
            editPanel.Invalidate();
        }

        public void CostButtonClick(object sender, EventArgs e)
        {
            mode = Mode.Cost;
            editPanel.Invalidate();
        }

        public void UpdateProduct(int i)
        {
            string cmd = "UPDATE Product SET Quantity = @Q, Price = @P, Cost = @C WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@ID", products[i].ID);
                    command.Parameters.AddWithValue("@Q", products[i].Quantity);
                    command.Parameters.AddWithValue("@P", products[i].Price);
                    command.Parameters.AddWithValue("@C", products[i].Cost);
                    command.ExecuteNonQuery();
                }
            }
            products[i].Changed = false;
            editPanel.Invalidate();
        }

        public void RemoveProduct(int i) //Not implemented yet!
        {
            string cmd = "DELETE FROM Product WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.Parameters.AddWithValue("@ID", products[i].ID);
                    command.ExecuteNonQuery();
                }
            }
            products.RemoveAt(i);
            editPanel.Invalidate();
        }

        public void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Product
    {
        public int ID;
        public string Name;
        public int Quantity;
        public double Price;
        public double Cost;
        public bool Changed;

        public Product(int id, string name, int q, double p, double c)
        { ID = id; Name = name; Quantity = q; Price = p; Cost = c; }
    }
}