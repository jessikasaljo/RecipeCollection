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
            { "�gg, 3 st", "Mj�l, 3 dl", "Mj�lk, 6 dl" };
            Recipe pannkakorRecipe = new Recipe("Pannkakor", 4, "Main courses", pannkakorIngredients,
                                              "Vispa mj�l och h�lften av mj�lken.\r\nTills�tt resten av mj�lken och �ggen och vispa igen." +
                                              "\r\nHetta upp en panna med sm�r och stek en knapp dl smet �t g�ngen.\r\nServera med sylt och gr�dde.");
            recipeManager.allRecipes.Add(pannkakorRecipe);

            //Chokladbollar
            List<string> chokladbollarIngredients = new List<string>()
            { "Sm�r, 150 g", "Str�socker, 1.5 dl", "Kakao, 3 msk", "Vaniljsocker, 1 tsk", "Kallt kaffe, 2 msk", "Havregryn, 4 dl"};
            Recipe chokladbollarRecipe = new Recipe("Chokladbollar", 8, "Desserts", chokladbollarIngredients,
                                                    "Blanda alla ingredienser.\r\nForma runda bollar och rulla dem i kokos eller p�rlsocker." +
                                                    "\r\nF�rvara i kylen.");
            recipeManager.allRecipes.Add(chokladbollarRecipe);

            //Tzatziki
            List<string> tzatzikiIngredients = new List<string>()
            { "Grekisk yoghurt, 3 dl", "Gurka, 1 st", "Vitl�k, 1 klyfta", "Salt", "Peppar" };
            Recipe tzatzikiRecipe = new Recipe("Tzatziki", 4, "Sauces", tzatzikiIngredients,
                                               "Riv gurkan, salta och l�gg den i en sil s� att v�tskan rinner av.\r\n Pressa vitl�ksklyftan." +
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