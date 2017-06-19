using System;

namespace AbstractFactory.NY
{
    public class NYMargheritaPizza : Pizza,IPizza
    {
        public NYMargheritaPizza(IIngredientsProvider provider)
            : base(provider){ }
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