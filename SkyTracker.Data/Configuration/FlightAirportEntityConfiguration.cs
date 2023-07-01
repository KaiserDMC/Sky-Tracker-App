namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Models;
using Seeding;

public class FlightAirportEntityConfiguration : IEntityTypeConfiguration<Flight>, IEntityTypeConfiguration<Airport>, IEntityTypeConfiguration<Runway>
{
    private readonly FlightAirportSeeder _flightAirportSeeder;

    public FlightAirportEntityConfiguration()
    {
        this._flightAirportSeeder = new FlightAirportSeeder();
    }

    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasData(this._flightAirportSeeder.flights);
    }

    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasData(this._flightAirportSeeder.airport);
    }

    public void Configure(EntityTypeBuilder<Runway> builder)
    {
        throw new NotImplementedException();
    }
}