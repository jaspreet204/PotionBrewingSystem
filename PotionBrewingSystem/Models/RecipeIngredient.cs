using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PotionBrewingSystem.Models
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int QuantityRequired { get; set; }

        public Recipe Recipe { get; set; } = null!;
        public Ingredient Ingredient { get; set; } = null!;
    }
}