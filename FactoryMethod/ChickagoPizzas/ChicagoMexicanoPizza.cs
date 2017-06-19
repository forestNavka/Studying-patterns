using System;

namespace FactoryMethod.ChickagoPizzas
{
    internal class ChicagoMexicanoPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking Chicago Mexicano Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Chicago Mexicano Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering Chicago Mexicano Pizza...");
        }
    }
}