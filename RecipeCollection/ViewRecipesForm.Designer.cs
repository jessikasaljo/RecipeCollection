namespace RecipeCollection
{
    partial class ViewRecipesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipesForm));
            recipeBox = new ListBox();
            goBackButton = new Button();
            openRecipeButton = new Button();
            editRecipeButton = new Button();
            removeRecipeButton = new Button();
            filterButton = new Button();
            filterCombobox = new ComboBox();
            SuspendLayout();
            // 
            // recipeBox
            // 
            recipeBox.BackColor = Color.LavenderBlush;
            recipeBox.BorderStyle = BorderStyle.FixedSingle;
            recipeBox.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            recipeBox.FormattingEnabled = true;
            recipeBox.ItemHeight = 18;
            recipeBox.Location = new Point(28, 106);
            recipeBox.Name = "recipeBox";
            recipeBox.Size = new Size(339, 344);
            recipeBox.Sorted = true;
            recipeBox.TabIndex = 0;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.LavenderBlush;
            goBackButton.BackgroundImage = Resources.BackArrow.arrowheadleft_110946;
            goBackButton.BackgroundImageLayout = ImageLayout.Zoom;
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.Location = new Point(28, 11);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(50, 27);
            goBackButton.TabIndex = 1;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButton_Click;
            // 
            // openRecipeButton
            // 
            openRecipeButton.BackColor = Color.LavenderBlush;
            openRecipeButton.FlatStyle = FlatStyle.Flat;
            openRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openRecipeButton.Location = new Point(28, 463);
            openRecipeButton.Name = "openRecipeButton";
            openRecipeButton.Size = new Size(93, 38);
            openRecipeButton.TabIndex = 2;
            openRecipeButton.Text = "Open";
            openRecipeButton.UseVisualStyleBackColor = false;
            openRecipeButton.Click += OpenRecipeButton_Click;
            // 
            // editRecipeButton
            // 
            editRecipeButton.BackColor = Color.LavenderBlush;
            editRecipeButton.FlatStyle = FlatStyle.Flat;
            editRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editRecipeButton.Location = new Point(153, 463);
            editRecipeButton.Name = "editRecipeButton";
            editRecipeButton.Size = new Size(93, 38);
            editRecipeButton.TabIndex = 3;
            editRecipeButton.Text = "Edit";
            editRecipeButton.UseVisualStyleBackColor = false;
            editRecipeButton.Click += EditRecipeButton_Click;
            // 
            // removeRecipeButton
            // 
            removeRecipeButton.BackColor = Color.LavenderBlush;
            removeRecipeButton.FlatStyle = FlatStyle.Flat;
            removeRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeRecipeButton.Location = new Point(274, 463);
            removeRecipeButton.Name = "removeRecipeButton";
            removeRecipeButton.Size = new Size(93, 38);
            removeRecipeButton.TabIndex = 4;
            removeRecipeButton.Text = "Remove";
            removeRecipeButton.UseVisualStyleBackColor = false;
            removeRecipeButton.Click += RemoveRecipeButton_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.LavenderBlush;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterButton.Location = new Point(194, 64);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(106, 30);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter recipes";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += FilterButton_Click;
            // 
            // filterCombobox
            // 
            filterCombobox.BackColor = Color.LavenderBlush;
            filterCombobox.FlatStyle = FlatStyle.Flat;
            filterCombobox.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterCombobox.FormattingEnabled = true;
            filterCombobox.ImeMode = ImeMode.On;
            filterCombobox.Location = new Point(28, 66);
            filterCombobox.Name = "filterCombobox";
            filterCombobox.Size = new Size(151, 26);
            filterCombobox.TabIndex = 6;
            filterCombobox.Text = "Filter by category";
            filterCombobox.KeyPress += FilterCombobox_KeyPress;
            // 
            // ViewRecipesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(396, 526);
            Controls.Add(filterCombobox);
            Controls.Add(filterButton);
            Controls.Add(removeRecipeButton);
            Controls.Add(editRecipeButton);
            Controls.Add(openRecipeButton);
            Controls.Add(goBackButton);
            Controls.Add(recipeBox);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewRecipesForm";
            Text = "Recipes";
            FormClosing += ViewRecipesForm_FormClosing;
            Load += ViewRecipesForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button goBackButton;
        private Button openRecipeButton;
        private Button editRecipeButton;
        private Button removeRecipeButton;
        private Button filterButton;
        private ComboBox filterCombobox;
        public ListBox recipeBox;
    }
}