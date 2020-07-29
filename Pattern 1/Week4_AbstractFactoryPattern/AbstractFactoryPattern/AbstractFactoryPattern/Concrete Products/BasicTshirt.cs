using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
   public class BasicTshirt : ITshirt
    {
        public double GetPrice()
        {
            return 5.50;
        }

        public string GetProduct()
        {
            return "Basic T-shirt";
        }
    }
}
