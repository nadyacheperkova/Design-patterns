using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryPattern;

namespace ClothingTests
{
    [TestClass]
    public class JacketTest
    {
        [TestMethod]
        public void TestBasicJacket()
        {
            // Given
            IJacket basicJacket = new BasicJacket();

            // When 
            var price = basicJacket.GetPrice();
            var type = basicJacket.GetProduct();

            // Then 
            Assert.AreEqual(25.50, price);
            Assert.AreEqual("Basic Jacket", type);
        }

        [TestMethod]
        public void TestSportJacket()
        {
            // Given
            IJacket sportJacket = new SportJacket();

            // When 
            var price = sportJacket.GetPrice();
            var type = sportJacket.GetProduct();

            // Then 
            Assert.AreEqual(35.50, price);
            Assert.AreEqual("Sport Jacket", type);
        }

        [TestMethod]
        public void TestFormalJacket()
        {
            // Given
            IJacket formalJacket = new FormalJacket();

            // When 
            var price = formalJacket.GetPrice();
            var type = formalJacket.GetProduct();

            // Then 
            Assert.AreEqual(55.50, price);
            Assert.AreEqual("Formal Jacket", type);
        }
    }
}

