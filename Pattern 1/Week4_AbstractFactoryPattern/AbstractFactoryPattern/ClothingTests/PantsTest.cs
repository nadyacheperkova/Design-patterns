using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryPattern;

namespace ClothingTests
{
    [TestClass]
    public class PantsTest
    {
        [TestMethod]
        public void TestBasicPants()
        {
            // Given
            IPants basicPants = new BasicPants();

            // When 
            var price = basicPants.GetPrice();
            var type = basicPants.GetProduct();

            // Then 
            Assert.AreEqual(15.50, price);
            Assert.AreEqual("Basic Pants", type);
        }

        [TestMethod]
        public void TestSportPants()
        {
            // Given
            IPants sportPants = new SportPants();

            // When
            var price = sportPants.GetPrice();
            var type = sportPants.GetProduct();

            // Then
            Assert.AreEqual(25.50, price);
            Assert.AreEqual("Sport Pants", type);
        }

        [TestMethod]
        public void TestFormalPants()
        {
            // Given
            IPants formalPants = new FormalPants();

            // When
            var price = formalPants.GetPrice();
            var type = formalPants.GetProduct();

            // Then
            Assert.AreEqual(35.50, price);
            Assert.AreEqual("Formal Pants", type);
        }
    }
}
