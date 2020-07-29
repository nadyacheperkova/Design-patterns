using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class FreshPanDough : IPizza
    {
        public string getName()
        {
            return "Fresh pan dough";
        }

        public double GetPrice()
        {
            return 7.90;
        }
    }
}
