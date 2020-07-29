using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    class CurrentConditions : IComponent, IDisplay
    {
        private float temp;
        private float humidity;
        private IWeather w;

        public CurrentConditions(IWeather w)
        {
            this.w = w;
            w.registerComponent(this);
        }
        public void update(float temp, float pressure, float humidity)
        {
            this.temp = temp;
            this.humidity = humidity;
        }

        public string display()
        {
            return "Current conditions: " + temp + " degrees celcius and " + humidity + " humidity";
        }
    }
}
