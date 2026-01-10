using System.Net.ServerSentEvents;
using Microsoft.EntityFrameworkCore;
using EF10_InventoryModels;

namespace EF10_InventoryDBLibrary;

public partial class InventoryDbContext : DbContext
{
    public DbSet<Item> Items {get; set;}

    public InventoryDbContext()
    {
    }

    public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Item>()
            .Property(i => i.IsActive)
            .HasDefaultValue(true);
    }
}
