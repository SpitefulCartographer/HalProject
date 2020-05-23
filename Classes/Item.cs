using System;

namespace HalProject.Classes
{
    public class Item
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Quantity { get; set; }

        public Item(string n, string url, int q)
        {
            Name = n;
            Url = url;
            Quantity = q;
        }

    }
}
