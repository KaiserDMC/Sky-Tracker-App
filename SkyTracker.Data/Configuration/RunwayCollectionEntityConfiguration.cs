using Microsoft.EntityFrameworkCore;
using SkyTracker.Data.Models;

namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Seeding;

public class RunwayCollectionEntityConfiguration : IEntityTypeConfiguration<Runway>
{
    private readonly RunwaySeeder _runwaySeeder;

    public RunwayCollectionEntityConfiguration()
    {
        this._runwaySeeder = new RunwaySeeder();
    }

    public void Configure(EntityTypeBuilder<Runway> builder)
    {
        builder.HasData(this._runwaySeeder.GenerateRunways());
    }
}