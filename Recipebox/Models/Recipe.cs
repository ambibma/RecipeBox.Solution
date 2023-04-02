using System.Collections.Generic;
using System.Linq;
using System;

namespace RecipeBox.Models 
{
    public class Recipe
    {
        public int RecipeId {get; set; }
        public  string Name {get;set;}
        public string Instructions {get; set; }
        public int Ratings {get; set; }
        public string Ingredients {get; set; }
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