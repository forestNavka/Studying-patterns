using AbstractFactory.Ingredients;

namespace AbstractFactory.NY
{
    public class NYIngredientsProvider : IIngredientsProvider
    {
        public Cheez GetCheez()
        {
            return new NYCheez();
        }

        public Pepperony GetPepperony()
        {
            return new NYPepperony();
        }

        public Souce GetSouce()
        {
            return new NYSouce();
        }
    }
}