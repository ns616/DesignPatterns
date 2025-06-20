namespace DesignPatternsDemo.Memento
{
    /// <summary>
    /// Originator class whose state is saved/restored.
    /// </summary>
    public class Originator
    {
        public string State { get; set; }
        public Memento Save() => new Memento(State);
        public void Restore(Memento memento) => State = memento.State;
    }
}
