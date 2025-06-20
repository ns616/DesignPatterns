namespace DesignPatternsDemo.Composite
{
    /// <summary>
    /// Leaf class representing a file.
    /// </summary>
    public class File : IFileSystemItem
    {
        public string Name { get; }
        public File(string name) { Name = name; }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- {Name}");
        }
    }
}
