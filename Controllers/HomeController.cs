using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApplication.Models;

namespace RecipeApplication.Controllers
{
    public class HomeController : Controller
    {
        
        private RecipeContext context { get; set; }

        public HomeController(RecipeContext ctx)
        {
            context = ctx;
        }
        
        public IActionResult Index()
        {  
            var recipies = context.Recipes
                .Include(m => m.Category)
                .OrderBy(m => m.Name)
                .ToList();
            return View(recipies);
        }


       
    }
}
