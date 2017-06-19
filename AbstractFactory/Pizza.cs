using AbstractFactory.Ingredients;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        private readonly IIngredientsProvider _ingredientsProvider;

        protected Pizza(IIngredientsProvider provider)
        {
            _ingredientsProvider = provider;
            var cheez = Cheez;
            var souse = Souce;
            var pepperony = Pepperony;
        }

        protected Cheez Cheez => _ingredientsProvider.GetCheez();

        protected Souce Souce => _ingredientsProvider.GetSouce();

        protected Pepperony Pepperony => _ingredientsProvider.GetPepperony();
    }
}
