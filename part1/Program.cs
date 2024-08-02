using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApp
{
    // Represents an ingredient with name, quantity, unit, calories, and food group.
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }
    }

    // Represents a step in a recipe with a description.
    public class RecipeStep
    {
        public string Description { get; set; }
    }

    // Represents a recipe with a name, list of ingredients, and steps.
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<RecipeStep> Steps { get; set; }
        public double TotalCalories => Ingredients.Sum(ingredient => ingredient.Calories * ingredient.Quantity);

        // Delegate to notify when total calories exceed a threshold.
        public delegate void CaloriesExceededHandler(double totalCalories);
        public event CaloriesExceededHandler OnCaloriesExceeded;

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<RecipeStep>();
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredients.Add(new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            });
        }

        public void AddStep(string description)
        {
            Steps.Add(new RecipeStep { Description = description });
        }

        // Enters recipe details, including ingredients and steps.
        public void EnterRecipeDetails()
        {
            Console.WriteLine($"Entering details for recipe: {Name}");

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity: ");
                double quantity;
                while (!double.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for Quantity:");
                }

                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                Console.Write("Calories per unit: ");
                double calories;
                while (!double.TryParse(Console.ReadLine(), out calories))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for Calories per unit:");
                }

                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                AddIngredient(name, quantity, unit, calories, foodGroup);
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter description for step #{i + 1}:");
                string description = Console.ReadLine();
                AddStep(description);
            }

            if (TotalCalories > 300)
            {
                OnCaloriesExceeded?.Invoke(TotalCalories);
            }
        }

        // Displays the recipe details, including ingredients and steps.
        public void DisplayRecipe()
        {
            Console.WriteLine($"\nRecipe: {Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name} ({ingredient.Calories} calories per unit, {ingredient.FoodGroup})");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }

            Console.WriteLine($"\nTotal Calories: {TotalCalories}");
        }

        // Scales the recipe by a given factor.
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Clears the recipe data.
        public void ClearData()
        {
            Ingredients.Clear();
            Steps.Clear();
        }
    }

    public class RecipeAppProgram
    {
        public static List<Recipe> recipes = new List<Recipe>();

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            MainWindow mainWindow = new MainWindow();
            app.Run(mainWindow);
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
            recipes = recipes.OrderBy(r => r.Name).ToList();
        }

        public static void ListRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            Console.WriteLine("Recipes:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].Name}");
            }
        }

        public static Recipe GetRecipeByIndex(int index)
        {
            return recipes.ElementAtOrDefault(index);
        }

        public static List<Recipe> FilterRecipes(string ingredientName, string foodGroup, double? maxCalories)
        {
            return recipes.Where(r =>
                (string.IsNullOrEmpty(ingredientName) || r.Ingredients.Any(i => i.Name.Contains(ingredientName))) &&
                (string.IsNullOrEmpty(foodGroup) || r.Ingredients.Any(i => i.FoodGroup.Contains(foodGroup))) &&
                (!maxCalories.HasValue || r.TotalCalories <= maxCalories)).ToList();
        }
    }
}