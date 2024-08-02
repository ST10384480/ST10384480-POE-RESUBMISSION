using System.Windows;

namespace RecipeApp
{
    public partial class DisplayRecipeWindow : Window
    {
        public DisplayRecipeWindow()
        {
            InitializeComponent();
        }

        public DisplayRecipeWindow(Recipe recipe) : this()
        {
            DisplayRecipeDetails(recipe);
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the recipe index from the TextBox
            string recipeIndex = RecipeIndexTextBox.Text;

            // For demonstration purposes, you can hardcode some recipe details
            // In a real application, you would retrieve this from a database or other data source
            string recipeDetails = $"Details of recipe at index {recipeIndex}";

            // Display the recipe details in the TextBlock
            RecipeDetailsTextBlock.Text = recipeDetails;
        }

        private void DisplayRecipeDetails(Recipe recipe)
        {
            RecipeDetailsTextBlock.Text = $"Recipe: {recipe.Name}\n\nIngredients:\n";
            foreach (var ingredient in recipe.Ingredients)
            {
                RecipeDetailsTextBlock.Text += $"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name} ({ingredient.Calories} calories per unit, {ingredient.FoodGroup})\n";
            }

            RecipeDetailsTextBlock.Text += "\nSteps:\n";
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                RecipeDetailsTextBlock.Text += $"{i + 1}. {recipe.Steps[i].Description}\n";
            }

            RecipeDetailsTextBlock.Text += $"\nTotal Calories: {recipe.TotalCalories}";
        }
    }
}