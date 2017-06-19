namespace Observer.Contracts
{
    public interface IWeatherObserver
    {
        void Update(WeatherData data);
    }
}
