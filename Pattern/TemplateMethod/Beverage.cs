namespace DesignPatternsDemo.TemplateMethod
{
    /// <summary>
    /// Abstract class for making beverages.
    /// </summary>
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
        private void BoilWater() => Console.WriteLine("[TemplateMethod] Boiling water");
        private void PourInCup() => Console.WriteLine("[TemplateMethod] Pouring into cup");
    }
}
