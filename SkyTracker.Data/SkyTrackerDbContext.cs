namespace SkyTracker.Data;

using System.Reflection;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Models;

public class SkyTrackerDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public SkyTrackerDbContext(DbContextOptions<SkyTrackerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Aircraft> Aircraft { get; set; } = null!;

    public DbSet<Flight> Flights { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        Assembly configurationAssembly = Assembly.GetAssembly(typeof(SkyTrackerDbContext)) ??
                                         Assembly.GetExecutingAssembly();

        builder.ApplyConfigurationsFromAssembly(configurationAssembly);

        base.OnModelCreating(builder);
    }
}