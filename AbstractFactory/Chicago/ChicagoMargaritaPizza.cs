using System;

namespace AbstractFactory.Chicago
{
    internal class ChicagoMargheritaPizza : Pizza,IPizza
    {
        public ChicagoMargheritaPizza(IIngredientsProvider provider)
            : base(provider){ }
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