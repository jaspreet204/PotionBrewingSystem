namespace PotionBrewingSystem
{
    partial class RecipeForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblRecipeName = new Label();
            txtName = new TextBox();
            lblDuration = new Label();
            numDuration = new NumericUpDown();
            lblIngredient = new Label();
            cmbIngredients = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAddIngredient = new Button();
            btnSaveRecipe = new Button();
            btnUpdateRecipe = new Button();
            btnDeleteRecipe = new Button();
            btnRefreshRecipes = new Button();
            dgvRecipeIngredients = new DataGridView();
            dgvRecipes = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();

            SuspendLayout();

            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(37, 28);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(98, 20);
            lblRecipeName.Text = "Recipe Name";

            txtName.Location = new Point(157, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);

            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(349, 32);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(194, 20);
            lblDuration.Text = "Brewing Duration (Seconds)";

            numDuration.Location = new Point(571, 25);
            numDuration.Maximum = 3600;
            numDuration.Minimum = 1;
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(150, 27);
            numDuration.Value = 10;

            lblIngredient.AutoSize = true;
            lblIngredient.Location = new Point(37, 92);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(121, 20);
            lblIngredient.Text = "Select Ingredient";

            cmbIngredients.FormattingEnabled = true;
            cmbIngredients.Location = new Point(157, 84);
            cmbIngredients.Name = "cmbIngredients";
            cmbIngredients.Size = new Size(151, 28);
            cmbIngredients.DropDownStyle = ComboBoxStyle.DropDownList;

     
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(349, 92);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(129, 20);
            lblQuantity.Text = "Quantity Required";

            numQuantity.Location = new Point(571, 82);
            numQuantity.Maximum = 1000;
            numQuantity.Minimum = 1;
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.Value = 1;

            btnAddIngredient.Location = new Point(37, 384);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(120, 29);
            btnAddIngredient.Text = "Add Ingredient";
            btnAddIngredient.UseVisualStyleBackColor = true;
            btnAddIngredient.Click += btnAddIngredient_Click;


            btnSaveRecipe.Location = new Point(188, 384);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(120, 29);
            btnSaveRecipe.Text = "Save Recipe";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;


            btnUpdateRecipe.Location = new Point(349, 384);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(120, 29);
            btnUpdateRecipe.Text = "Update Recipe";
            btnUpdateRecipe.UseVisualStyleBackColor = true;
            btnUpdateRecipe.Enabled = false;

            btnDeleteRecipe.Location = new Point(520, 384);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(120, 29);
            btnDeleteRecipe.Text = "Retire Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            btnDeleteRecipe.Enabled = false;

     
            btnRefreshRecipes.Location = new Point(696, 384);
            btnRefreshRecipes.Name = "btnRefreshRecipes";
            btnRefreshRecipes.Size = new Size(94, 29);
            btnRefreshRecipes.Text = "Refresh";
            btnRefreshRecipes.UseVisualStyleBackColor = true;
            btnRefreshRecipes.Click += btnRefreshRecipes_Click;

            dgvRecipeIngredients.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipeIngredients.Location = new Point(37, 432);
            dgvRecipeIngredients.Name = "dgvRecipeIngredients";
            dgvRecipeIngredients.RowHeadersWidth = 51;
            dgvRecipeIngredients.Size = new Size(753, 149);
            dgvRecipeIngredients.ReadOnly = true;
            dgvRecipeIngredients.AllowUserToAddRows = false;
            dgvRecipeIngredients.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            dgvRecipes.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Location = new Point(37, 146);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.RowHeadersWidth = 51;
            dgvRecipes.Size = new Size(744, 188);
            dgvRecipes.ReadOnly = true;
            dgvRecipes.AllowUserToAddRows = false;
            dgvRecipes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 603);

            Controls.Add(dgvRecipes);
            Controls.Add(dgvRecipeIngredients);
            Controls.Add(btnRefreshRecipes);
            Controls.Add(btnDeleteRecipe);
            Controls.Add(btnUpdateRecipe);
            Controls.Add(btnSaveRecipe);
            Controls.Add(btnAddIngredient);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbIngredients);
            Controls.Add(lblIngredient);
            Controls.Add(numDuration);
            Controls.Add(lblDuration);
            Controls.Add(txtName);
            Controls.Add(lblRecipeName);

            Name = "RecipeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Potion Recipes";
            Load += RecipeForm_Load;

            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipeName;
        private TextBox txtName;
        private Label lblDuration;
        private NumericUpDown numDuration;
        private Label lblIngredient;
        private ComboBox cmbIngredients;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAddIngredient;
        private Button btnSaveRecipe;
        private Button btnUpdateRecipe;
        private Button btnDeleteRecipe;
        private Button btnRefreshRecipes;
        private DataGridView dgvRecipeIngredients;
        private DataGridView dgvRecipes;
    }
}