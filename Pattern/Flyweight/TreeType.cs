namespace DesignPatternsDemo.Flyweight
{
    /// <summary>
    /// Concrete flyweight for a specific tree type.
    /// </summary>
    public class TreeType : ITreeType
    {
        private readonly string _name;
        public TreeType(string name) { _name = name; }
        public void Display(int x, int y)
        {
            Console.WriteLine($"[Flyweight] Displaying {_name} tree at ({x},{y})");
        }
    }
}
