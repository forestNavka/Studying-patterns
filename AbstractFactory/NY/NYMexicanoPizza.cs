using System;

namespace AbstractFactory.NY
{
    public class NYMexicanoPizza : Pizza,IPizza
    {
        public NYMexicanoPizza(IIngredientsProvider provider)
            : base(provider){ }

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