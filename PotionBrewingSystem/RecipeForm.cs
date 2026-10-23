using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PotionBrewingSystem.Models;
using PotionBrewingSystem.Repositories;

namespace PotionBrewingSystem
{
    public partial class RecipeForm : Form
    {
        private List<RecipeIngredient> selectedIngredients =
            new List<RecipeIngredient>();

        public RecipeForm()
        {
            InitializeComponent();

            LoadIngredients();
            LoadRecipes();
        }

        // Load ingredients into ComboBox
        private void LoadIngredients()
        {
            IngredientRepository repo = new IngredientRepository();

            cmbIngredients.DataSource = repo.GetAll();
            cmbIngredients.DisplayMember = "Name";
            cmbIngredients.ValueMember = "Id";
        }

        // Display saved recipes
        private void LoadRecipes()
        {
            RecipeRepository repo = new RecipeRepository();

            dgvRecipes.DataSource = null;
            dgvRecipes.DataSource = repo.GetAll();
        }

        // Add ingredient to recipe
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            Ingredient? ingredient =
                cmbIngredients.SelectedItem as Ingredient;

            if (ingredient == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            int quantity = (int)numQuantity.Value;

            foreach (RecipeIngredient item in selectedIngredients)
            {
                if (item.IngredientId == ingredient.Id)
                {
                    MessageBox.Show("Ingredient already added.");
                    return;
                }
            }

            RecipeIngredient recipeIngredient =
                new RecipeIngredient();

            recipeIngredient.IngredientId = ingredient.Id;
            recipeIngredient.QuantityRequired = quantity;
            recipeIngredient.Ingredient = ingredient;

            selectedIngredients.Add(recipeIngredient);

            RefreshSelectedIngredients();
        }

        // Display selected ingredients
        private void RefreshSelectedIngredients()
        {
            var display = selectedIngredients.Select(item => new
            {
                Ingredient = item.Ingredient.Name,
                Quantity = item.QuantityRequired
            }).ToList();

            dgvRecipeIngredients.DataSource = null;
            dgvRecipeIngredients.DataSource = display;
        }

        // Save recipe
        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            if (selectedIngredients.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient.");
                return;
            }

            Recipe recipe = new Recipe();

            recipe.Name = txtName.Text.Trim();
            recipe.BrewingDuration = (int)numDuration.Value;
            recipe.IsActive = true;

            RecipeRepository repo = new RecipeRepository();

            repo.Add(recipe, selectedIngredients);

            MessageBox.Show("Recipe saved successfully!");

            selectedIngredients.Clear();
            txtName.Clear();
            numDuration.Value = numDuration.Minimum;

            RefreshSelectedIngredients();
            LoadRecipes();
        }

        // Refresh
        private void btnRefreshRecipes_Click(object sender, EventArgs e)
        {
            LoadIngredients();
            LoadRecipes();
        }

        // Required event handlers
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
        }
    }
}