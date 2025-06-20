namespace DesignPatternsDemo.Builder
{
    /// <summary>
    /// Concrete builder for a vegetarian meal.
    /// </summary>
    public class VegMealBuilder : IMealBuilder
    {
        private Meal _meal = new Meal();
        public void BuildMain() => _meal.Main = "Veggie Burger";
        public void BuildSide() => _meal.Side = "Salad";
        public void BuildDrink() => _meal.Drink = "Juice";
        public Meal GetMeal() => _meal;
    }
}
