using ecommerce_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
