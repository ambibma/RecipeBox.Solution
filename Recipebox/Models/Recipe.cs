using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace RecipeBox.Models 
{
    public class Recipe
    {
        public int RecipeId {get; set; }
        public  string Name {get;set;}
        public string Instructions {get; set; }
        public int Ratings {get; set; }
        public ApplicationUser User { get; set; }
        
        public List<Ingredient> Ingredients {get; set; } = new List<Ingredient>();
        public List<RecipeTag> JoinEntities {get; set; }
    }

   
   
   
    // string ingredients = "tomato, onion, rice, garlic"
        // int counter = 0;
      // foreach(ing in ingredients)
        //{   //counter++
          //    ingredient[counter] = newIngredient[counter]
              // select(" ") = counter++;
        //}
}