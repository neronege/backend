using Microsoft.EntityFrameworkCore;

namespace Angular_test.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
