namespace Observer.Contracts
{
    public interface IWeatherDataPublisher
    {
        void AddObserver(IWeatherObserver observer);

        void RemoveObserver(IWeatherObserver observer);

        void NotifyObservers();
    }
}
