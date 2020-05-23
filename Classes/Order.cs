using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalProject.Classes
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string Recipient { get; set; }
        public decimal Price { get; set; }
        public int PrintETA { get; set; }
        public string Printer { get; set; }
        StatusCode StatusCode { get; set; }
        public List<Item> ItemsList;

        /// <summary>
        /// Constructor for user-created orders.
        /// This is usually called when the user creates an order using OrderForm.
        /// Does NOT include an id since the database will automatically assign it one.
        /// </summary>
        public Order(string r, decimal p, int eta, string x, List<Item> list)
        {
            Recipient = r;
            Price = p;
            PrintETA = eta;
            Printer = x;
            ItemsList = list;
            StatusCode = StatusCode.Pending;
        }

        /// <summary>
        /// Constructor for orders being loaded from the database.
        /// This is called for every order in the database when MainForm is loaded.
        /// </summary>
        public Order(int id, string r, decimal p, int eta, string x, List<Item> list, int s)
        {
            OrderNumber = id;
            Recipient = r;
            Price = p;
            PrintETA = eta;
            Printer = x;
            ItemsList = list;
            StatusCode = (StatusCode) s;
        }

    }

    enum StatusCode : byte
    {
        None,       // Default value. Should not occur naturally.
        Disabled,   // Has errors or has been manually disabled by the user.
        Pending,    // Is waiting to be printed; Default for newly created orders.
        Active,     // Is currently printing.
        Ready,      // Has been printed and is ready to be delivered.
        Fulfilled   // Has been successfully delivered.
    }
}
