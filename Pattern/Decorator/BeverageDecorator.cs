namespace DesignPatternsDemo.Decorator
{
    /// <summary>
    /// Decorator base class for beverages.
    /// </summary>
    public abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage _beverage;
        protected BeverageDecorator(IBeverage beverage) { _beverage = beverage; }
        public abstract string GetDescription();
        public abstract double GetCost();
    }
}
