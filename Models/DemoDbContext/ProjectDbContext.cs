using Microsoft.EntityFrameworkCore;

namespace MasterDetails.Models.DemoDbContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetailss { get; set; }
    }
}
