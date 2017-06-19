using System;

namespace FactoryMethod.NYPizzas
{
    internal class NYMexicanoPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking NewYork Mexicano Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing NewYork Mexicano Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering NewYork Mexicano Pizza...");
        }
    }
}