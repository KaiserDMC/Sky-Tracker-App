namespace SkyTracker.Data.Configuration;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Common.UserRoleNames;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
{
    public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
    {
        builder.HasData(
            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = AdminRole, NormalizedName = AdminRole.ToUpper() },
            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = UserRole, NormalizedName = UserRole.ToUpper() }
        );
    }
}