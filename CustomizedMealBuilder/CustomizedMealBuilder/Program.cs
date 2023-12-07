using System;

namespace CustomizedMealBuilder
{
    class Program
    {
        static void Main()
        {
            // Create a MealBuilder
            IMealBuilder builder = new MealBuilder();

            // Create a MealDirector
            MealDirector director = new MealDirector();

            // Construct a vegetarian meal using the director
            Meal vegetarianMeal = director.ConstructVegetarianMeal(builder);
            Console.WriteLine("Vegetarian Meal:");
            Console.WriteLine(vegetarianMeal);
            Console.WriteLine();

            // Construct a chicken meal using the director
            Meal chickenMeal = director.ConstructChickenMeal(builder);
            Console.WriteLine("Chicken Meal:");
            Console.WriteLine(chickenMeal);

            Console.ReadLine();
        }
    }
}
