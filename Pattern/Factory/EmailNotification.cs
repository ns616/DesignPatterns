namespace DesignPatternsDemo.Factory
{
    /// <summary>
    /// Email notification implementation.
    /// </summary>
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Factory] Email sent: {message}");
        }
    }
}
