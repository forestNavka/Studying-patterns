namespace Decorator.Beverages
{
    public class Espresso : IBeverage
    {
        public double CalculateCost()
        {
            return 21;
        }

        public string GetDiscription()
        {
            return "Espresso";
        }
    }
}
