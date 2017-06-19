using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.NY
{
    public class NYCheez : Cheez
    {
        public NYCheez()
        {
            Console.WriteLine("Using NY Cheez");
        }
    }
}