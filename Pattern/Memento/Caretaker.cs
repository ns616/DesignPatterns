namespace DesignPatternsDemo.Memento
{
    /// <summary>
    /// Caretaker class for managing mementos.
    /// </summary>
    public class Caretaker
    {
        private readonly List<Memento> _history = new();
        public void AddMemento(Memento memento) => _history.Add(memento);
        public Memento GetMemento(int index) => _history[index];
    }
}
