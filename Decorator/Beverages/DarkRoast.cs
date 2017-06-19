namespace Decorator.Beverages
{
    public class DarkRoast : IBeverage
    {
        public double CalculateCost()
        {
            return 25.6;
        }

        public string GetDiscription()
        {
            return "Dark Roast Coffee";
        }
    }
}
