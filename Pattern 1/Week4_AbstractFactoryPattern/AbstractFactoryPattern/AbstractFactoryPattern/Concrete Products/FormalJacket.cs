﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FormalJacket : IJacket
    {
        public double GetPrice()
        {
            return 55.50;
        }

        public string GetProduct()
        {
            return "Formal Jacket";
        }
    }
}
