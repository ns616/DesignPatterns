namespace DesignPatternsDemo.Builder
{
    /// <summary>
    /// Builder interface for constructing a meal.
    /// </summary>
    public interface IMealBuilder
    {
        void BuildMain();
        void BuildSide();
        void BuildDrink();
        Meal GetMeal();
    }
}
