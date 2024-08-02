using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace RecipeApp
{
    public partial class FilterRecipesWindow : Window
    {
        public FilterRecipesWindow()
        {
            InitializeComponent();
        }

        private void RemovePlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Foreground == System.Windows.Media.Brushes.Gray)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void AddPlaceholderText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                switch (textBox.Name)
                {
                    case "IngredientNameTextBox":
                        textBox.Text = "Enter Ingredient Name";
                        break;
                    case "FoodGroupTextBox":
                        textBox.Text = "Enter Food Group";
                        break;
                    case "MaxCaloriesTextBox":
                        textBox.Text = "Enter Maximum Calories";
                        break;
                }
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            string ingredientName = IngredientNameTextBox.Text == "Enter Ingredient Name" ? string.Empty : IngredientNameTextBox.Text;
            string foodGroup = FoodGroupTextBox.Text == "Enter Food Group" ? string.Empty : FoodGroupTextBox.Text;
            double maxCalories;

            if (!double.TryParse(MaxCaloriesTextBox.Text == "Enter Maximum Calories" ? string.Empty : MaxCaloriesTextBox.Text, out maxCalories))
            {
                maxCalories = double.MaxValue;
            }

            List<Recipe> filteredRecipes = RecipeAppProgram.FilterRecipes(ingredientName, foodGroup, maxCalories);
            FilteredRecipesListBox.ItemsSource = filteredRecipes.Select(r => r.Name).ToList();
        }
    }
}