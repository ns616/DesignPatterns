namespace DesignPatternsDemo.Decorator
{
    /// <summary>
    /// Concrete decorator: adds milk.
    /// </summary>
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage) { }
        public override string GetDescription() => _beverage.GetDescription() + ", Milk";
        public override double GetCost() => _beverage.GetCost() + 0.5;
    }
}
