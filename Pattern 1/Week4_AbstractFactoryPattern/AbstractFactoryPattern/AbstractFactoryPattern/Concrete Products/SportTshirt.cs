using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class SportTshirt : ITshirt
    {
        public double GetPrice()
        {
            return 10.50;
        }

        public string GetProduct()
        {
            return "Sport T-shirt";
        }
    }
}
