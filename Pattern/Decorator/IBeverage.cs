namespace DesignPatternsDemo.Decorator
{
    /// <summary>
    /// Component interface for beverages.
    /// </summary>
    public interface IBeverage
    {
        string GetDescription();
        double GetCost();
    }
}
