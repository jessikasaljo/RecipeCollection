namespace RecipeCollection
{
    partial class AddNewRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRecipeForm));
            recipeNameLabel = new Label();
            recipeNameBox = new TextBox();
            servingsLabel = new Label();
            servingsCount = new NumericUpDown();
            categoryLabel = new Label();
            categoryListbox = new ListBox();
            doneButton = new Button();
            ingredientsLabel = new Label();
            addIngredientBox = new TextBox();
            ingredientToListButton = new Button();
            ingredientsListbox = new ListBox();
            instructionsLabel = new Label();
            GoBackButton = new Button();
            instructionsBox = new TextBox();
            removeIngredientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)servingsCount).BeginInit();
            SuspendLayout();
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            recipeNameLabel.Location = new Point(35, 75);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(94, 18);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "Recipe name";
            // 
            // recipeNameBox
            // 
            recipeNameBox.BackColor = Color.LavenderBlush;
            recipeNameBox.BorderStyle = BorderStyle.FixedSingle;
            recipeNameBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            recipeNameBox.Location = new Point(35, 96);
            recipeNameBox.Name = "recipeNameBox";
            recipeNameBox.PlaceholderText = "Enter name of recipe";
            recipeNameBox.Size = new Size(220, 26);
            recipeNameBox.TabIndex = 1;
            // 
            // servingsLabel
            // 
            servingsLabel.AutoSize = true;
            servingsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servingsLabel.Location = new Point(35, 141);
            servingsLabel.Name = "servingsLabel";
            servingsLabel.Size = new Size(141, 18);
            servingsLabel.TabIndex = 2;
            servingsLabel.Text = "Number of servings";
            // 
            // servingsCount
            // 
            servingsCount.BackColor = Color.LavenderBlush;
            servingsCount.BorderStyle = BorderStyle.FixedSingle;
            servingsCount.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servingsCount.Location = new Point(38, 162);
            servingsCount.Margin = new Padding(2, 3, 2, 3);
            servingsCount.Name = "servingsCount";
            servingsCount.Size = new Size(62, 26);
            servingsCount.TabIndex = 3;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(35, 210);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(67, 18);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // categoryListbox
            // 
            categoryListbox.BackColor = Color.LavenderBlush;
            categoryListbox.BorderStyle = BorderStyle.FixedSingle;
            categoryListbox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryListbox.FormattingEnabled = true;
            categoryListbox.ItemHeight = 18;
            categoryListbox.Items.AddRange(new object[] { "Entrées", "Main courses", "Desserts", "Side dishes", "Sauces" });
            categoryListbox.Location = new Point(35, 231);
            categoryListbox.Name = "categoryListbox";
            categoryListbox.Size = new Size(152, 92);
            categoryListbox.TabIndex = 5;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.LavenderBlush;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            doneButton.Location = new Point(800, 569);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(93, 38);
            doneButton.TabIndex = 6;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += DoneButton_Click;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ingredientsLabel.Location = new Point(309, 75);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(83, 18);
            ingredientsLabel.TabIndex = 7;
            ingredientsLabel.Text = "Ingredients";
            // 
            // addIngredientBox
            // 
            addIngredientBox.BackColor = Color.LavenderBlush;
            addIngredientBox.BorderStyle = BorderStyle.FixedSingle;
            addIngredientBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addIngredientBox.Location = new Point(309, 96);
            addIngredientBox.Name = "addIngredientBox";
            addIngredientBox.PlaceholderText = "Ex. Olive oil, 1 tsp";
            addIngredientBox.Size = new Size(220, 26);
            addIngredientBox.TabIndex = 8;
            // 
            // ingredientToListButton
            // 
            ingredientToListButton.BackColor = Color.LavenderBlush;
            ingredientToListButton.FlatStyle = FlatStyle.Flat;
            ingredientToListButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ingredientToListButton.ImageAlign = ContentAlignment.MiddleLeft;
            ingredientToListButton.Location = new Point(309, 130);
            ingredientToListButton.Name = "ingredientToListButton";
            ingredientToListButton.Size = new Size(220, 31);
            ingredientToListButton.TabIndex = 9;
            ingredientToListButton.Text = "Add ingredient to list";
            ingredientToListButton.TextAlign = ContentAlignment.MiddleLeft;
            ingredientToListButton.UseVisualStyleBackColor = false;
            ingredientToListButton.Click += IngredientToListButton_Click;
            // 
            // ingredientsListbox
            // 
            ingredientsListbox.BackColor = Color.LavenderBlush;
            ingredientsListbox.BorderStyle = BorderStyle.FixedSingle;
            ingredientsListbox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ingredientsListbox.FormattingEnabled = true;
            ingredientsListbox.ItemHeight = 18;
            ingredientsListbox.Location = new Point(309, 210);
            ingredientsListbox.Name = "ingredientsListbox";
            ingredientsListbox.Size = new Size(251, 344);
            ingredientsListbox.TabIndex = 10;
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsLabel.Location = new Point(613, 75);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(87, 18);
            instructionsLabel.TabIndex = 11;
            instructionsLabel.Text = "Instructions";
            // 
            // GoBackButton
            // 
            GoBackButton.BackColor = Color.LavenderBlush;
            GoBackButton.BackgroundImage = (Image)resources.GetObject("GoBackButton.BackgroundImage");
            GoBackButton.BackgroundImageLayout = ImageLayout.Zoom;
            GoBackButton.FlatStyle = FlatStyle.Flat;
            GoBackButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackButton.Location = new Point(35, 13);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(50, 27);
            GoBackButton.TabIndex = 13;
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // instructionsBox
            // 
            instructionsBox.BackColor = Color.LavenderBlush;
            instructionsBox.BorderStyle = BorderStyle.FixedSingle;
            instructionsBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsBox.Location = new Point(613, 96);
            instructionsBox.MaximumSize = new Size(280, 460);
            instructionsBox.MinimumSize = new Size(280, 460);
            instructionsBox.Multiline = true;
            instructionsBox.Name = "instructionsBox";
            instructionsBox.Size = new Size(280, 460);
            instructionsBox.TabIndex = 14;
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.BackColor = Color.LavenderBlush;
            removeIngredientButton.FlatStyle = FlatStyle.Flat;
            removeIngredientButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeIngredientButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeIngredientButton.Location = new Point(309, 171);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(220, 31);
            removeIngredientButton.TabIndex = 15;
            removeIngredientButton.Text = "Remove selected ingredient";
            removeIngredientButton.TextAlign = ContentAlignment.MiddleLeft;
            removeIngredientButton.UseVisualStyleBackColor = false;
            removeIngredientButton.Click += RemoveIngredientButton_Click;
            // 
            // AddNewRecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(935, 621);
            Controls.Add(removeIngredientButton);
            Controls.Add(instructionsBox);
            Controls.Add(GoBackButton);
            Controls.Add(instructionsLabel);
            Controls.Add(ingredientsListbox);
            Controls.Add(ingredientToListButton);
            Controls.Add(addIngredientBox);
            Controls.Add(ingredientsLabel);
            Controls.Add(doneButton);
            Controls.Add(categoryListbox);
            Controls.Add(categoryLabel);
            Controls.Add(servingsCount);
            Controls.Add(servingsLabel);
            Controls.Add(recipeNameBox);
            Controls.Add(recipeNameLabel);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewRecipeForm";
            Text = "Create new recipe";
            FormClosing += AddNewRecipeForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)servingsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label recipeNameLabel;
        private TextBox recipeNameBox;
        private Label servingsLabel;
        private NumericUpDown servingsCount;
        private Label categoryLabel;
        private ListBox categoryListbox;
        private Button doneButton;
        private Label ingredientsLabel;
        private TextBox addIngredientBox;
        private Button ingredientToListButton;
        private ListBox ingredientsListbox;
        private Label instructionsLabel;
        private Button GoBackButton;
        private TextBox instructionsBox;
        private Button removeIngredientButton;
    }
}