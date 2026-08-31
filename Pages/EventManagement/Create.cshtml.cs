using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.EventManagement
{
    public class CreateModel : PageModel
    {
        // portfolio context that is inducted through constructor/dependency injection
        // so that is available in all of our classes
        private readonly PortfolioContext _context;

        public CreateModel(PortfolioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
