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
            ViewRecipesButton = new Button();
            AddNewRecipeButton = new Button();
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
            // ViewRecipesButton
            // 
            ViewRecipesButton.BackColor = Color.LavenderBlush;
            ViewRecipesButton.FlatStyle = FlatStyle.Flat;
            ViewRecipesButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ViewRecipesButton.Location = new Point(140, 128);
            ViewRecipesButton.Name = "ViewRecipesButton";
            ViewRecipesButton.Size = new Size(124, 48);
            ViewRecipesButton.TabIndex = 1;
            ViewRecipesButton.Text = "View recipes";
            ViewRecipesButton.UseVisualStyleBackColor = false;
            ViewRecipesButton.Click += ViewRecipesButton_Click;
            // 
            // AddNewRecipeButton
            // 
            AddNewRecipeButton.BackColor = Color.LavenderBlush;
            AddNewRecipeButton.FlatStyle = FlatStyle.Flat;
            AddNewRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewRecipeButton.Location = new Point(299, 128);
            AddNewRecipeButton.Name = "AddNewRecipeButton";
            AddNewRecipeButton.Size = new Size(124, 48);
            AddNewRecipeButton.TabIndex = 2;
            AddNewRecipeButton.Text = "Add new recipe";
            AddNewRecipeButton.UseVisualStyleBackColor = false;
            AddNewRecipeButton.Click += AddNewRecipeButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(565, 296);
            Controls.Add(AddNewRecipeButton);
            Controls.Add(ViewRecipesButton);
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
        private Button ViewRecipesButton;
        private Button AddNewRecipeButton;
    }
}