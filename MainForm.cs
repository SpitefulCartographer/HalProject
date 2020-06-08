using System;
using System.IO;
using System.Windows.Forms;
using System.Data;

using HalProject.Classes;
using System.Collections.Generic;

namespace HalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddOrder(Order o)
        {
            orderListbox.Items.Add(o);
            DatabaseAccess.InsertOrder(o);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("database.db")) DatabaseAccess.InitializeDatabase();

            DataTable ordersData = DatabaseAccess.SelectAllOrders();
            
            foreach (DataRow row in ordersData.Rows)
            {
                int id      = Convert.ToInt32(row["Order_Number"]);
                string r    = Convert.ToString(row["Recipient"]);
                decimal p   = Convert.ToDecimal(row["Price"]);
                int eta     = Convert.ToInt32(row["Print_ETA"]);
                string x    = Convert.ToString(row["Printer"]);
                int s       = Convert.ToInt32(row["Status_Code"]);

                List<Item> list = new List<Item>();

                DataTable itemsData = DatabaseAccess.SelectAllItemsInOrder(id);
                foreach (DataRow row2 in itemsData.Rows)
                {
                    string n    = Convert.ToString(row2["Item_Name"]);
                    string url  = Convert.ToString(row2["Item_URL"]);
                    int q       = Convert.ToInt32(row2["Item_Quantity"]);

                    list.Add(new Item(n, url, q));
                }

                orderListbox.Items.Add(new Order(id, r, p, eta, x, list, s));
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            using (OrderForm form = new OrderForm(this))
            {
                form.ShowDialog();
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (orderListbox.SelectedIndex != -1)
            {

                orderListbox.Items.Remove(orderListbox.SelectedItem);
            } 
        }

        /// <summary>
        /// Method for formatting DisplayMembers in the OrderListbox.
        /// Displays order number and recipient information.
        /// </summary>
        private void orderListbox_Format(object sender, ListControlConvertEventArgs e)
        {
            int number = ((Order)e.ListItem).OrderNumber;
            string recipient = ((Order)e.ListItem).Recipient;
            e.Value = "Order # " + number + "; " + recipient;
        }

        private void orderListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderListbox.SelectedIndex != -1)
            {
                Order o = (Order)orderListbox.SelectedItem;
                recipientDisplay.Text = o.Recipient;
                priceDisplay.Text = Convert.ToString(o.Price);
                printEtaDisplay.Text = Convert.ToString(o.PrintETA);
                printerDisplay.Text = Convert.ToString(o.Printer);
                statusDisplay.Text = Convert.ToString(o.StatusCode);

                List<Item> itemData = o.ItemsList;
                itemListbox.DataSource = itemData;
            }
        }

        private void itemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the selected item is removed from the list, it sets the SelectedIndex to -1.
            // This is to prevent NullReferenceException after removing items from the list.
            if (itemListbox.SelectedIndex != -1)
            {
                Item i = (Item)itemListbox.SelectedItem;
                itemNameDisplay.Text = i.Name;
                itemUrlDisplay.Text = i.Url;
                itemQuantityDisplay.Text = Convert.ToString(i.Quantity);
            }
        }


    }
}
