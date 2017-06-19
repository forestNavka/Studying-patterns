using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.Chicago
{
    public class ChicagoSouce : Souce
    {
        public ChicagoSouce()
        {
            Console.WriteLine("Using Chicago Souce");
        }
    }
}