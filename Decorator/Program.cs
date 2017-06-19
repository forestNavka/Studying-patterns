using System;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new Mocha(new Milk(new Milk(new Espresso())));
            Console.WriteLine($"Purchased {beverage.GetDiscription()}");
            Console.WriteLine($"Total cost: {beverage.CalculateCost()}");
            Console.ReadLine();
        }
    }
}
