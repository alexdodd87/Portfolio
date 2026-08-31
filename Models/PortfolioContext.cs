using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class PortfolioContext(DbContextOptions<PortfolioContext> options) : DbContext(options)
    {
        public DbSet<Event> Events { get; set; } = default!;
    }
}
