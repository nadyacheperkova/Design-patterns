using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mushrooms : PizzaToppings
    {
        public Mushrooms(IPizza p) :base(p)
        {

        }
        public override string getName()
        {
            return base.getName() + " with mushrooms,";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.90;
        }
    }
}
