namespace DesignPatternsDemo.Memento
{
    /// <summary>
    /// Memento class for storing state.
    /// </summary>
    public class Memento
    {
        public string State { get; }
        public Memento(string state) { State = state; }
    }
}
