using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class AdminUserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder
                .HasKey(iur => new { iur.RoleId, iur.UserId });

            var data = new SeedData();

            builder.HasData(new IdentityUserRole<string>[]
            {
                data.AdminUserRole
            });
        }
    }
}
