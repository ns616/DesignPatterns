namespace DesignPatternsDemo.Factory
{
    /// <summary>
    /// SMS notification implementation.
    /// </summary>
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Factory] SMS sent: {message}");
        }
    }
}
