using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ZaraFactory : IClothingFactory
    {
        public IJacket CreateJacket()
        {
            return new FormalJacket();
        }

        public IPants CreatePants()
        {
            return new FormalPants();
        }

        public ITshirt CreateTshirt()
        {
            return new FormalTshirt();
        }

        public string GetFactoryType()
        {
            return "Formal Clothes";
        }
    }
}
