using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandPattern;

namespace UnitTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestTshirt()
        {
            // Given
            IProduct tshirt = new Tshirt();
            PurchaseController controller = new PurchaseController();
            ICommand order = new OrderCommand(tshirt);
            controller.InsertCommand(order);
            ICommand buy = new BuyCommand(tshirt);
            controller.InsertCommand(buy);

            // When 
            var order_t = order.Execute();
            var buy_t = buy.Execute();

            // Then 
            Assert.AreEqual("T-shirt", order_t);
            Assert.AreEqual("19.99", buy_t);
        }

        [TestMethod]
        public void TestPants()
        {
            // Given
            IProduct pants = new Pants();
            PurchaseController controller = new PurchaseController();
            ICommand order = new OrderCommand(pants);
            controller.InsertCommand(order);
            ICommand buy = new BuyCommand(pants);
            controller.InsertCommand(buy);

            // When 
            var order_t = order.Execute();
            var buy_t = buy.Execute();

            // Then 
            Assert.AreEqual("Pants", order_t);
            Assert.AreEqual("29.99", buy_t);
        }

        [TestMethod]
        public void TestShoes()
        {
            // Given
            IProduct shoes = new Shoes();
            PurchaseController controller = new PurchaseController();
            ICommand order = new OrderCommand(shoes);
            controller.InsertCommand(order);
            ICommand buy = new BuyCommand(shoes);
            controller.InsertCommand(buy);

            // When 
            var order_t = order.Execute();
            var buy_t = buy.Execute();

            // Then 
            Assert.AreEqual("Shoes", order_t);
            Assert.AreEqual("39.99", buy_t);
        }
    }
}
