using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Shoes : IProduct
    {
        public string Order()
        {
            return "Shoes";
        }

        public string Buy()
        {
            return "39.99";
        }
    }
}
