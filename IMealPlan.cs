using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18feb_generics
{
    
    interface IMealPlan
    {
        string GetMealType();
    }

    class VegetarianMeal : IMealPlan
    {
        public string GetMealType() => "Vegetarian Meal";
    }

    class VeganMeal : IMealPlan
    {
        public string GetMealType() => "Vegan Meal";
    }

    class KetoMeal : IMealPlan
    {
        public string GetMealType() => "Keto Meal";
    }

    class HighProteinMeal : IMealPlan
    {
        public string GetMealType() => "High-Protein Meal";
    }

    // Generic Meal class restricted to IMealPlan
    class Meal<T> where T : IMealPlan, new()
    {
        public string MealName { get; set; }
        public T MealCategory { get; set; }

        public Meal(string mealName)
        {
            MealName = mealName;
            MealCategory = new T();
        }

        public void Display()
        {
            Console.WriteLine($"Meal: {MealName}, Category: {MealCategory.GetMealType()}");
        }
    }

    // Generic method to generate meal plan
    static class MealPlanGenerator
    {
        public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
        {
            Console.WriteLine($"Generating meal plan for: {meal.GetMealType()}");
        }
    }

    class Program
    {
        static void Main()
        {
            Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>("Grilled Veggies");
            Meal<VeganMeal> veganMeal = new Meal<VeganMeal>("Tofu Stir-fry");
            Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>("Avocado Salad");
            Meal<HighProteinMeal> proteinMeal = new Meal<HighProteinMeal>("Chicken Breast");

            List<IMealPlan> mealPlans = new List<IMealPlan> { new VegetarianMeal(), new VeganMeal(), new KetoMeal(), new HighProteinMeal() };

            Console.WriteLine("\nPersonalized Meal Plans:");
            foreach (var meal in mealPlans)
            {
                MealPlanGenerator.GenerateMealPlan(meal);
            }

            Console.WriteLine("\nMeal Details:");
            vegMeal.Display();
            veganMeal.Display();
            ketoMeal.Display();
            proteinMeal.Display();
        }
    }



}
