namespace DesignPatternsDemo.Strategy
{
    /// <summary>
    /// Credit card payment strategy.
    /// </summary>
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Strategy] Paid {amount:C} using Credit Card.");
        }
    }
}
