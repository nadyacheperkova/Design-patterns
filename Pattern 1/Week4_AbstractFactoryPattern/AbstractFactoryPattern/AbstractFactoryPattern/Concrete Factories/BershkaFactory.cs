using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class BershkaFactory : IClothingFactory
    {
        public IJacket CreateJacket()
        {
            return new BasicJacket();
        }

        public IPants CreatePants()
        {
            return new BasicPants();
        }

        public ITshirt CreateTshirt()
        {
            return new BasicTshirt();
        }

        public string GetFactoryType()
        {
            return "Basic Clothes";
        }
    }
}
