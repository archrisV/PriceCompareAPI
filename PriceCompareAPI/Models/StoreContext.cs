using Microsoft.EntityFrameworkCore;

namespace PriceCompareAPI.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }

    }
}
