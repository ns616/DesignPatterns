namespace DesignPatternsDemo.Builder
{
    /// <summary>
    /// Director class to construct a meal using a builder.
    /// </summary>
    public class MealDirector
    {
        public Meal Construct(IMealBuilder builder)
        {
            builder.BuildMain();
            builder.BuildSide();
            builder.BuildDrink();
            return builder.GetMeal();
        }
    }
}
