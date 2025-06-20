namespace DesignPatternsDemo.Composite
{
    /// <summary>
    /// Composite class representing a directory.
    /// </summary>
    public class Directory : IFileSystemItem
    {
        public string Name { get; }
        private readonly List<IFileSystemItem> _children = new();
        public Directory(string name) { Name = name; }
        public void Add(IFileSystemItem item) => _children.Add(item);
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ {Name}");
            foreach (var child in _children)
                child.Display(indent + "  ");
        }
    }
}
