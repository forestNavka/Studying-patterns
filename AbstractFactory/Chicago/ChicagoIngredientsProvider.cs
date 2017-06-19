using AbstractFactory.Ingredients;

namespace AbstractFactory.Chicago
{
    public class ChicagoIngredientsProvider : IIngredientsProvider
    {
        public Cheez GetCheez()
        {
            return new ChicagoCheez();
        }

        public Pepperony GetPepperony()
        {
            return new ChicagoPepperoni();
        }

        public Souce GetSouce()
        {
            return new ChicagoSouce();
        }
    }
}