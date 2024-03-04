using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            var data = new SeedData();

            builder.HasData(new Genre[]
            {
                data.ActionGenre,
                data.ComedyGenre,
                data.DramaGenre,
                data.FantasyGenre,
                data.HorrorGenre,
                data.MysteryGenre,
                data.RomanceGenre,
                data.ThrillerGenre,
                data.WesternGenre,
                data.AdventureGenre,
                data.SciFiGenre,
            });
    }
    }
}
