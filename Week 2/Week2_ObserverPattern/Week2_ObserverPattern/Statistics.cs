using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    class Statistics : IComponent, IDisplay
    {
        private float minTemp = 200;
        private float maxTemp = 0.0f;
        private float tempSum = 0.0f;
        private int readings;
        private WeatherData wd;

        public Statistics(WeatherData wd)
        {
            this.wd = wd;
            wd.registerComponent(this);
        }

        public void update(float temp, float pressure, float humidity)
        {
            tempSum += temp;
            readings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            display();
        }

        public string display()
        {
            return "Avg.temp: " + tempSum / readings + ". Max.temp: " + maxTemp + ". Min.temp: " + minTemp;
        }
    }
}
