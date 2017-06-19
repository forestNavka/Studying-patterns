using System;

namespace AbstractFactory.Chicago
{
    internal class ChicagoCheezPizza : Pizza, IPizza
    {
        public ChicagoCheezPizza(IIngredientsProvider provider)
            : base(provider){ }

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