using firstwebapplication.Models;
using FirstWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace firstwebapplication.Contexts
{
    public class ShoppingContext:DbContext
    {
        public ShoppingContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
