using System.Collections.Generic;

namespace RecipeBox.Models 
{
    public class Recipe
    {
        public int RecipeId {get; set; }
        public List<string> Ingredients {get; set; }
        public string Instructions {get; set; }
        public int Ratings {get; set; }
        public List<RecipeTag> JoinEntities {get; set; }
    }
}