public class Meal
{
    public Burger Burger { get; set; }
    public Beverage Beverage { get; set; }
    public Side Side { get; set; }

    public override string ToString()
    {
        return $"Meal: {Burger.Type}, {Beverage.Type}, {Side.Type}";
    }
}
