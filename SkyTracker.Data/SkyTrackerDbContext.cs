namespace SkyTracker.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Models;
using Configuration;

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

    public DbSet<RunwayAirport> RunwaysAirports { get; set; } = null!;

    public DbSet<FlightAircraft> FlightsAircraft { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<RunwayAirport>(entity =>
        {
            entity
            .HasKey(ra => new { ra.RunwayId, ra.AirportId });
        });

        builder.Entity<FlightAircraft>(entity =>
        {
            entity
            .HasKey(fa => new { fa.FlightId, fa.AircraftId });
        });

        var collectionEntityConfiguration = new CollectionEntityConfiguration();

        builder.ApplyConfiguration<Flight>(collectionEntityConfiguration);
        builder.ApplyConfiguration<Airport>(collectionEntityConfiguration);
        builder.ApplyConfiguration<Aircraft>(collectionEntityConfiguration);

        // Runway and HeraldPost need to be commented out to after initial migration avoid seeding errors, as they use randomly generated data.
        builder.ApplyConfiguration<Runway>(collectionEntityConfiguration);
        builder.ApplyConfiguration<HeraldPost>(collectionEntityConfiguration);

        var mappingEntityConfiguration = new MappingEntityConfiguration();

        builder.ApplyConfiguration<FlightAircraft>(mappingEntityConfiguration);
        builder.ApplyConfiguration<RunwayAirport>(mappingEntityConfiguration);

        base.OnModelCreating(builder);
    }
}