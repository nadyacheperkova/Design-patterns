using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IClothingFactory
    {
        ITshirt CreateTshirt();
        IPants CreatePants();
        IJacket CreateJacket();
        string GetFactoryType();
    }
}
