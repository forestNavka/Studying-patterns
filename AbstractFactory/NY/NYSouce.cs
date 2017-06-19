using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.NY
{
    public class NYSouce : Souce
    {
        public NYSouce()
        {
            Console.WriteLine("Using NY Souce");
        }
    }
}