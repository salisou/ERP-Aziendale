using ApsnetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ApsnetCoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Fattura> Fatture { get; set; } = null!;
    }
}
