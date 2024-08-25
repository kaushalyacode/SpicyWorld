using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpicyRazorTemp.Data;
using SpicyRazorTemp.Models;

namespace SpicyRazorTemp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categoiries.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            var category = _db.Categoiries.Find(Category.Id);
            if (category == null)
            {
                return NotFound();
            }

            _db.Categoiries.Remove(category);
            TempData["success"] = "Deletion of category success.";

            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
