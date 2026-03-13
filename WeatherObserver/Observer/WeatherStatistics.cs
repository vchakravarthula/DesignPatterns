using System;
using System.Collections.Generic;
using System.Text;
using WeatherObserver.DisplayElement;
using WeatherObserver.Subject;

namespace WeatherObserver.Observer
{
    public class WeatherStatistics : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public WeatherStatistics(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"WeatherStatistics conditions: {this.temperature}F degrees and {this.humidity}% humidity and {this.pressure} Pa pressure");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.Display();
        }
    }
}
