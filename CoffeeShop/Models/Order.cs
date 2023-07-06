using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items;

        public Order()
        {
            Items = new List<Item>();
        }

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
            //Math.Round(Total, 2);
            return Total;
        }

        public string ItemsList()
        {
            return string.Join(", ", Items);
        }
    }
}
