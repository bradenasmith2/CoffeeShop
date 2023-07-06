
namespace CoffeeShop
{
    public class Customer_Test
    {
        [Fact]
        public void Customer_Constructor_SetsProperValue()
        {
            Customer customer = new("John Doe");
            List<Order> orders = new List<Order>();

            Assert.Empty(orders);
            Assert.Equal("John Doe", customer.Name);

        }

        public void AddOrder_AddsProperOrderToList()
        {

        }

        public void ItemsOrdered_SelectsDistinctItemsInListOfOrders()
        {

        }


    }
}