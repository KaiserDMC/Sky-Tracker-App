namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

using Seeding;

using DataGeneration;

/// <summary>
/// This configuration class is used to seed the database with data for the basic entities.
/// The data is generated with the help of various seeder classes.
/// </summary>

public class CollectionEntityConfiguration : IEntityTypeConfiguration<Flight>, IEntityTypeConfiguration<Airport>, IEntityTypeConfiguration<Aircraft>, IEntityTypeConfiguration<Runway>, IEntityTypeConfiguration<HeraldPost>
{
    private readonly RunwaySeeder _runwaySeeder;
    private readonly GenerateData _generateData;
    private readonly HeraldPostSeeder _heraldPostSeeder;
    private readonly FlightSeeder _flightSeeder;

    public CollectionEntityConfiguration()
    {
        this._runwaySeeder = new RunwaySeeder();
        this._generateData = new GenerateData();
        this._heraldPostSeeder = new HeraldPostSeeder();
        this._flightSeeder = new FlightSeeder();
    }

    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasData(_flightSeeder.Flights);
    }

    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasData(_generateData.AirportCollection);
    }

    public void Configure(EntityTypeBuilder<Aircraft> builder)
    {
        builder.HasData(_generateData.AircraftCollection);
    }

    public void Configure(EntityTypeBuilder<Runway> builder)
    {
        builder.HasData(_runwaySeeder.Runways);
    }

    public void Configure(EntityTypeBuilder<HeraldPost> builder)
    {
        builder.HasData(_heraldPostSeeder.GenerateHeraldPosts());
    }
}