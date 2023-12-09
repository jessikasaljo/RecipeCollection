using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeCollection
{
    public partial class AddNewRecipeForm : Form
    {
        //Declares variables
        public MainMenuForm mainMenu;
        public RecipeManager recipeManager;


        //Constructor
        public AddNewRecipeForm()
        {
            InitializeComponent();
            recipeManager = RecipeManager.Instance;
        }


        //Event handling
        //Adds written ingredient to listbox
        private void IngredientToListButton_Click(object sender, EventArgs e)
        {
            recipeManager.AddIngredientToListBox(ingredientsListbox, addIngredientBox);
        }


        //Back to main menu
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            mainMenu.addNewRecipeForm = this;
            mainMenu.Show();
            Hide();
        }


        //Adds recipe to list and goes back to main menu
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(recipeNameBox.Text) && servingsCount.Value != 0 && categoryListbox.SelectedIndex != -1 && ingredientsListbox.Items.Count != 0 && !string.IsNullOrWhiteSpace(instructionsBox.Text))
            {
                List<string> ingredients = new List<string>();
                Recipe newRecipe = new Recipe(recipeNameBox.Text, (int)servingsCount.Value, (string)categoryListbox.SelectedItem, ingredients, instructionsBox.Text);
                newRecipe.ListboxItemsToList(ingredientsListbox);
                recipeManager.allRecipes.Add(newRecipe);
                recipeManager.SaveToCSV();
                MessageBox.Show("You added a new recipe to your collection!");
                mainMenu.addNewRecipeForm = this;
                mainMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Some fields are empty or invalid");
            }
        }


        //Removes selected ingredient from listbox
        private void RemoveIngredientButton_Click(object sender, EventArgs e)
        {
            recipeManager.RemoveIngredient(ingredientsListbox, null);
        }


        //Closes application after user's confirmation. If they press "No", the app goes back to the main menu.
        private void AddNewRecipeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
