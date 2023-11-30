namespace RecipeCollection
{
    public partial class MainMenuForm : Form
    {
        //Declares new instances of the other windows
        public RecipeManager recipeManager;
        public ViewRecipesForm viewRecipesForm;
        public AddNewRecipeForm addNewRecipeForm;
        public RecipeDetailsForm recipeDetails;


        //Constructor
        public MainMenuForm()
        {
            InitializeComponent();
            recipeManager = RecipeManager.Instance;

            //Example recipes for testing the logic
            //Pannkakor
            List<string> pannkakorIngredients = new List<string>()
            { "Ägg, 3 st", "Mjöl, 3 dl", "Mjölk, 6 dl" };
            Recipe pannkakorRecipe = new Recipe("Pannkakor", 4, "Main courses", pannkakorIngredients,
                                              "Vispa mjöl och hälften av mjölken.\r\nTillsätt resten av mjölken och äggen och vispa igen." +
                                              "\r\nHetta upp en panna med smör och stek en knapp dl smet åt gången.\r\nServera med sylt och grädde.");
            recipeManager.allRecipes.Add(pannkakorRecipe);

            //Chokladbollar
            List<string> chokladbollarIngredients = new List<string>()
            { "Smör, 150 g", "Strösocker, 1.5 dl", "Kakao, 3 msk", "Vaniljsocker, 1 tsk", "Kallt kaffe, 2 msk", "Havregryn, 4 dl"};
            Recipe chokladbollarRecipe = new Recipe("Chokladbollar", 8, "Desserts", chokladbollarIngredients,
                                                    "Blanda alla ingredienser.\r\nForma runda bollar och rulla dem i kokos eller pärlsocker." +
                                                    "\r\nFörvara i kylen.");
            recipeManager.allRecipes.Add(chokladbollarRecipe);

            //Tzatziki
            List<string> tzatzikiIngredients = new List<string>()
            { "Grekisk yoghurt, 3 dl", "Gurka, 1 st", "Vitlök, 1 klyfta", "Salt", "Peppar" };
            Recipe tzatzikiRecipe = new Recipe("Tzatziki", 4, "Sauces", tzatzikiIngredients,
                                               "Riv gurkan, salta och lägg den i en sil så att vätskan rinner av.\r\n Pressa vitlöksklyftan." +
                                               "\r\nBlanda alla ingredienser och salta och peppra efter smak.");
            recipeManager.allRecipes.Add(tzatzikiRecipe);
        }


        //Event handling
        //Opens new window that shows existing recipes
        private void ViewRecipesButton_Click(object sender, EventArgs e)
        {
            if (recipeManager.allRecipes.Count != 0)
            {
                viewRecipesForm = new ViewRecipesForm();
                viewRecipesForm.recipeManager = recipeManager;
                viewRecipesForm.mainMenu = this;
                viewRecipesForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You don't have any recipes yet");
            }
        }


        //Opens new window where you can add new recipes
        private void AddNewRecipeButton_Click(object sender, EventArgs e)
        {
            addNewRecipeForm = new AddNewRecipeForm();
            addNewRecipeForm.recipeManager = recipeManager;
            addNewRecipeForm.Show();
            addNewRecipeForm.mainMenu = this;
            Hide();
        }


        //Closes application after user's confirmation
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                Show();
            }
        }
    }
}