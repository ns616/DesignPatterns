namespace DesignPatternsDemo.Flyweight
{
    /// <summary>
    /// Factory for managing flyweight tree types.
    /// </summary>
    public class TreeFactory
    {
        private readonly Dictionary<string, ITreeType> _types = new();
        public ITreeType GetTreeType(string name)
        {
            if (!_types.ContainsKey(name))
                _types[name] = new TreeType(name);
            return _types[name];
        }
    }
}
