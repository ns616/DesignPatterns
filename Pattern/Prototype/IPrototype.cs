namespace DesignPatternsDemo.Prototype
{
    /// <summary>
    /// Prototype interface for cloning.
    /// </summary>
    public interface IPrototype<T>
    {
        T Clone();
    }
}
