using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.Chicago
{
    public class ChicagoPepperoni : Pepperony
    {
        public ChicagoPepperoni()
        {
            Console.WriteLine("Using Chicago Pepperony");
        }
    }
}