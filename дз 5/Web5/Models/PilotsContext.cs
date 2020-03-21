using Microsoft.EntityFrameworkCore;

namespace FilterSortPagingApp.Models
{
    public class PilotsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public PilotsContext(DbContextOptions<PilotsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}