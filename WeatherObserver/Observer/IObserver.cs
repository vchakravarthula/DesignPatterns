using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherObserver.Observer
{
    public interface IObserver
    {
        public void Update();
    }
}
