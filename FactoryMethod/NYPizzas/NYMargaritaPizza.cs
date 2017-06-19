using System;

namespace FactoryMethod.NYPizzas
{
    internal class NYMargheritaPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking NewYork Margherita Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing NewYork Margherita Pizza...");
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering NewYork Margherita Pizza...");
        }
    }
}