namespace PotionBrewingSystem
{
    partial class Form1
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
            btnIngredients = new Button();
            btnBrewing = new Button();
            btnDashboard = new Button();
            btnRecipes = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnIngredients
            // 
            btnIngredients.Location = new Point(300, 86);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(200, 45);
            btnIngredients.TabIndex = 0;
            btnIngredients.Text = "Manage Ingredients";
            btnIngredients.UseVisualStyleBackColor = true;
            btnIngredients.Click += button1_Click;
            // 
            // btnBrewing
            // 
            btnBrewing.Location = new Point(300, 213);
            btnBrewing.Name = "btnBrewing";
            btnBrewing.Size = new Size(200, 45);
            btnBrewing.TabIndex = 1;
            btnBrewing.Text = "Brew Potions";
            btnBrewing.UseVisualStyleBackColor = true;
            btnBrewing.Click += btnBrewing_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(300, 273);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnRecipes
            // 
            btnRecipes.Location = new Point(300, 152);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(200, 45);
            btnRecipes.TabIndex = 3;
            btnRecipes.Text = "Manage Recipes";
            btnRecipes.UseVisualStyleBackColor = true;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(259, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 46);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Potion Brewing System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnRecipes);
            Controls.Add(btnDashboard);
            Controls.Add(btnBrewing);
            Controls.Add(btnIngredients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngredients;
        private Button btnBrewing;
        private Button btnDashboard;
        private Button btnRecipes;
        private Label lblTitle;
    }
}
