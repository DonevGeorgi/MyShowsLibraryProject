using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SerieCrewConfiguration : IEntityTypeConfiguration<SerieCrew>
    {
        public void Configure(EntityTypeBuilder<SerieCrew> builder)
        {
            builder
                .HasKey(sc => new { sc.SerieId, sc.CrewId });

            var data = new SeedData();

            builder.HasData(
                new SerieCrew[]
            {
                data.SCFirstConnection,
                data.SCSecondConnection,
                data.SCThirdConnection,
                data.SCFourthConnection,
                data.SCFifthConnection,
                data.SCSixthConnection,
                data.SCSeventhConnection,
                data.SCEighthConnection,
                data.SCNinthConnection
            });
        }
    }
}
