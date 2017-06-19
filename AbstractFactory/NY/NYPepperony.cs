using System;
using AbstractFactory.Ingredients;

namespace AbstractFactory.NY
{
    public class NYPepperony : Pepperony
    {
        public NYPepperony()
        {
           Console.WriteLine("Using NY Pepperony");
        }
    }
}