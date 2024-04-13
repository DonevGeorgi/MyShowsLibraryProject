using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            var data = new SeedData();

            builder.HasData(new Season[]
            {
                data.GotFirstSeason,
                data.GotSecondSeason,
                data.GotThirdSeason,
                data.GotFourthSeason,
                data.DaredevilFirstSeason,
                data.StrangerThingsFirstSeason,
                data.StrangerThingsSecondSeason,
                data.ThreeBodyProblemFirstSeason
            });
        }
    }
}
