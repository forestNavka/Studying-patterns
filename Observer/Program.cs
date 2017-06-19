using System;
using Observer.Concrete;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataManager = new WeatherDataPublisher();
            var ui1 = new WeatherUI1(dataManager);
            var ui2 = new WeatherUI2(dataManager);

            dataManager.MeasurementsChanged();
            dataManager.MeasurementsChanged();
            dataManager.MeasurementsChanged();
            Console.ReadLine();
        }
    }
}
