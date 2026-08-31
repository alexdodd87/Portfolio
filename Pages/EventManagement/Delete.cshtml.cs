using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.EventManagement
{
    public class DeleteModel : PageModel
    {
        private readonly PortfolioContext _context;

        public DeleteModel(PortfolioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evt = await _context.Events.FindAsync(id);
            if (evt == null)
            {
                return NotFound();
            }

            Event = evt;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evt = await _context.Events.FindAsync(id);
            if (evt != null)
            {
                Event = evt;
                _context.Events.Remove(Event);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
