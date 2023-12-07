public interface IMealBuilder
{
    void BuildBurger(string type);
    void BuildBeverage(string type);
    void BuildSide(string type);
    Meal GetMeal();
}
