namespace DesignPatternsDemo.Composite
{
    /// <summary>
    /// Component interface for file system items.
    /// </summary>
    public interface IFileSystemItem
    {
        void Display(string indent = "");
    }
}
