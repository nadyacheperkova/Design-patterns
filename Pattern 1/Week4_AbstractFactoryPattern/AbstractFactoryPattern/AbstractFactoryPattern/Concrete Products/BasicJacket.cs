using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class BasicJacket : IJacket
    {
        public double GetPrice()
        {
            return 25.50;
        }

        public string GetProduct()
        {
            return "Basic Jacket";
        }
    }
}
