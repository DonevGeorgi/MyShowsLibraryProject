using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class UserSerieConfiguration : IEntityTypeConfiguration<UserSerie>
    {
        public void Configure(EntityTypeBuilder<UserSerie> builder)
        {
            builder
                .HasKey(us => new { us.UserId, us.SerieIdentifier });
        }
    }
}
