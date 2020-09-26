using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Collections.Generic;

namespace RecipeBox2.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            textInfo = new CultureInfo("en-US", false).TextInfo;
        }
        public int Id { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = textInfo.ToTitleCase(value); }
        }
        public IList<RecipeIngredient> RecipeIngredients { get; set; }
        private TextInfo textInfo;
    }
}