using Microsoft.EntityFrameworkCore;
using PkpHub.Api.Models;

namespace PkpHub.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities here if needed
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
