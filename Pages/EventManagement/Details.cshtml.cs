using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.EventManagement
{
    public class DetailsModel : PageModel
    {
        private readonly PortfolioContext _context;

        public DetailsModel(PortfolioContext context)
        {
            _context = context;
        }

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
    }
}
