using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SerieCrewConfiguration : IEntityTypeConfiguration<SerieCrew>
    {
        public void Configure(EntityTypeBuilder<SerieCrew> builder)
        {
            var data = new SeedData();

            builder
                .HasKey(sc => new { sc.SerieId, sc.CrewId });

            builder.HasData( new SerieCrew[]
            {
                data.SCFirstConnection,
                data.SCSecondConnection,
                data.SCThirdConnection,
            });
        }
    }
}
