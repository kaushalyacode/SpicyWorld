using Microsoft.AspNetCore.Mvc;
using SpicyWorld.Data;
using SpicyWorld.Models;

namespace SpicyWorld.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        //Why readonly insted of const 
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
                
        }
        public IActionResult Index()
        {
            var categories = _db.Categoiries.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name != null && category.Description != null && category.Name.ToLower().Equals(category.Description.ToLower())) {
                ModelState.AddModelError("name", "Cannot have same name and description");
            }
            if (category.Name != null && category.Name.ToLower().Equals("test"))
            {
                ModelState.AddModelError("", "Cannot have test as name");//ModelOnly || None || All for for-validation-summary
            }
            if (ModelState.IsValid)
            {
                _db.Categoiries.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");//since we are in same controller, second parameter is no need.

            }
            return View();

        }
    }
}
