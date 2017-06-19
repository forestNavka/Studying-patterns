using System;

namespace FactoryMethod.ChickagoPizzas
{
    internal class ChicagoCheezPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking Chicago Cheez Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Chicago Cheez Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering Chicago Cheez Pizza...");
        }
    }
}