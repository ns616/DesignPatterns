namespace DesignPatternsDemo.Observer
{
    /// <summary>
    /// Subscriber interface for Observer pattern demo.
    /// </summary>
    public interface ISubscriber
    {
        void Update(string news);
    }
}
