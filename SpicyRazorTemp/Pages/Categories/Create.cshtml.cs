using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpicyRazorTemp.Data;
using SpicyRazorTemp.Models;

namespace SpicyRazorTemp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Categoiries.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Creation of category success.";
            return RedirectToPage("Index");
        }
     }
}
