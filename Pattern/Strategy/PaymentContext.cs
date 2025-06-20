namespace DesignPatternsDemo.Strategy
{
    /// <summary>
    /// Context for selecting payment strategy at runtime.
    /// </summary>
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void Pay(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }
}
