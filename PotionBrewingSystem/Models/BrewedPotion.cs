using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionBrewingSystem.Models
{
    public class BrewedPotion
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string SpecialEffect { get; set; } = "";
        public DateTime BrewedDate { get; set; }
        public int RecipeId { get; set; }
    }
}