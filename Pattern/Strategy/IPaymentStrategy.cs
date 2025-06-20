namespace DesignPatternsDemo.Strategy
{
    /// <summary>
    /// Payment strategy interface for Strategy pattern demo.
    /// </summary>
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
