using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PriceInCents { get; set; }

        public Item(string name, int priceInCents)
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public Double PriceInDollars()
        {
            return Convert.ToDouble(PriceInCents) / 100;
        }
    }
}
