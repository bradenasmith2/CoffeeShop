using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order, Item item)
        {
            order.AddItem(item);
            Orders.Add(order);
        }

        public void ItemsOrdered(Order order)
        {
            Console.WriteLine(order.Items.Select(e => e.Name).Distinct());
        }

        public Double TotalSpent(Order order)
        {
            Double total = 0;
            foreach (var item in order.Items)
            {
                total = item.PriceInDollars() + total;
            }

            Math.Round(total, 2);
            return total;
        }
    }
}
