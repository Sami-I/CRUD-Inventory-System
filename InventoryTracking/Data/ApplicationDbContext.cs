using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InventoryTracking.Models;

namespace InventoryTracking.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<InventoryTracking.Models.Product>? Product { get; set; }
    public DbSet<InventoryTracking.Models.Location>? Location { get; set; }
}

