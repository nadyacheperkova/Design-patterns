using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class CheesyCrustDough : IPizza
    {
        public string getName()
        {
            return "Cheesy crust dough";
        }

        public double GetPrice()
        {
            return 8.90;
        }
    }
}
