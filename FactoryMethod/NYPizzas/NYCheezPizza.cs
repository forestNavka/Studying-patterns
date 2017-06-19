using System;

namespace FactoryMethod.NYPizzas
{
    internal class NYCheezPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking NewYork Cheez Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing NewYork Cheez Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering NewYork Cheez Pizza...");
        }
    }
}