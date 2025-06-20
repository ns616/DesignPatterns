namespace DesignPatternsDemo.ChainOfResponsibility
{
    /// <summary>
    /// Handler interface for processing requests.
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handle(string request);
    }
}
