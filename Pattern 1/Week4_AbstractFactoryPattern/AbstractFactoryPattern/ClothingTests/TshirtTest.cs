using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryPattern;

namespace ClothingTests
{
    [TestClass]
    public class TshirtTest
    {
       
        [TestMethod]
        public void TestBasicTShirt()
        {
            // Given
            ITshirt basicTshirt = new BasicTshirt();

            // When 
            var price = basicTshirt.GetPrice();
            var type = basicTshirt.GetProduct();

            // Then 
            Assert.AreEqual(5.50, price);
            Assert.AreEqual("Basic T-shirt", type);
        }

        [TestMethod]
        public void TestSportTShirt()
        {
            // Given
            ITshirt sportTshirt = new SportTshirt();

            // When 
            var price = sportTshirt.GetPrice();
            var type = sportTshirt.GetProduct();

            // Then 
            Assert.AreEqual(10.50, price);
            Assert.AreEqual("Sport T-shirt", type);
        }

        [TestMethod]
        public void TestFormalTShirt()
        {
            // Given
            ITshirt formalTshirt = new FormalTshirt();

            // When 
            var price = formalTshirt.GetPrice();
            var type = formalTshirt.GetProduct();

            // Then 
            Assert.AreEqual(15.50, price);
            Assert.AreEqual("Formal T-shirt", type);
        }
    }
}
