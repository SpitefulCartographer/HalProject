using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HalProject.Classes;

namespace HalProject
{
    public partial class OrderForm : Form
    {
        MainForm MainFormRef;

        public OrderForm(MainForm mf)
        {
            InitializeComponent();
            MainFormRef = mf;
        }

        private void ClearItemFields()
        {
            itemNameTextbox.Clear();
            itemUrlTextbox.Clear();
            itemQuantityTextbox.Clear();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            bool x = int.TryParse(itemQuantityTextbox.Text, out int quantity);

            // This runs if there is an error when parsing the Item quantity field. 
            // (e.g. you enter anything but an integer)
            if (!x)
            {
                itemQuantityTextbox.Clear();
                MessageBox.Show("Please enter an integer in your quantity field.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Item i = new Item(itemNameTextbox.Text, itemUrlTextbox.Text, quantity);

            itemListbox.Items.Add(i);

            ClearItemFields();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            itemListbox.Items.Remove(itemListbox.SelectedItem);
            ClearItemFields();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            itemListbox.Items.Clear();
        }

        private void ItemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the selected item is removed from the list, it sets the SelectedIndex to -1.
            // This is to prevent NullReferenceException after removing items from the list.
            if (itemListbox.SelectedIndex != -1)
            {
                Item i = (Item)itemListbox.SelectedItem;
                itemNameTextbox.Text = i.Name;
                itemUrlTextbox.Text = i.Url;
                itemQuantityTextbox.Text = i.Quantity.ToString();
            }
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
            decimal.TryParse(priceTextbox.Text, out decimal price);
            int.TryParse(printEtaTextbox.Text, out int eta);

            List<Item> list = itemListbox.Items.Cast<Item>().ToList();

            MainFormRef.AddOrder(new Order(recipientTextbox.Text, price, eta, printerTextbox.Text, list));

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
