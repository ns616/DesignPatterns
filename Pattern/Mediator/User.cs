namespace DesignPatternsDemo.Mediator
{
    /// <summary>
    /// Colleague class representing a user.
    /// </summary>
    public class User
    {
        private readonly string _name;
        private readonly IChatRoom _chatRoom;
        public User(string name, IChatRoom chatRoom)
        {
            _name = name;
            _chatRoom = chatRoom;
        }
        public void Send(string message)
        {
            _chatRoom.ShowMessage(_name, message);
        }
    }
}
