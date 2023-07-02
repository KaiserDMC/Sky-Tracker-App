namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using SkyTracker.Data.Models;
using SkyTracker.Data.SampleData.DataGeneration;
using SkyTracker.Data.Seeding;

public class CollectionEntityConfiguration :
    IEntityTypeConfiguration<Flight>,
    IEntityTypeConfiguration<Airport>,
    IEntityTypeConfiguration<Aircraft>,
    IEntityTypeConfiguration<Runway>,
    IEntityTypeConfiguration<HeraldPost>
{
    private readonly RunwaySeeder _runwaySeeder;
    private readonly GenerateData _generateData;
    private readonly HeraldPostSeeder _heraldPostSeeder;
    private readonly FlightAirportSeeder _flightAirportSeeder;

    public CollectionEntityConfiguration()
    {
        this._runwaySeeder = new RunwaySeeder();
        this._generateData = new GenerateData();
        this._heraldPostSeeder = new HeraldPostSeeder();
        this._flightAirportSeeder = new FlightAirportSeeder();
    }

    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasData(_flightAirportSeeder.Flights);
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