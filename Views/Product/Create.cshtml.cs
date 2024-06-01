using FinalAECApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalAECApp.Views.Product
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Products { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid || _context.Products == null ||
                Products == null)
            {
                return Page();
            }
            _context.Products.Add(Products);
            await _context.SaveChangesAsync();
            return RedirectToPage(nameof(Index));
        }
    }
}
