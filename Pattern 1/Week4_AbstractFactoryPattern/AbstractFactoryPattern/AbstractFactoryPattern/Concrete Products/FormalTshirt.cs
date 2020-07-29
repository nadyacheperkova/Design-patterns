using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FormalTshirt : ITshirt
    {
        public double GetPrice()
        {
            return 15.50;
        }

        public string GetProduct()
        {
            return "Formal T-shirt";
        }
    }
}
