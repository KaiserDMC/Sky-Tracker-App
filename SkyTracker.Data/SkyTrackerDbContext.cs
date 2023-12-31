﻿namespace SkyTracker.Data;

using Configuration;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Models;

/// <summary>
/// The SkyTrackerDbContext class represents the database context of the application.
/// </summary>

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

        // Comment out lines 58 to 76 before Publish to Azure, also comment out the SeedData method
        // For local development, reverse the comments

        var collectionEntityConfiguration = new CollectionEntityConfiguration();

        builder.ApplyConfiguration<Flight>(collectionEntityConfiguration);
        builder.ApplyConfiguration<Airport>(collectionEntityConfiguration);
        builder.ApplyConfiguration<Aircraft>(collectionEntityConfiguration);

        builder.Entity<Aircraft>()
            .HasIndex(a => a.Registration)
            .IsUnique();

        builder.ApplyConfiguration<Runway>(collectionEntityConfiguration);
        builder.ApplyConfiguration<HeraldPost>(collectionEntityConfiguration);

        var mappingEntityConfiguration = new MappingEntityConfiguration();

        builder.ApplyConfiguration<FlightAircraft>(mappingEntityConfiguration);
        builder.ApplyConfiguration<RunwayAirport>(mappingEntityConfiguration);

        builder.ApplyConfiguration(new ApplicationUserConfiguration());

        base.OnModelCreating(builder);

        SeedData(builder);
    }

    // Seed admin and moderator users and their data for later usage in Development or Test environments
    private void SeedData(ModelBuilder builder)
    {
        var adminUser = new ApplicationUser()
        {
            Id = Guid.NewGuid(),
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@sky-tracker.info",
            NormalizedEmail = "ADMIN@SKY-TRACKER.INFO"
        };

        var passwordHasher = new PasswordHasher<ApplicationUser>();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "admin");
        builder.Entity<ApplicationUser>().HasData(adminUser);

        var moderatorUser = new ApplicationUser()
        {
            Id = Guid.NewGuid(),
            UserName = "moderator",
            NormalizedUserName = "MODERATOR",
            Email = "moderator@sky-tracker.info",
            NormalizedEmail = "MODERATOR@SKY-TRACKER.INFO",
            LockoutEnabled = true
        };

        var passwordHasherModerator = new PasswordHasher<ApplicationUser>();
        moderatorUser.PasswordHash = passwordHasherModerator.HashPassword(moderatorUser, "moderator");
        builder.Entity<ApplicationUser>().HasData(moderatorUser);
    }
}