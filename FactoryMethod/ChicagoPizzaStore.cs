using System;
using FactoryMethod.ChickagoPizzas;


namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheez: return new ChicagoCheezPizza();
                case PizzaType.Margarita: return new ChicagoMargheritaPizza();
                case PizzaType.Mexicano: return new ChicagoMexicanoPizza();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
