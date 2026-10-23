using System;
using System.Windows.Forms;

namespace PotionBrewingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Manage Ingredients
        private void button1_Click(object sender, EventArgs e)
        {
            IngredientForm form = new IngredientForm();
            form.ShowDialog();
        }

        // Manage Recipes
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            RecipeForm form = new RecipeForm();
            form.ShowDialog();
        }

        // Brew Potions
        private void btnBrewing_Click(object sender, EventArgs e)
        {
            BrewingForm form = new BrewingForm();
            form.ShowDialog();
        }
    }
}