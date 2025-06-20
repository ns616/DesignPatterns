namespace DesignPatternsDemo.Builder
{
    /// <summary>
    /// Product class representing a simple meal.
    /// </summary>
    public class Meal
    {
        public string Main { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }
        public override string ToString() => $"Main: {Main}, Side: {Side}, Drink: {Drink}";
    }
}
