using System;

namespace AbstractFactory.NY
{
    public class NYPizzaStore : PizzaStore
    {
        private readonly IIngredientsProvider _ingredientsProvider = new NYIngredientsProvider();
        protected override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheez: return new NYCheezPizza(_ingredientsProvider);
                case PizzaType.Margarita: return new NYMargheritaPizza(_ingredientsProvider);
                case PizzaType.Mexicano: return new NYMexicanoPizza(_ingredientsProvider);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
