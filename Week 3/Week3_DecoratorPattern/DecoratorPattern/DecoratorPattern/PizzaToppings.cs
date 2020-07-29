using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class PizzaToppings : IPizza
    {
        private IPizza pizza;

        public PizzaToppings(IPizza p)
        {
            this.pizza = p;
        }

       virtual public string getName()
        {
            return pizza.getName();
        }
        virtual public double GetPrice()
        {
            return pizza.GetPrice();
        }
    }
}
