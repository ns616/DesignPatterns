namespace DesignPatternsDemo.Strategy
{
    /// <summary>
    /// PayPal payment strategy.
    /// </summary>
    public class PaypalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Strategy] Paid {amount:C} using PayPal.");
        }
    }
}
