namespace Decorator.Condiments
{
    public class Mocha : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public double CalculateCost()
        {
            return _beverage.CalculateCost() + 4.7;
        }

        public string GetDiscription()
        {
            return $"{_beverage.GetDiscription()}, mocha";
        }
    }
}
