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
            GoBackButton = new Button();
            OpenRecipeButton = new Button();
            EditRecipeButton = new Button();
            RemoveRecipeButton = new Button();
            FilterButton = new Button();
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
            recipeBox.TabIndex = 0;
            // 
            // GoBackButton
            // 
            GoBackButton.BackColor = Color.LavenderBlush;
            GoBackButton.BackgroundImage = Resources.BackArrow.arrowheadleft_110946;
            GoBackButton.BackgroundImageLayout = ImageLayout.Zoom;
            GoBackButton.FlatStyle = FlatStyle.Flat;
            GoBackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackButton.Location = new Point(28, 11);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(50, 27);
            GoBackButton.TabIndex = 1;
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // OpenRecipeButton
            // 
            OpenRecipeButton.BackColor = Color.LavenderBlush;
            OpenRecipeButton.FlatStyle = FlatStyle.Flat;
            OpenRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OpenRecipeButton.Location = new Point(28, 463);
            OpenRecipeButton.Name = "OpenRecipeButton";
            OpenRecipeButton.Size = new Size(93, 38);
            OpenRecipeButton.TabIndex = 2;
            OpenRecipeButton.Text = "Open";
            OpenRecipeButton.UseVisualStyleBackColor = false;
            OpenRecipeButton.Click += OpenRecipeButton_Click;
            // 
            // EditRecipeButton
            // 
            EditRecipeButton.BackColor = Color.LavenderBlush;
            EditRecipeButton.FlatStyle = FlatStyle.Flat;
            EditRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditRecipeButton.Location = new Point(153, 463);
            EditRecipeButton.Name = "EditRecipeButton";
            EditRecipeButton.Size = new Size(93, 38);
            EditRecipeButton.TabIndex = 3;
            EditRecipeButton.Text = "Edit";
            EditRecipeButton.UseVisualStyleBackColor = false;
            EditRecipeButton.Click += EditRecipeButton_Click;
            // 
            // RemoveRecipeButton
            // 
            RemoveRecipeButton.BackColor = Color.LavenderBlush;
            RemoveRecipeButton.FlatStyle = FlatStyle.Flat;
            RemoveRecipeButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveRecipeButton.Location = new Point(274, 463);
            RemoveRecipeButton.Name = "RemoveRecipeButton";
            RemoveRecipeButton.Size = new Size(93, 38);
            RemoveRecipeButton.TabIndex = 4;
            RemoveRecipeButton.Text = "Remove";
            RemoveRecipeButton.UseVisualStyleBackColor = false;
            RemoveRecipeButton.Click += RemoveRecipeButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.LavenderBlush;
            FilterButton.FlatStyle = FlatStyle.Flat;
            FilterButton.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FilterButton.Location = new Point(194, 64);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(106, 30);
            FilterButton.TabIndex = 5;
            FilterButton.Text = "Filter recipes";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // filterCombobox
            // 
            filterCombobox.BackColor = Color.LavenderBlush;
            filterCombobox.FlatStyle = FlatStyle.Flat;
            filterCombobox.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterCombobox.FormattingEnabled = true;
            filterCombobox.Location = new Point(28, 66);
            filterCombobox.Name = "filterCombobox";
            filterCombobox.Size = new Size(151, 26);
            filterCombobox.TabIndex = 6;
            filterCombobox.Text = "Filter by category";
            // 
            // ViewRecipesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(396, 526);
            Controls.Add(filterCombobox);
            Controls.Add(FilterButton);
            Controls.Add(RemoveRecipeButton);
            Controls.Add(EditRecipeButton);
            Controls.Add(OpenRecipeButton);
            Controls.Add(GoBackButton);
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
        private Button GoBackButton;
        private Button OpenRecipeButton;
        private Button EditRecipeButton;
        private Button RemoveRecipeButton;
        private Button FilterButton;
        private ComboBox filterCombobox;
        public ListBox recipeBox;
    }
}