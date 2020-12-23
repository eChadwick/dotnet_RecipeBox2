using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace RecipeBox2.Models
{
    public class RecipeCreateViewModel : IValidatableObject
    {
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }

        public string Directions { get; set; }

        public List<NewIngredientModel> Ingredients { get; set; }

        public class NewIngredientModel
        {
            public string Name { get; set; }
            public string Measurement { get; set; }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if( String.IsNullOrWhiteSpace(Name) )
            {
                yield return new ValidationResult(
                    "Recipe name cannot be blank",
                    new List<string>{"Name"}
                );
            }
        }
    }
}