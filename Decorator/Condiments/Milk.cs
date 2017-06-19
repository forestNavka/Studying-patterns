namespace Decorator.Condiments
{
    public class Milk : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Milk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double CalculateCost()
        {
            return _beverage.CalculateCost() + 5.8;
        }

        public string GetDiscription()
        {
            return $"{_beverage.GetDiscription()}, milk";
        }
    }
}
