using System;

namespace FactoryMethod.ChickagoPizzas
{
    internal class ChicagoMargheritaPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking Chicago Margherita Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Chicago Margherita Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering Chicago Margherita Pizza...");
        }
    }
}