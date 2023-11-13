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

            //Example recipe for testing the logic
            List<string> ingredients = new List<string>() { "Ägg, 3 st", "Mjöl, 3 dl", "Mjölk, 6 dl" };
            Recipe exampleRecipe = new Recipe("Example recipe", 4, "Main courses", ingredients, "Blanda allt.\r\nStek i smör.");
            recipeManager.allRecipes.Add(exampleRecipe);
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