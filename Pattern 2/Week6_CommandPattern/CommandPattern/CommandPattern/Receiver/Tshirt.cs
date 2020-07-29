using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Tshirt : IProduct
    {
        public string Order()
        {
            return "T-shirt";
        }

        public string Buy()
        {
            return "19.99";
        }
    }
}
