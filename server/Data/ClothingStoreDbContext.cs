using Microsoft.EntityFrameworkCore;
using server.Entities;

namespace server.Data;

public class ClothingStoreDbContext : DbContext
{
    public ClothingStoreDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
