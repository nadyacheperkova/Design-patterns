using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryPattern;

namespace ClothingTests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void TestZaraFactory()
        {
            // Given
            IClothingFactory zaraFactory = new ZaraFactory();

            // When 
            IJacket jacket = zaraFactory.CreateJacket();
            IPants pants = zaraFactory.CreatePants();
            ITshirt tShirt = zaraFactory.CreateTshirt();
            var factoryType = zaraFactory.GetFactoryType();

            // Then 
            Assert.IsInstanceOfType(jacket, typeof(FormalJacket));
            Assert.IsInstanceOfType(pants, typeof(FormalPants));
            Assert.IsInstanceOfType(tShirt, typeof(FormalTshirt));
            Assert.AreEqual("Formal Clothes", factoryType);
        }

        [TestMethod]
        public void TestBershkaFactory()
        {
            // Given
            IClothingFactory bershkaFactory = new BershkaFactory();

            // When 
            IJacket jacket = bershkaFactory.CreateJacket();
            IPants pants = bershkaFactory.CreatePants();
            ITshirt tShirt = bershkaFactory.CreateTshirt();
            var factoryType = bershkaFactory.GetFactoryType();

            // Then 
            Assert.IsInstanceOfType(jacket, typeof(BasicJacket));
            Assert.IsInstanceOfType(pants, typeof(BasicPants));
            Assert.IsInstanceOfType(tShirt, typeof(BasicTshirt));
            Assert.AreEqual("Basic Clothes", factoryType);
        }

        [TestMethod]
        public void TestStradivariusFactory()
        {
            // Given
            IClothingFactory stradivariusFactory = new StradivariusFactory();

            // When 
            IJacket jacket = stradivariusFactory.CreateJacket();
            IPants pants = stradivariusFactory.CreatePants();
            ITshirt tShirt = stradivariusFactory.CreateTshirt();
            var factoryType = stradivariusFactory.GetFactoryType();

            // Then 
            Assert.IsInstanceOfType(jacket, typeof(SportJacket));
            Assert.IsInstanceOfType(pants, typeof(SportPants));
            Assert.IsInstanceOfType(tShirt, typeof(SportTshirt));
            Assert.AreEqual("Sport Clothes", factoryType);
        }
    }
}
