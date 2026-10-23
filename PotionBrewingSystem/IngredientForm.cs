using System;
using System.Windows.Forms;
using PotionBrewingSystem.Models;
using PotionBrewingSystem.Repositories;

namespace PotionBrewingSystem
{
    public partial class IngredientForm : Form
    {
        private int selectedId = 0;

        public IngredientForm()
        {
            InitializeComponent();

            LoadIngredients();
        }

        // Display all ingredients
        private void LoadIngredients()
        {
            IngredientRepository repo = new IngredientRepository();

            dgvIngredients.DataSource = null;
            dgvIngredients.DataSource = repo.GetAll();
        }

        // Add Ingredient
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an ingredient name.");
                return;
            }

            Ingredient ingredient = new Ingredient();

            ingredient.Name = txtName.Text.Trim();
            ingredient.StockQuantity = (int)numStock.Value;

            IngredientRepository repo = new IngredientRepository();
            repo.Add(ingredient);

            MessageBox.Show("Ingredient added successfully!");

            txtName.Clear();
            numStock.Value = 0;
            selectedId = 0;

            LoadIngredients();
        }

        // Update Ingredient
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an ingredient name.");
                return;
            }

            Ingredient ingredient = new Ingredient();

            ingredient.Id = selectedId;
            ingredient.Name = txtName.Text.Trim();
            ingredient.StockQuantity = (int)numStock.Value;

            IngredientRepository repo = new IngredientRepository();
            repo.Update(ingredient);

            MessageBox.Show("Ingredient updated!");

            selectedId = 0;
            txtName.Clear();
            numStock.Value = 0;

            LoadIngredients();
        }

        // Retire Ingredient
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            IngredientRepository repo = new IngredientRepository();

            bool deleted = repo.Delete(selectedId);

            if (deleted)
            {
                MessageBox.Show("Ingredient retired!");

                selectedId = 0;
                txtName.Clear();
                numStock.Value = 0;
            }
            else
            {
                MessageBox.Show(
                    "Cannot retire ingredient used in an active recipe.");
            }

            LoadIngredients();
        }

        // Refresh Ingredient List
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectedId = 0;
            txtName.Clear();
            numStock.Value = 0;

            LoadIngredients();
        }

        // Select Ingredient from DataGridView
        private void dgvIngredients_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvIngredients.Rows[e.RowIndex];

                if (row.Cells["Id"].Value == null)
                {
                    return;
                }

                selectedId =
                    Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text =
                    row.Cells["Name"].Value.ToString() ?? "";

                numStock.Value =
                    Convert.ToDecimal(
                        row.Cells["StockQuantity"].Value);
            }
        }
    }
}