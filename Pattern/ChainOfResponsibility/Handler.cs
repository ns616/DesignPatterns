namespace DesignPatternsDemo.ChainOfResponsibility
{
    /// <summary>
    /// Base handler class for chaining.
    /// </summary>
    public abstract class Handler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public virtual string Handle(string request)
        {
            return _nextHandler?.Handle(request);
        }
    }
}
