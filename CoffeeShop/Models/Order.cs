using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Order
    {
        public List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Double Total()
        {
            Double Total = 0;
            foreach (var item in Items)
            {
                Total = Total + item.PriceInDollars();
            }
            Math.Round(Total, 2);
            return Total;
        }
    }
}
