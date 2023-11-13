namespace RecipeCollection
{
    partial class RecipeDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetailsForm));
            recipeNameLabel = new Label();
            servingsLabel = new Label();
            categoryLabel = new Label();
            ingredientsLabel = new Label();
            instructionsLabel = new Label();
            allIngredientsLabel = new Label();
            allInstructionsLabel = new Label();
            goBackButton = new Button();
            editButton = new Button();
            removeButton = new Button();
            detailsPanel = new Panel();
            editPanel = new Panel();
            removeIngredientButton = new Button();
            addIngredientBox = new TextBox();
            ingredientToListButton = new Button();
            editIngredientsBox = new ListBox();
            servingsNumeric = new NumericUpDown();
            categoryCombobox = new ComboBox();
            recipeTextbox = new TextBox();
            instructionsTextbox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            DoneButton = new Button();
            label7 = new Label();
            detailsPanel.SuspendLayout();
            editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servingsNumeric).BeginInit();
            SuspendLayout();
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            recipeNameLabel.Location = new Point(300, 1);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(176, 34);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "Recipe name";
            // 
            // servingsLabel
            // 
            servingsLabel.AutoSize = true;
            servingsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servingsLabel.Location = new Point(17, 65);
            servingsLabel.Name = "servingsLabel";
            servingsLabel.Size = new Size(67, 18);
            servingsLabel.TabIndex = 1;
            servingsLabel.Text = "Servings";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(17, 92);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(67, 18);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ingredientsLabel.Location = new Point(17, 122);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(86, 18);
            ingredientsLabel.TabIndex = 5;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsLabel.Location = new Point(369, 122);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(90, 18);
            instructionsLabel.TabIndex = 6;
            instructionsLabel.Text = "Instructions:";
            // 
            // allIngredientsLabel
            // 
            allIngredientsLabel.AutoEllipsis = true;
            allIngredientsLabel.BackColor = Color.LavenderBlush;
            allIngredientsLabel.BorderStyle = BorderStyle.FixedSingle;
            allIngredientsLabel.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            allIngredientsLabel.Location = new Point(17, 149);
            allIngredientsLabel.MaximumSize = new Size(325, 550);
            allIngredientsLabel.MinimumSize = new Size(325, 550);
            allIngredientsLabel.Name = "allIngredientsLabel";
            allIngredientsLabel.Padding = new Padding(2, 1, 1, 1);
            allIngredientsLabel.Size = new Size(325, 550);
            allIngredientsLabel.TabIndex = 7;
            allIngredientsLabel.Text = "Ingredients";
            // 
            // allInstructionsLabel
            // 
            allInstructionsLabel.AutoEllipsis = true;
            allInstructionsLabel.BackColor = Color.LavenderBlush;
            allInstructionsLabel.BorderStyle = BorderStyle.FixedSingle;
            allInstructionsLabel.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            allInstructionsLabel.Location = new Point(369, 149);
            allInstructionsLabel.MaximumSize = new Size(399, 550);
            allInstructionsLabel.MinimumSize = new Size(399, 550);
            allInstructionsLabel.Name = "allInstructionsLabel";
            allInstructionsLabel.Padding = new Padding(2, 1, 1, 1);
            allInstructionsLabel.Size = new Size(399, 550);
            allInstructionsLabel.TabIndex = 8;
            allInstructionsLabel.Text = "Instructions";
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.LavenderBlush;
            goBackButton.BackgroundImage = (Image)resources.GetObject("goBackButton.BackgroundImage");
            goBackButton.BackgroundImageLayout = ImageLayout.Zoom;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.Location = new Point(17, 0);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(67, 27);
            goBackButton.TabIndex = 9;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LavenderBlush;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(675, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(93, 38);
            editButton.TabIndex = 10;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.LavenderBlush;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.Location = new Point(675, 55);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(93, 38);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += RemoveRecipeButton_Click;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(goBackButton);
            detailsPanel.Controls.Add(allInstructionsLabel);
            detailsPanel.Controls.Add(instructionsLabel);
            detailsPanel.Controls.Add(removeButton);
            detailsPanel.Controls.Add(allIngredientsLabel);
            detailsPanel.Controls.Add(recipeNameLabel);
            detailsPanel.Controls.Add(ingredientsLabel);
            detailsPanel.Controls.Add(editButton);
            detailsPanel.Controls.Add(categoryLabel);
            detailsPanel.Controls.Add(servingsLabel);
            detailsPanel.Location = new Point(12, 12);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(783, 709);
            detailsPanel.TabIndex = 12;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(removeIngredientButton);
            editPanel.Controls.Add(addIngredientBox);
            editPanel.Controls.Add(ingredientToListButton);
            editPanel.Controls.Add(editIngredientsBox);
            editPanel.Controls.Add(servingsNumeric);
            editPanel.Controls.Add(categoryCombobox);
            editPanel.Controls.Add(recipeTextbox);
            editPanel.Controls.Add(instructionsTextbox);
            editPanel.Controls.Add(label2);
            editPanel.Controls.Add(label5);
            editPanel.Controls.Add(DoneButton);
            editPanel.Controls.Add(label7);
            editPanel.Location = new Point(12, 9);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(783, 709);
            editPanel.TabIndex = 13;
            editPanel.Visible = false;
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.BackColor = Color.LavenderBlush;
            removeIngredientButton.FlatStyle = FlatStyle.Flat;
            removeIngredientButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeIngredientButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeIngredientButton.Location = new Point(17, 228);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(220, 31);
            removeIngredientButton.TabIndex = 19;
            removeIngredientButton.Text = "Remove selected ingredient";
            removeIngredientButton.TextAlign = ContentAlignment.MiddleLeft;
            removeIngredientButton.UseVisualStyleBackColor = false;
            removeIngredientButton.Click += RemoveIngredientButton_Click;
            // 
            // addIngredientBox
            // 
            addIngredientBox.BackColor = Color.LavenderBlush;
            addIngredientBox.BorderStyle = BorderStyle.FixedSingle;
            addIngredientBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addIngredientBox.Location = new Point(17, 152);
            addIngredientBox.Name = "addIngredientBox";
            addIngredientBox.PlaceholderText = "Ex. Olive oil, 1 tsp";
            addIngredientBox.Size = new Size(220, 26);
            addIngredientBox.TabIndex = 18;
            // 
            // ingredientToListButton
            // 
            ingredientToListButton.BackColor = Color.LavenderBlush;
            ingredientToListButton.FlatStyle = FlatStyle.Flat;
            ingredientToListButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ingredientToListButton.ImageAlign = ContentAlignment.MiddleLeft;
            ingredientToListButton.Location = new Point(17, 187);
            ingredientToListButton.Name = "ingredientToListButton";
            ingredientToListButton.Size = new Size(220, 31);
            ingredientToListButton.TabIndex = 17;
            ingredientToListButton.Text = "Add ingredient to list";
            ingredientToListButton.TextAlign = ContentAlignment.MiddleLeft;
            ingredientToListButton.UseVisualStyleBackColor = false;
            ingredientToListButton.Click += IngredientToListButton_Click;
            // 
            // editIngredientsBox
            // 
            editIngredientsBox.BackColor = Color.LavenderBlush;
            editIngredientsBox.BorderStyle = BorderStyle.FixedSingle;
            editIngredientsBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editIngredientsBox.FormattingEnabled = true;
            editIngredientsBox.ItemHeight = 18;
            editIngredientsBox.Location = new Point(17, 268);
            editIngredientsBox.MaximumSize = new Size(325, 450);
            editIngredientsBox.MinimumSize = new Size(325, 450);
            editIngredientsBox.Name = "editIngredientsBox";
            editIngredientsBox.Size = new Size(325, 434);
            editIngredientsBox.TabIndex = 16;
            // 
            // servingsNumeric
            // 
            servingsNumeric.BackColor = Color.LavenderBlush;
            servingsNumeric.BorderStyle = BorderStyle.FixedSingle;
            servingsNumeric.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            servingsNumeric.Location = new Point(90, 57);
            servingsNumeric.Name = "servingsNumeric";
            servingsNumeric.Size = new Size(64, 26);
            servingsNumeric.TabIndex = 15;
            // 
            // categoryCombobox
            // 
            categoryCombobox.BackColor = Color.LavenderBlush;
            categoryCombobox.FlatStyle = FlatStyle.Flat;
            categoryCombobox.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Items.AddRange(new object[] { "Entrées", "Main courses", "Desserts", "Side dishes", "Sauces" });
            categoryCombobox.Location = new Point(17, 92);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(151, 26);
            categoryCombobox.TabIndex = 14;
            categoryCombobox.Text = "Category";
            // 
            // recipeTextbox
            // 
            recipeTextbox.BackColor = Color.LavenderBlush;
            recipeTextbox.BorderStyle = BorderStyle.FixedSingle;
            recipeTextbox.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            recipeTextbox.Location = new Point(232, 3);
            recipeTextbox.MinimumSize = new Size(280, 34);
            recipeTextbox.Name = "recipeTextbox";
            recipeTextbox.PlaceholderText = "Recipe name";
            recipeTextbox.Size = new Size(280, 40);
            recipeTextbox.TabIndex = 13;
            recipeTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // instructionsTextbox
            // 
            instructionsTextbox.BackColor = Color.LavenderBlush;
            instructionsTextbox.BorderStyle = BorderStyle.FixedSingle;
            instructionsTextbox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsTextbox.Location = new Point(369, 152);
            instructionsTextbox.MaximumSize = new Size(399, 550);
            instructionsTextbox.MinimumSize = new Size(399, 550);
            instructionsTextbox.Multiline = true;
            instructionsTextbox.Name = "instructionsTextbox";
            instructionsTextbox.Size = new Size(399, 550);
            instructionsTextbox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(369, 125);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 6;
            label2.Text = "Instructions:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 125);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 5;
            label5.Text = "Ingredients";
            // 
            // DoneButton
            // 
            DoneButton.BackColor = Color.LavenderBlush;
            DoneButton.FlatStyle = FlatStyle.Flat;
            DoneButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DoneButton.Location = new Point(675, 3);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(93, 38);
            DoneButton.TabIndex = 10;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += DoneButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 60);
            label7.Name = "label7";
            label7.Size = new Size(70, 18);
            label7.TabIndex = 1;
            label7.Text = "Servings:";
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(807, 732);
            Controls.Add(editPanel);
            Controls.Add(detailsPanel);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RecipeDetailsForm";
            Text = "Recipe details";
            FormClosing += RecipeDetailsForm_FormClosing;
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servingsNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label recipeNameLabel;
        private Label servingsLabel;
        private Label categoryLabel;
        private Label ingredientsLabel;
        private Label instructionsLabel;
        private Label allIngredientsLabel;
        private Label allInstructionsLabel;
        private Button goBackButton;
        private Button editButton;
        private Button removeButton;
        private Panel detailsPanel;
        private Panel editPanel;
        private Button removeIngredientButton;
        private Label label2;
        private Label label5;
        private Button DoneButton;
        private Label label7;
        private TextBox instructionsTextbox;
        private TextBox recipeTextbox;
        private ComboBox categoryCombobox;
        private NumericUpDown servingsNumeric;
        private ListBox editIngredientsBox;
        private Button ingredientToListButton;
        private TextBox addIngredientBox;
    }
}