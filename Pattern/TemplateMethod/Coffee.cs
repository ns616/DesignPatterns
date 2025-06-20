namespace DesignPatternsDemo.TemplateMethod
{
    /// <summary>
    /// Concrete class for coffee.
    /// </summary>
    public class Coffee : Beverage
    {
        protected override void Brew() => Console.WriteLine("[TemplateMethod] Brewing the coffee grounds");
        protected override void AddCondiments() => Console.WriteLine("[TemplateMethod] Adding sugar and milk");
    }
}
