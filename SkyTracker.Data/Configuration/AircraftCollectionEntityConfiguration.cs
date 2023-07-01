using SkyTracker.Data.Models;

namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seeding;

public class AircraftCollectionEntityConfiguration : IEntityTypeConfiguration<Aircraft>
{
    private readonly AircraftCollectionSeeder _aircraftCollectionSeeder;

    public AircraftCollectionEntityConfiguration()
    {
        this._aircraftCollectionSeeder = new AircraftCollectionSeeder();
    }

    public void Configure(EntityTypeBuilder<Aircraft> builder)
    {
        builder.HasData(this._aircraftCollectionSeeder);
    }
}