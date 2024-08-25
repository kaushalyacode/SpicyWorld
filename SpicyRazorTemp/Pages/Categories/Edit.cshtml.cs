using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpicyRazorTemp.Data;
using SpicyRazorTemp.Models;

namespace SpicyRazorTemp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
      
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0) {
                Category = _db.Categoiries.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (Category.Name != null && Category.Description != null && Category.Name.ToLower().Equals(Category.Description.ToLower()))
            {
                ModelState.AddModelError("name", "Cannot have same name and description");
            }
            if (Category.Name != null && Category.Name.ToLower().Equals("test"))
            {
                ModelState.AddModelError("", "Cannot have test as name");//ModelOnly || None || All for for-validation-summary
            }
            if (ModelState.IsValid)
            {
                _db.Categoiries.Update(Category);
                TempData["success"] = "Updation of category success.";

                _db.SaveChanges();
                return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
