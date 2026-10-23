using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotionBrewingSystem.Models;

namespace PotionBrewingSystem.Repositories
{
    public class IngredientRepository
    {
        public List<Ingredient> GetAll()
        {
            using (var db = new PotionContext())
            {
                return db.Ingredients.ToList();
            }
        }
        public void Add(Ingredient ingredient)
        {
            using (var db = new PotionContext())
            {
                db.Ingredients.Add(ingredient);
                db.SaveChanges();
            }
        }
        public void Update(Ingredient ingredient)
        {
            using (var db = new PotionContext())
            {
                db.Ingredients.Update(ingredient);
                db.SaveChanges();
            }
        }
        public bool Delete(int id)
        {
            using (var db = new PotionContext())
            {
                bool isUsed = db.RecipeIngredients
                    .Any(r => r.IngredientId == id && r.Recipe.IsActive);

                if (isUsed)
                {
                    return false;
                }
                Ingredient? ingredient = db.Ingredients.Find(id);

                if (ingredient != null)
                {
                    db.Ingredients.Remove(ingredient);
                    db.SaveChanges();
                }
                return true;
            }
        }
    }
}