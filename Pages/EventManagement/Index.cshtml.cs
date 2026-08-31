using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Pages.EventManagement
{
    public class IndexModel : PageModel
    {
        private readonly PortfolioContext _context;

        public IndexModel(PortfolioContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get; set; } = default!;

        // As this is a db request it may take some time to complete, so we use async/await to avoid blocking the thread
        public async Task OnGetAsync()
        {
            // Get all events and the convert them to a list, then assign to the Events property
            Events = await _context.Events.ToListAsync();
        }
    }
}
