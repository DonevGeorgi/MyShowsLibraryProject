using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class CrewRoleConfiguration : IEntityTypeConfiguration<CrewRole>
    {
        public void Configure(EntityTypeBuilder<CrewRole> builder)
        {
            builder
                .HasKey(cr => new { cr.CrewId, cr.RoleId});

            var date = new SeedData();

            builder.HasData(new CrewRole[]
            {
                date.CRFirstConnection,
                date.CRSecondConnection,
                date.CRThirdConnection,
                date.CRFourthConnection,
                date.CRFifthConnection,
                date.CRSixthConnection,
                date.CRSeventhConnection,
                date.CREighthConnection,
                date.CRNinthConnection,
                date.CRTenthConnection,
                date.CREleventhConnection,
                date.CRTwelfthConnection,
                date.CRThirteenthConnection,
                date.CRFourteenthConnection,
                date.CRFifteenthConnection
            });
        }
    }
}
