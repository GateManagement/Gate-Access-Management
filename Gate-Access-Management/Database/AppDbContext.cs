using Gate_Access_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Gate_Access_Management.Database;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Garage> Garages { get; set; }
    public DbSet<GaragePreset> GaragePresets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=gate-access-database.db");
        }
    }
}