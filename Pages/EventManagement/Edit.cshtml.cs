using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Pages.EventManagement
{
    public class EditModel : PageModel
    {
        private readonly PortfolioContext _context;

        public EditModel(PortfolioContext context)
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

            var evt = await _context.Events.FindAsync(id.Value);

            if (evt == null)
            {
                return NotFound();
            }

            Event = evt;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // if the event no longer exists in the database, return NotFound
                if (_context.Events.Find(Event.ID) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

    }
}
