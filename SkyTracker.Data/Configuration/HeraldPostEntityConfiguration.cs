namespace SkyTracker.Data.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Seeding;
using Models;

public class HeraldPostEntityConfiguration : IEntityTypeConfiguration<HeraldPost>
{
    private readonly HeraldPostSeeder _heraldPostSeeder;

    public HeraldPostEntityConfiguration()
    {
        this._heraldPostSeeder = new HeraldPostSeeder();
    }

    public void Configure(EntityTypeBuilder<HeraldPost> builder)
    {
        builder.HasData(this._heraldPostSeeder.GenerateHeraldPosts());
    }
}