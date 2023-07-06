namespace CoffeeShop
{
    public class Order_Test
    {
        [Fact]
        public void Order_Constructor_SetsProperValues()
        {
            Order order = new Order();
            List <Item> items = new List<Item>();

            Assert.Equal(items, order.Items);
            Assert.Empty(order.Items);
        }

        [Fact]
        public void AddItem_AddsCorrectItem()
        {
            Order order = new Order();
            Item item1 = new Item("item 1", 300);
            Item item2 = new Item("item 2", 400);

            order.Items.Add(item1);
            order.Items.Add(item2);

            Assert.Equal(item1, order.Items[0]);
            Assert.Equal(item2, order.Items[1]);
        }

        [Fact]
        public void Total_AddsCorrectValues()
        {
            Order order = new();
            Item item1 = new("item 1", 400);
            Item item2 = new("item 2", 300);

            order.Items.Add(item1);
            order.Items.Add(item2);

            Assert.Equal(7, order.Total());
        }
    }
}