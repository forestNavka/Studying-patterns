using Observer.Contracts;
using System;

namespace Observer.Concrete
{
    public class WeatherUI1 : IWeatherObserver
    {
        private IWeatherDataPublisher _publisher;
        public WeatherUI1(IWeatherDataPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddObserver(this);
            
        }
        public void Update(WeatherData data)
        {
            Console.WriteLine($"The first UI: temperature: {data.Temperature}, huminity: {data.Humidity}, pressure: {data.Pressure}");
        }
    }
}
