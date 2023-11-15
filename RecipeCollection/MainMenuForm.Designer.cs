namespace RecipeCollection
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            recipeCollectionLabel = new Label();
            viewRecipesButton = new Button();
            addNewRecipeButton = new Button();
            SuspendLayout();
            // 
            // recipeCollectionLabel
            // 
            recipeCollectionLabel.AutoSize = true;
            recipeCollectionLabel.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            recipeCollectionLabel.Location = new Point(160, 66);
            recipeCollectionLabel.Name = "recipeCollectionLabel";
            recipeCollectionLabel.Size = new Size(244, 36);
            recipeCollectionLabel.TabIndex = 0;
            recipeCollectionLabel.Text = "Recipe collection";
            // 
            // viewRecipesButton
            // 
            viewRecipesButton.BackColor = Color.LavenderBlush;
            viewRecipesButton.FlatStyle = FlatStyle.Flat;
            viewRecipesButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewRecipesButton.Location = new Point(140, 128);
            viewRecipesButton.Name = "viewRecipesButton";
            viewRecipesButton.Size = new Size(124, 48);
            viewRecipesButton.TabIndex = 1;
            viewRecipesButton.Text = "View recipes";
            viewRecipesButton.UseVisualStyleBackColor = false;
            viewRecipesButton.Click += ViewRecipesButton_Click;
            // 
            // addNewRecipeButton
            // 
            addNewRecipeButton.BackColor = Color.LavenderBlush;
            addNewRecipeButton.FlatStyle = FlatStyle.Flat;
            addNewRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addNewRecipeButton.Location = new Point(299, 128);
            addNewRecipeButton.Name = "addNewRecipeButton";
            addNewRecipeButton.Size = new Size(124, 48);
            addNewRecipeButton.TabIndex = 2;
            addNewRecipeButton.Text = "Add new recipe";
            addNewRecipeButton.UseVisualStyleBackColor = false;
            addNewRecipeButton.Click += AddNewRecipeButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(565, 296);
            Controls.Add(addNewRecipeButton);
            Controls.Add(viewRecipesButton);
            Controls.Add(recipeCollectionLabel);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenuForm";
            Text = "Main menu";
            FormClosing += MainMenu_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label recipeCollectionLabel;
        private Button viewRecipesButton;
        private Button addNewRecipeButton;
    }
}