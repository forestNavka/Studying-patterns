using System;
using FactoryMethod.NYPizzas;

namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheez: return new NYCheezPizza();
                case PizzaType.Margarita: return new NYMargheritaPizza();
                case PizzaType.Mexicano: return new NYMexicanoPizza();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
