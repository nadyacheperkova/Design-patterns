using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    class Forecast : IComponent, IDisplay
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData wd;

        public Forecast(WeatherData wd)
        {
            this.wd = wd;
            this.wd.registerComponent(this);
        }
        public void update(float temp,  float pressure, float humidity)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            display();
        }

        public string display()
        {
            string s = "Forecast: ";
            if (currentPressure > lastPressure)
            {
                s += "The weather is going to improve.";
            }
            else if (currentPressure == lastPressure)
            {
                s += "The weather is going to stay the same.";
            }
            else if (currentPressure < lastPressure)
            {
                s += "It is going to rain.";
            }

            return s;
        }
    }
}
