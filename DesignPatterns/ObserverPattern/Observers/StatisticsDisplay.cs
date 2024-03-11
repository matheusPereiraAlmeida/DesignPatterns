using DesignPatterns.ObserverPattern.Interfaces;
using System;

namespace DesignPatterns.ObserverPattern.Observers
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
        public void display()
        {
            Console.WriteLine("Statistics conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}
