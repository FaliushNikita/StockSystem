using DAL.Entities;
using DAL.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace DAL.Base;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base(new DbContextOptions<ApplicationDbContext>()) 
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=StockSystem;User ID=postgres;Password=12345");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ProductModelConfiguration());
    }
}
