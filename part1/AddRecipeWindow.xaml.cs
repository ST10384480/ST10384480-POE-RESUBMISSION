using System.Windows;
using System.Windows.Controls;

namespace RecipeApp
{
    public partial class AddRecipeWindow : Window
    {
        private Recipe currentRecipe = new Recipe();

        public AddRecipeWindow()
        {
            InitializeComponent();
            RecipeNameTextBox.Text = "Recipe Name";
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            string name = IngredientNameTextBox.Text;
            double quantity = double.Parse(IngredientQuantityTextBox.Text);
            string unit = IngredientUnitTextBox.Text;
            double calories = double.Parse(IngredientCaloriesTextBox.Text);
            string foodGroup = IngredientFoodGroupTextBox.Text;

            currentRecipe.AddIngredient(name, quantity, unit, calories, foodGroup);

            MessageBox.Show("Ingredient added successfully!");
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            string description = StepDescriptionTextBox.Text;
            currentRecipe.AddStep(description);

            MessageBox.Show("Step added successfully!");
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            currentRecipe.Name = RecipeNameTextBox.Text;
            RecipeAppProgram.AddRecipe(currentRecipe);

            MessageBox.Show("Recipe saved successfully!");
            this.Close();
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Recipe Name")
            {
                textBox.Text = "";
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Recipe Name";
            }
        }
    }
}