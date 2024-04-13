using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SerieConfiguration : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            var data = new SeedData();

            builder.HasData(new Serie[] 
            {
                data.FirstSerie,
                data.SecondSerie,
                data.ThirdSerie,
                data.FourthSerie,
                data.FifthSerie,
                data.SixthSerie,
                data.SeventhSerie,
                data.EighthSerie,
                data.NinthSerie,
                data.TenthSerie,
                data.EleventhSerie,
                data.TwelfthSerie
            });
        }
    }
}
