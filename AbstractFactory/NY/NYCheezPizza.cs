using System;

namespace AbstractFactory.NY
{
    internal class NYCheezPizza : Pizza, IPizza
    {
        public NYCheezPizza (IIngredientsProvider provider)
            : base(provider){ }

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