namespace DesignPatternsDemo.ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler for phone support.
    /// </summary>
    public class PhoneHandler : Handler
    {
        public override string Handle(string request)
        {
            if (request.Contains("phone"))
                return "Handled by Phone Support";
            return base.Handle(request);
        }
    }
}
