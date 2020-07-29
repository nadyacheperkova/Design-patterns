using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Cheese : PizzaToppings
    {
        public Cheese(IPizza p) : base(p)
        {

        }
        public override string getName()
        {
            return base.getName() + " with cheese,";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 1.90;
        }
    }
}
