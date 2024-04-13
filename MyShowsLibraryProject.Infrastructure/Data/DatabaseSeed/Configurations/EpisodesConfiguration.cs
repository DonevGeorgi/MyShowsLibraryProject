using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class EpisodesConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            var data = new SeedData();

            builder.HasData(new Episode[] 
            { 
                data.GotS1FirstEpisode,
                data.GotS1SecondEpisode,
                data.GotS1ThirdEpisode,
                data.GotS1FourthEpisode,
                data.GotS1FifthEpisode,
                data.GotS1SixthEpisode,
                data.GotS1SeventhEpisode,
                data.GotS1EighthEpisode,
                data.GotS1NinthEpisode,
                data.GotS1TenthEpisode,
                data.GotS2FirstEpisode,
                data.GotS2SecondEpisode,
                data.GotS2ThirdEpisode,
                data.GotS2FourthEpisode,
                data.GotS2FifthEpisode,
                data.GotS2SixthEpisode,
                data.GotS2SeventhEpisode,
                data.GotS2EighthEpisode,
                data.GotS2NinthEpisode,
                data.GotS2TenthEpisode,
                data.GotS3FirstEpisode,
                data.GotS3SecondEpisode,
                data.GotS3ThirdEpisode,
                data.GotS3FourthEpisode,
                data.GotS3FifthEpisode,
                data.GotS3SixthEpisode,
                data.GotS3SeventhEpisode,
                data.GotS3EighthEpisode,
                data.GotS3NinthEpisode,
                data.GotS3TenthEpisode,
                data.GotS4FirstEpisode,
                data.GotS4SecondEpisode,
                data.GotS4ThirdEpisode,
                data.GotS4FourthEpisode,
                data.GotS4FifthEpisode,
                data.GotS4SixthEpisode,
                data.GotS4SeventhEpisode,
                data.GotS4EighthEpisode,
                data.GotS4NinthEpisode,
                data.GotS4TenthEpisode
            });
        }
    }
}
