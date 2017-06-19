using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.Chicago
{
    public class ChicagoCheez : Cheez
    {
        public ChicagoCheez()
        {
            Console.WriteLine("Using Chicago Cheez");
        }
    }
}