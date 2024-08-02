using System.Windows;

namespace RecipeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshRecipeList();
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            var addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.ShowDialog();
            RefreshRecipeList();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeListBox.SelectedItem is Recipe selectedRecipe)
            {
                var displayRecipeWindow = new DisplayRecipeWindow(selectedRecipe);
                displayRecipeWindow.Show();
            }
            else
            {
                MessageBox.Show("Please select a recipe to display.");
            }
        }

        private void ListRecipes_Click(object sender, RoutedEventArgs e)
        {
            var listRecipesWindow = new ListRecipesWindow();
            listRecipesWindow.Show();
        }

        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            var filterRecipesWindow = new FilterRecipesWindow();
            filterRecipesWindow.Show();
        }

        private void RefreshRecipeList()
        {
            RecipeListBox.ItemsSource = null;
            RecipeListBox.ItemsSource = RecipeAppProgram.recipes;
        }
    }
}