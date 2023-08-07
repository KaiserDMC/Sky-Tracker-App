namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;

using Seeding;

/// <summary>
/// This configuration class is used to seed the database's mapping tables.
/// These tables define the relationships between Flight -> Aircraft and Airport -> Runway
/// </summary>

public class MappingEntityConfiguration : IEntityTypeConfiguration<FlightAircraft>, IEntityTypeConfiguration<RunwayAirport>
{
    private readonly FlightAircraftSeeder _flightAircraftSeeder;
    private readonly RunwayAirportSeeder _runwayAirportSeeder;

    public MappingEntityConfiguration()
    {
        _flightAircraftSeeder = new FlightAircraftSeeder();
        _runwayAirportSeeder = new RunwayAirportSeeder();
    }

    public void Configure(EntityTypeBuilder<FlightAircraft> builder)
    {
        builder.HasData(_flightAircraftSeeder.FlightAircraft);
    }

    public void Configure(EntityTypeBuilder<RunwayAirport> builder)
    {
        builder.HasData(_runwayAirportSeeder.RunwayAirports);
    }
}