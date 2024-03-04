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
                data.FirstEpisode,
                data.SecondEpisode,
                data.ThirdEpisode,
                data.FourthEpisode,
                data.FifthEpisode,
                data.SixthEpisode,
                data.SeventhEpisode,
                data.EighthEpisode,
                data.NinthEpisode,
                data.TenthEpisode});
        }
    }
}
