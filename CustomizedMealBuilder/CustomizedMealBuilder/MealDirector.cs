public class MealDirector
{
    public Meal ConstructVegetarianMeal(IMealBuilder builder)
    {
        builder.BuildBurger("Veggie Burger");
        builder.BuildBeverage("Water");
        builder.BuildSide("Salad");
        return builder.GetMeal();
    }

    public Meal ConstructChickenMeal(IMealBuilder builder)
    {
        builder.BuildBurger("Chicken Burger");
        builder.BuildBeverage("Soda");
        builder.BuildSide("Fries");
        return builder.GetMeal();
    }
}
