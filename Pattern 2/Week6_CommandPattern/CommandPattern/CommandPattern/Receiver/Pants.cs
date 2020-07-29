using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Pants : IProduct
    {
        public string Order()
        {
            return "Pants";
        }

        public string Buy()
        {
            return "29.99";
        }
    }
}
