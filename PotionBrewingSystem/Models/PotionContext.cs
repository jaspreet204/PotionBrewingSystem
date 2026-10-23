using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PotionBrewingSystem.Models
{
    public class PotionContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<BrewedPotion> BrewedPotions { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=potions.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(r => r.Recipe)
                .WithMany()
                .HasForeignKey(r => r.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(r => r.Ingredient)
                .WithMany()
                .HasForeignKey(r => r.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BrewedPotion>()
                .HasOne<Recipe>()
                .WithMany()
                .HasForeignKey(p => p.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}