using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SerieGenreConfiguration : IEntityTypeConfiguration<SerieGenre>
    {
        public void Configure(EntityTypeBuilder<SerieGenre> builder)
        {
            builder
                .HasKey(sg => new { sg.SerieId, sg.GenreId });
            
            var data = new SeedData();

            builder.HasData(new SerieGenre[] 
            {
                data.SGFirstConnection,
                data.SGSecondConnection,
                data.SGThirdConnection,
            });
        }
    }
}
