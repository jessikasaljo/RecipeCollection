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
            LoadFromCSV();
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


        //Loads recipes from CSV file
        public void LoadFromCSV()
        {
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
                        decimal servings = Convert.ToDecimal(strings[1]);
                        string category = strings[2];

                        List<string> ingredients = new List<string>();
                        int separatorIndex = Array.IndexOf(strings, "");
                        for (int i = 3; i < separatorIndex; i++)
                        {
                            ingredients.Add(strings[i]);
                        }
                        string[] instructionArray = strings.Skip(separatorIndex + 1).ToArray();
                        string instructions = string.Join(",", instructionArray).Replace("*", "\r\n");

                        Recipe recipe = new Recipe(recipeName, servings, category, ingredients, instructions);
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
    }
}
