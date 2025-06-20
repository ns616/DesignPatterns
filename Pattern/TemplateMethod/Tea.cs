namespace DesignPatternsDemo.TemplateMethod
{
    /// <summary>
    /// Concrete class for tea.
    /// </summary>
    public class Tea : Beverage
    {
        protected override void Brew() => Console.WriteLine("[TemplateMethod] Steeping the tea");
        protected override void AddCondiments() => Console.WriteLine("[TemplateMethod] Adding lemon");
    }
}
