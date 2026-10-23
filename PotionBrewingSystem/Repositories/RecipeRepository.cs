using System.Collections.Generic;
using System.Linq;
using PotionBrewingSystem.Models;

namespace PotionBrewingSystem.Repositories
{
    public class RecipeRepository
    {
        public List<Recipe> GetAll()
        {
            using (var db = new PotionContext())
            {
                return db.Recipes.ToList();
            }
        }
        public void Add(Recipe recipe, List<RecipeIngredient> ingredients)
        {
            using (var db = new PotionContext())
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();

                foreach (RecipeIngredient item in ingredients)
                {
                    RecipeIngredient newItem = new RecipeIngredient();

                    newItem.RecipeId = recipe.Id;
                    newItem.IngredientId = item.IngredientId;
                    newItem.QuantityRequired = item.QuantityRequired;

                    db.RecipeIngredients.Add(newItem);
                }

                db.SaveChanges();
            }
        }
    }
}