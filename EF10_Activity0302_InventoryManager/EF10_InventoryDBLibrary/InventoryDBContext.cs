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
}
