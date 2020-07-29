using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    interface IWeather
    {
        void registerComponent(IComponent c);
        void removeComponent(IComponent c);
        void notifyComponent();
    }
}
