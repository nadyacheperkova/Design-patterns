using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SportJacket : IJacket
    {
        public double GetPrice()
        {
            return 35.50;
        }

        public string GetProduct()
        {
            return "Sport Jacket";
        }
    }
}
