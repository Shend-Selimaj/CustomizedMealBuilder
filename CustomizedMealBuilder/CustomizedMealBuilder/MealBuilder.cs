public class MealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildBurger(string type)
    {
        meal.Burger = new Burger { Type = type };
    }

    public void BuildBeverage(string type)
    {
        meal.Beverage = new Beverage { Type = type };
    }

    public void BuildSide(string type)
    {
        meal.Side = new Side { Type = type };
    }

    public Meal GetMeal()
    {
        return meal;
    }
}
