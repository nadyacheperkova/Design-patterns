using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_ObserverPattern
{
    class WeatherData : IWeather
    {
        private List<IComponent> components;
        private float temp;
        private float humidity;
        private float pressure;

        public float Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        public float Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public float Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public WeatherData()
        {
            this.components = new List<IComponent>();
        }
        public void registerComponent(IComponent c)
        {
            components.Add(c);
        }

        public void removeComponent(IComponent c)
        {
            int i = components.IndexOf(c);
            if (i >= 0)
            {
                components.RemoveAt(i);
            }
        }

        public void notifyComponent()
        {
            foreach (var c in components)
            {
                c.update(temp, pressure, humidity);
            }
        }

        public void measurementsChanged()
        {
            notifyComponent();
        }

        public void setMeasurements(float temp, float pressure, float humidity)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
            measurementsChanged();
        }
    }
}
