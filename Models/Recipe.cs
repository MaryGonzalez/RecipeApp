using System;
using System.ComponentModel.DataAnnotations;


namespace RecipeApplication.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Please enter a recipe name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please include an image.")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Please enter an author.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter the prep time.")]
        public string PrepTime { get; set; }

        [Required(ErrorMessage = "Please enter the total time.")]
        public string TotalTime { get; set; }

        [Required(ErrorMessage = "Please enter the number of servings.")]
        public int Servings { get; set; }

        [Required(ErrorMessage = "Please enter the ingredients.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter the directions.")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Please select the category.")]
        public string CategoryId { get; set; }
        
        public Category Category { get; set; }

    }
}
