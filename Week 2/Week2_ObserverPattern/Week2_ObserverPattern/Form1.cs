using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_ObserverPattern
{
    public partial class Form1 : Form
    {
        private WeatherData wd;
        private CurrentConditions currentDisplay;
        private Statistics statisticsDisplay;
        private Forecast forecastDisplay;
        public Form1()
        {
            InitializeComponent();
            wd = new WeatherData();
            currentDisplay = new CurrentConditions(wd);
            statisticsDisplay = new Statistics(wd);
            forecastDisplay = new Forecast(wd);
            wd.setMeasurements(80, 30.4f, 65);
            lbCurrent.Items.Add(currentDisplay.display());
            lbCurrent.Items.Add(forecastDisplay.display());
            lbCurrent.Items.Add(statisticsDisplay.display());
            lbCurrent.Items.Add($"********************************************************");

            wd.setMeasurements(82,29.2f,70);
            lbCurrent.Items.Add(currentDisplay.display());
            lbCurrent.Items.Add(forecastDisplay.display());
            lbCurrent.Items.Add(statisticsDisplay.display());
            lbCurrent.Items.Add($"********************************************************");

            wd.setMeasurements(78,29.2f,90);
            lbCurrent.Items.Add(currentDisplay.display());
            lbCurrent.Items.Add(forecastDisplay.display());
            lbCurrent.Items.Add(statisticsDisplay.display());
            lbCurrent.Items.Add($"********************************************************");

        }

 
    }
}
