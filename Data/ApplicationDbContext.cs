using Microsoft.EntityFrameworkCore;
using MyAspNetApp.Models;

namespace MyAspNetApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    public DbSet<Product> Products { get; set; }
    }
}
