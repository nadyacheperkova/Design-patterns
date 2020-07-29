using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class OrderCommand : ICommand
    {
        private IProduct product;
        public OrderCommand(IProduct product)
        {
            this.product = product;
        }

        public string Execute()
        {
           return product.Order();
        }
    }
}
