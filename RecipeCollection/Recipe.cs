using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeCollection
{
    public class Recipe
    {
        //Properties and empty list of ingredients
        public string RecipeName { get; set; }
        public decimal Servings { get; set; }
        public string Category { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }



        //Constructor
        public Recipe(string recipeName, decimal servings, string category, List<string> ingredients, string instructions)
        {
            RecipeName = recipeName;
            Servings = servings;
            Category = category;
            Ingredients = ingredients ?? new List<string>();
            Instructions = instructions;
        }


        //Add listbox items to ingredient list
        public void ListboxItemsToList(ListBox listbox)
        {
            foreach (var item in listbox.Items)
            {
                if (item != null)
                {
                    Ingredients.Add(item.ToString());
                }
            }
        }

        
        //Returns only RecipeName when recipe is called
        public override string ToString()
        {
            return RecipeName;
        }
        

        //Returns formatting for CSV file
        public string GetCSV()
        {
            string modifiedInstructions = Instructions.Replace("\r\n", "*");
            string ingredientsString = string.Join("|", Ingredients);

            return $"{RecipeName}|{Servings}|{Category}|{ingredientsString}||{modifiedInstructions}";
        }
    }
}
