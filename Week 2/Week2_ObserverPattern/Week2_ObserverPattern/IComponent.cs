using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    interface IComponent
    {
        void update(float temp, float pressure, float humidity);
    }
}
