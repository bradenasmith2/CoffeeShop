using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop
{
    public class Item_Test
    {
        [Fact]
        public void Item_Constructor_SetsAppropriateValues()
        {
            Item item = new Item("item one", 200);

            Assert.Equal("item one", item.Name);
            Assert.Equal(200, item.PriceInCents);
        }

        [Fact]
        public void PriceInDollars_PerformsProperMath()
        {
            Item item = new Item("item one", 200);

            Assert.Equal(2, item.PriceInDollars());
        }
    }
}