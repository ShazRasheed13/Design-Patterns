using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherStation: IWeatherSubject
    {
        private List<IWeatherObserver> observers = new List<IWeatherObserver>();
        private float temperature;
        private float humidity;
        private float pressure;
        public void AddObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            NotifyObservers();
        }
    }
}
