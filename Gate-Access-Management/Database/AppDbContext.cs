using Gate_Access_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Gate_Access_Management.Database;

public class AppDbContext : DbContext
{
    public DbSet<AccessLog> AccessLogs { get; set; }
    public DbSet<AccessSchedule> AccessSchedules { get; set; }
    public DbSet<DaysScheduled> DaysScheduled { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<UnitType> UnitTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=gate-access-database.db");
        }
    }
}
