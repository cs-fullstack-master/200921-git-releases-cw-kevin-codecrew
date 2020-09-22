using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.DAO
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> products{get;set;}
    }
}