using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheez);

            PizzaStore pizzaStore2 = new ChicagoPizzaStore();
            pizzaStore2.OrderPizza(PizzaType.Margarita);
            
            Console.ReadLine();
        }
    }
}
