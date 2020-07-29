using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class BuyCommand : ICommand
    {
        private IProduct product;
        public BuyCommand(IProduct product)
        {
            this.product = product;
        }

        public string Execute()
        {
            return product.Buy();
        }
    }
}
