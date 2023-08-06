using Microsoft.EntityFrameworkCore;
using WebApplication117.Models;

namespace WebApplication117.Database
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
