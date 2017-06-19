using AbstractFactory.Ingredients;

namespace AbstractFactory
{
    public interface IIngredientsProvider
    {
        Cheez GetCheez();
        Souce GetSouce();
        Pepperony GetPepperony();
    }
}