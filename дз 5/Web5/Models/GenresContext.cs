using Microsoft.EntityFrameworkCore;

namespace FilterSortPagingApp.Models
{
    public class GenresContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public GenresContext(DbContextOptions<GenresContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}