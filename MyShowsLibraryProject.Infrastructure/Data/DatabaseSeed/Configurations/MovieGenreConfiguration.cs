using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            var data = new SeedData();

            builder
               .HasKey(mg => new { mg.MovieId, mg.GenreId });

            builder.HasData(new MovieGenre[] 
            { 
                data.MGFirstConnection,
                data.MGSecondConnection,
                data.MGThirdConnection 
            });
        }
    }
}
