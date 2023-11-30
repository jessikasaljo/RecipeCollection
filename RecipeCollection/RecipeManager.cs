using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCollection
{
    public class RecipeManager
    {
        //Creates a static instance that's used throughout the program
        private static RecipeManager instance;
        public static RecipeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeManager();
                }
                return instance;
            }
        }

        //Path to CSV file
        string path = "MyRecipeCollection.csv";


        //Declares list that will contain all added recipes
        public List<Recipe> allRecipes;


        //Constructor
        public RecipeManager()
        {
            allRecipes = new List<Recipe>();

            //Loads recipes from CSV file
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                try
                {
                    while (line != null)
                    {
                        string[] strings = line.Split("|");
                        string recipeName = strings[0];
                        decimal servings = Convert.ToInt32(strings[1]);
                        string category = strings[2];

                        List<string> ingredients = new List<string>();
                        int separatorIndex = Array.IndexOf(strings, "");
                        for (int i = 3; i < separatorIndex; i++)
                        {
                            ingredients.Add(strings[i]);
                        }
                        string[] instructionArray = strings.Skip(separatorIndex + 1).ToArray();
                        string instructions = string.Join(",", instructionArray).Replace("*", "\r\n");

                        Recipe recipe = new Recipe(recipeName, (int)servings, category, ingredients, instructions);
                        allRecipes.Add(recipe);

                        line = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //Saves recipes to CSV file
        public void SaveToCSV()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Recipe recipe in allRecipes)
                {
                    writer.WriteLine(recipe.GetCSV());
                }
            }
        }


        //Adds the ingredient the user has written in the textbox to the ingredients listbox
        public void AddIngredientToListBox(ListBox listBox, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !listBox.Items.Contains(textBox.Text))
            {
                listBox.Items.Add(textBox.Text);
                textBox.Text = "";
            }
            else if (listBox.Items.Contains(textBox.Text))
            {
                MessageBox.Show("You've already added this ingredient");
            }
            else
            {
                MessageBox.Show("You must enter an ingredient first");
            }
        }


        //Removes selected ingredient from listbox and from the recipe, if it's already been created
        public void RemoveIngredient(ListBox listbox, Recipe recipe)
        {
            if (listbox.SelectedItem != null)
            {
                string selectedItem = listbox.SelectedItem.ToString();
                listbox.Items.Remove(selectedItem);

                if (recipe != null)
                {
                    recipe.Ingredients.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Choose an ingredient to remove");
            }
        }
    }
}
