using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class StradivariusFactory : IClothingFactory
    {
        public IJacket CreateJacket()
        {
            return new SportJacket();
        }

        public IPants CreatePants()
        {
            return new SportPants();
        }

        public ITshirt CreateTshirt()
        {
            return new SportTshirt();
        }

        public string GetFactoryType()
        {
            return "Sport Clothes";
        }
    }
}
