using Microsoft.EntityFrameworkCore;

namespace ApsnetCoreMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
