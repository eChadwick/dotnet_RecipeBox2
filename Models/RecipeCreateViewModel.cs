using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox2.Models
{
    public class RecipeCreateViewModel
    {
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }

        public string Directions { get; set; }

        // public List<KeyValuePair<string, string>> Ingredients { get; set; }

        public List<NewIngredientModel> Ingredients { get; set; }

        public class NewIngredientModel
        {
            public string Name { get; set; }
            public string Measurement { get; set; }
        }
    }
}