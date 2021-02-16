using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RecipeApplication.Models;

namespace RecipeApplication.Controllers
{
    public class RecipeController : Controller
    {

        private RecipeContext context { get; set; }

        public RecipeController(RecipeContext ctx)
        {
            context = ctx;
        }       

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            return View("Add", new Recipe());
        }

        public IActionResult Details(int id)
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryId).ToList();

            Recipe recipe = context.Recipes.Find(id);

            string imageFilename = recipe.Image;
                     
            ViewBag.Categories = categories;
            ViewBag.ImageFilename = imageFilename;
                     
            return View(recipe);

        }

    }
}
