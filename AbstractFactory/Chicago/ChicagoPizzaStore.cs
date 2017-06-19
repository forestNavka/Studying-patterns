using System;

namespace AbstractFactory.Chicago
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private readonly IIngredientsProvider _ingredientsProvider = new ChicagoIngredientsProvider();
        protected override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheez: return new ChicagoCheezPizza(_ingredientsProvider);
                case PizzaType.Margarita: return new ChicagoMargheritaPizza(_ingredientsProvider);
                case PizzaType.Mexicano: return new ChicagoMexicanoPizza(_ingredientsProvider);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
