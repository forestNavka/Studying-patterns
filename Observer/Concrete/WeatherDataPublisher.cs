using Observer.Contracts;
using System.Collections.Generic;

namespace Observer.Concrete
{
    public class WeatherDataPublisher : IWeatherDataPublisher
    {   
        private IList<IWeatherObserver> observers = new List<IWeatherObserver>();

        public void AddObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var weatherObserver in observers)
            {
                weatherObserver.Update(GetCurrentWeatherData());
            }
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        private WeatherData GetCurrentWeatherData()
        {
            return new WeatherData
            {
                Temperature = GetTemperature(),
                Humidity = GetHumidity(),
                Pressure = GetPressure()
            };
        }

        private float GetPressure()
        {
            return 8.9F;
        }

        private float GetHumidity()
        {
            return 4.5F;
        }

        private float GetTemperature()
        {
            return 26.8F;
        }
    }
}
