using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherDisplay: IWeatherObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Weather Display - Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure} hPa");
        }
    }
}
