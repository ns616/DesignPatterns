namespace DesignPatternsDemo.Mediator
{
    /// <summary>
    /// Concrete mediator for chat room.
    /// </summary>
    public class ChatRoom : IChatRoom
    {
        public void ShowMessage(string user, string message)
        {
            Console.WriteLine($"[Mediator] {user}: {message}");
        }
    }
}
