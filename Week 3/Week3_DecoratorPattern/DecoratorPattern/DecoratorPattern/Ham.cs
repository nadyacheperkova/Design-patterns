using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
     class Ham : PizzaToppings
    {
        public Ham(IPizza p) 
            :base(p)
        {

        }
        public override string getName()
        {
            return base.getName() + " with ham,";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 2.90;
        }
    }
}
