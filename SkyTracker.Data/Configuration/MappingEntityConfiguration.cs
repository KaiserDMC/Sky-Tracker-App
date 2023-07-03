namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Seeding;
using Models;

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