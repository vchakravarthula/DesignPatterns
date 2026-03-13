using System;
using System.Collections.Generic;
using System.Text;
using WeatherObserver.Observer;

namespace WeatherObserver.Subject
{
    public class WeatherData : ISubject
    {
        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void UnregisterObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
