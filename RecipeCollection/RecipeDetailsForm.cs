using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeCollection
{
    public partial class RecipeDetailsForm : Form
    {
        //Declares variables
        public Recipe recipe;
        public RecipeManager recipeManager;
        public ViewRecipesForm viewRecipesForm;
        public MainMenuForm mainMenu;


        //Constructor
        public RecipeDetailsForm(Recipe selectedRecipe)
        {
            recipeManager = RecipeManager.Instance;
            recipe = selectedRecipe;
            InitializeComponent();
            DisplayRecipeDetails();
        }


        //Event handling
        //Go back to ViewRecipesForm
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            viewRecipesForm.recipeDetails = this;
            viewRecipesForm.Show();
            Hide();
        }


        //Opens panel where user can edit recipe. Transfers all the values to the edit panel
        private void EditButton_Click(object sender, EventArgs e)
        {
            ShowEditPanel();
        }


        //Removes recipe
        private void RemoveRecipeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this recipe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                recipeManager.allRecipes.Remove(recipe);
                viewRecipesForm.recipeBox.Items.Remove(viewRecipesForm.recipeBox.SelectedItem);
                MessageBox.Show("Recipe removed");
                viewRecipesForm.recipeDetails = this;
                viewRecipesForm.Show();
                recipeManager.SaveToCSV();
                Hide();

            }
            else
            {
                MessageBox.Show("Action canceled");
            }
        }


        //Adds new ingredient to list
        private void IngredientToListButton_Click(object sender, EventArgs e)
        {
            if (addIngredientBox.Text != null)
            {
                editIngredientsBox.Items.Add(addIngredientBox.Text);
                addIngredientBox.Text = "";
            }
            else
            {
                MessageBox.Show("You must enter an ingredient first");
            }
        }


        //Removes selected ingredient from the ingredients list
        private void RemoveIngredientButton_Click(object sender, EventArgs e)
        {
            if (editIngredientsBox.SelectedItems != null)
            {
                string selectedItem = editIngredientsBox.SelectedItem.ToString();
                recipe.Ingredients.Remove(selectedItem);
                editIngredientsBox.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Choose an ingredient to remove");
            }
        }


        //Adds the new details to the first panel and saves changes to CSV
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(recipeTextbox.Text) && servingsNumeric.Value != 0 && categoryCombobox.SelectedIndex != -1 && editIngredientsBox.Items.Count != 0 && !string.IsNullOrWhiteSpace(instructionsTextbox.Text))
            {
                recipe.RecipeName = recipeTextbox.Text;
                recipe.Servings = servingsNumeric.Value;
                recipe.Category = (string)categoryCombobox.SelectedItem;
                recipe.Ingredients.Clear();
                recipe.ListboxItemsToList(editIngredientsBox);
                recipe.Instructions = instructionsTextbox.Text;

                editPanel.Visible = false;
                detailsPanel.Visible = true;
                DisplayRecipeDetails();
                RecipeDetailsForm Details = this;
                Details.Text = "Recipe details";

                recipeManager.SaveToCSV();
            }
            else
            {
                MessageBox.Show("Some fields are empty or invalid");
            }
        }


        //Other functions
        //Displays details for the user's chosen recipe
        public void DisplayRecipeDetails()
        {
            if (recipe != null)
            {
                recipeNameLabel.Text = recipe.RecipeName;
                servingsLabel.Text = $"Serves: {recipe.Servings}";
                categoryLabel.Text = $"Category: {recipe.Category}";
                allIngredientsLabel.Text = string.Join("\n", recipe.Ingredients);
                allInstructionsLabel.Text = recipe.Instructions;
            }
        }


        //Function for showing the panel where user can edit recipe
        public void ShowEditPanel()
        {
            detailsPanel.Visible = false;
            editPanel.Visible = true;
            recipeTextbox.Text = recipe.RecipeName;
            servingsNumeric.Value = recipe.Servings;
            categoryCombobox.SelectedItem = recipe.Category;
            editIngredientsBox.Items.Clear();
            editIngredientsBox.Items.AddRange(recipe.Ingredients.ToArray());
            instructionsTextbox.Text = recipe.Instructions;
            RecipeDetailsForm recipeDetails = this;
            recipeDetails.Text = "Edit recipe";
        }


        //Closes application after user's confirmation. If they press "No", the app goes back to the main menu.
        private void RecipeDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
