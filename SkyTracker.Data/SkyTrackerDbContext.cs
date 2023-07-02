using SkyTracker.Data.Configuration;

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

    public DbSet<Airport> Airports { get; set; } = null!;

    public DbSet<Runway> Runways { get; set; } = null!;

    public DbSet<HeraldPost> HeraldPosts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //Assembly configurationAssembly = Assembly.GetAssembly(typeof(SkyTrackerDbContext)) ??
        //                                   Assembly.GetExecutingAssembly();

        //builder.ApplyConfigurationsFromAssembly(configurationAssembly);

        builder.ApplyConfiguration(new RunwayCollectionEntityConfiguration());
        builder.ApplyConfiguration(new AircraftCollectionEntityConfiguration());

        builder.ApplyConfiguration(new HeraldPostEntityConfiguration());

        builder.Entity<Flight>(e => e.HasKey(x => x.AircraftId));
        builder.Entity<Aircraft>(e => e.HasKey(x => x.AircraftId));

        builder.Entity<Aircraft>(aircraft =>
        {
            aircraft
                .HasMany(a => a.Flights)
                .WithOne(f => f.Aircraft)
                .HasForeignKey(e => e.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Flight>(flight =>
        {
            flight
                .HasOne(f => f.Aircraft)
                .WithMany(a => a.Flights)
                .HasForeignKey(f => f.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        base.OnModelCreating(builder);
    }
}