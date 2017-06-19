using System;
using Observer.Contracts;

namespace Observer.Concrete
{
    public class WeatherUI2 : IWeatherObserver
    {
        private IWeatherDataPublisher _publisher;
        public WeatherUI2(IWeatherDataPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddObserver(this);

        }
        public void Update(WeatherData data)
        {
            Console.WriteLine($"The second UI: temperature: {data.Temperature}, huminity: {data.Humidity}, pressure: {data.Pressure}");
        }
    }
}
