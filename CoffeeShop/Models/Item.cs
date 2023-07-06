using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int PriceInCents { get; set; }

        public Item(string name, int priceInCents)
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public Double PriceInDollars()
        {
            Double priceInDollars;
            Convert.ToDouble(PriceInCents);
            priceInDollars = PriceInCents / 100;

            Math.Round(priceInDollars, 2);
            return priceInDollars;
        }
    }
}
