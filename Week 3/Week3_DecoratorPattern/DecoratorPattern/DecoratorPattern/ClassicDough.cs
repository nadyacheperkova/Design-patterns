using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ClassicDough : IPizza
    {
        public string getName()
        {
            return "Classic dough";
        }

        public double GetPrice()
        {
            return 6.90;
        }
    }
}
