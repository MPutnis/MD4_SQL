using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MD4_SQL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Create tables for the classes
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
