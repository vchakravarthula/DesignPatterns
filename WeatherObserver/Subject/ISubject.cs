using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherObserver.Subject
{
    public interface ISubject
    {
        public void RegisterObserver(Observer.IObserver observer);
        public void UnregisterObserver(Observer.IObserver observer);
        public void NotifyObservers();
    }
}
