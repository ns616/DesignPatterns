namespace DesignPatternsDemo.Factory
{
    /// <summary>
    /// Factory to create notifications.
    /// </summary>
    public class NotificationFactory
    {
        public INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                _ => throw new ArgumentException("Unknown notification type")
            };
        }
    }
}
