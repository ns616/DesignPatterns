namespace DesignPatternsDemo.ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler for email support.
    /// </summary>
    public class EmailHandler : Handler
    {
        public override string Handle(string request)
        {
            if (request.Contains("email"))
                return "Handled by Email Support";
            return base.Handle(request);
        }
    }
}
