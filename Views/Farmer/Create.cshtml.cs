using FinalAECApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalAECApp.Views.Farmer
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
        public Farmer Farmers { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid || _context.Products == null ||
                Farmers == null)
            {
                return Page();
            }
            _context.Farmers.Add(Farmers);
            await _context.SaveChangesAsync();
            return RedirectToPage(nameof(Index));
        }
    }
}
