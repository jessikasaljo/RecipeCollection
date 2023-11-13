using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeCollection
{
    public partial class ViewRecipesForm : Form
    {
        //Declares variables
        public MainMenuForm mainMenu;
        public RecipeDetailsForm recipeDetails;
        public RecipeManager recipeManager;


        //Constructor
        public ViewRecipesForm()
        {
            recipeManager = RecipeManager.Instance;
            InitializeComponent();

            List<string> categories = new List<string>()
            {
                "Entrées",
                "Main courses",
                "Desserts",
                "Side dishes",
                "Sauces",
            };

            foreach (string category in categories)
            {
                filterCombobox.Items.Add(category);
            }
        }


        //Event handling
        //Adds all the existing recipes into the recipe listbox.
        private void ViewRecipesForm_Load(object sender, EventArgs e)
        {
            foreach (Recipe recipe in recipeManager.allRecipes)
            {
                recipeBox.Items.Add(recipe);
            }
        }


        //Goes back to main menu
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            mainMenu.viewRecipesForm = this;
            Hide();
        }


        //Opens new window with entire recipe based on the user's selection
        private void OpenRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeBox.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)recipeBox.SelectedItem;
                recipeDetails = new RecipeDetailsForm(selectedRecipe);
                recipeDetails.viewRecipesForm = this;
                recipeDetails.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Select a recipe to open");
            }
        }


        //Opens panel where recipes can be edited, based on user's selection
        private void EditRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeBox.SelectedItem != null)
            {
                Recipe selectedRecipe = (Recipe)recipeBox.SelectedItem;
                recipeDetails = new RecipeDetailsForm(selectedRecipe);
                recipeDetails.viewRecipesForm = this;
                recipeDetails.Show();

                recipeDetails.ShowEditPanel();

                Hide();
            }
            else
            {
                MessageBox.Show("Select a recipe to edit");
            }
        }


        //Removes chosen recipe
        private void RemoveRecipeButton_Click(object sender, EventArgs e)
        {
            if (recipeBox.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this recipe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    recipeManager.allRecipes.Remove((Recipe)recipeBox.SelectedItem);
                    recipeBox.Items.Remove(recipeBox.SelectedItem);
                    recipeManager.SaveToCSV();
                    MessageBox.Show("Recipe removed");
                }
                else
                {
                    MessageBox.Show("Action canceled");
                }
            }
            else
            {
                MessageBox.Show("Select a recipe to remove");
            }
        }


        //Filters and displays recipes based on the selected recipe name
        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (filterCombobox.SelectedItem != null)
            {
                recipeBox.Items.Clear();

                foreach (Recipe recipe in recipeManager.allRecipes)
                {
                    if (recipe.Category == (string)filterCombobox.SelectedItem)
                    {
                        recipeBox.Items.Add(recipe);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a category to filter by");
            }
        }


        //Closes application after user's confirmation. If they press "No", the app goes back to the main menu.
        private void ViewRecipesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
