using System;

namespace AbstractFactory.Chicago
{
    internal class ChicagoMexicanoPizza : Pizza,IPizza
    {
        public ChicagoMexicanoPizza(IIngredientsProvider provider)
            : base(provider){ }

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