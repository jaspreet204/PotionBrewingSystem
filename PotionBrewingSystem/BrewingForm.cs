using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotionBrewingSystem.Models;

namespace PotionBrewingSystem
{
    public partial class BrewingForm : Form
    {
        public BrewingForm()
        {
            InitializeComponent();

            LoadRecipes();
            LoadPotions();
        }

        private void LoadRecipes()
        {
            using (var db = new PotionContext())
            {
                cmbRecipes.DataSource = db.Recipes
                    .Where(r => r.IsActive)
                    .ToList();

                cmbRecipes.DisplayMember = "Name";
                cmbRecipes.ValueMember = "Id";
            }
        }

        private void LoadPotions()
        {
            using (var db = new PotionContext())
            {
                dgvPotions.DataSource = db.BrewedPotions
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.SpecialEffect,
                        p.BrewedDate
                    })
                    .ToList();
            }
        }

        private async void btnBrew_Click(object sender, EventArgs e)
        {
            Recipe? recipe = cmbRecipes.SelectedItem as Recipe;

            if (recipe == null)
            {
                MessageBox.Show("Please select a recipe.");
                return;
            }

            // Check ingredient stock
            using (var db = new PotionContext())
            {
                var requiredIngredients = db.RecipeIngredients
                    .Where(r => r.RecipeId == recipe.Id)
                    .ToList();

                if (requiredIngredients.Count == 0)
                {
                    MessageBox.Show("This recipe has no ingredients.");
                    return;
                }

                foreach (var item in requiredIngredients)
                {
                    Ingredient? ingredient = db.Ingredients
                        .Find(item.IngredientId);

                    if (ingredient == null ||
                        ingredient.StockQuantity < item.QuantityRequired)
                    {
                        MessageBox.Show("Not enough ingredients to brew.");
                        return;
                    }
                }
            }

            btnBrew.Enabled = false;
            progressBar1.Value = 0;
            lblStatus.Text = "Brewing...";

            int duration = recipe.BrewingDuration;

            for (int i = 1; i <= duration; i++)
            {
                await Task.Delay(1000);

                progressBar1.Value = i * 100 / duration;
            }

            // Save potion and deduct ingredients
            using (var db = new PotionContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    var requiredIngredients = db.RecipeIngredients
                        .Where(r => r.RecipeId == recipe.Id)
                        .ToList();

                    foreach (var item in requiredIngredients)
                    {
                        Ingredient? ingredient = db.Ingredients
                            .Find(item.IngredientId);

                        if (ingredient == null ||
                            ingredient.StockQuantity < item.QuantityRequired)
                        {
                            transaction.Rollback();

                            lblStatus.Text = "Not enough ingredients.";
                            btnBrew.Enabled = true;
                            return;
                        }

                        ingredient.StockQuantity -= item.QuantityRequired;
                    }

                    BrewedPotion potion = new BrewedPotion();

                    potion.Name = recipe.Name;
                    potion.SpecialEffect = "Magic Effect";
                    potion.BrewedDate = DateTime.Now;
                    potion.RecipeId = recipe.Id;

                    db.BrewedPotions.Add(potion);
                    db.SaveChanges();

                    transaction.Commit();
                }
            }

            lblStatus.Text = "Brewing Complete!";
            MessageBox.Show("Potion brewed successfully!");

            LoadPotions();
            btnBrew.Enabled = true;
        }
    }
}