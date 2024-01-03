using CleanArchitecture.Domain.Entities;

namespace Infrastructure.CleanArchitecture.Persistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }     
    }
}