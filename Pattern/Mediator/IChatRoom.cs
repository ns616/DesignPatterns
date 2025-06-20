namespace DesignPatternsDemo.Mediator
{
    /// <summary>
    /// Mediator interface for chat room.
    /// </summary>
    public interface IChatRoom
    {
        void ShowMessage(string user, string message);
    }
}
