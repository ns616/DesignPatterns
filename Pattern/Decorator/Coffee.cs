namespace DesignPatternsDemo.Decorator
{
    /// <summary>
    /// Concrete component: simple coffee.
    /// </summary>
    public class Coffee : IBeverage
    {
        public string GetDescription() => "Coffee";
        public double GetCost() => 2.0;
    }
}
