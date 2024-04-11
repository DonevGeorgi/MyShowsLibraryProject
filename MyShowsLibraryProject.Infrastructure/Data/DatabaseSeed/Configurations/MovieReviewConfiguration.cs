using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class MovieReviewConfiguration : IEntityTypeConfiguration<MovieReview>
    {
        public void Configure(EntityTypeBuilder<MovieReview> builder)
        {
            builder
               .HasKey(mv => new { mv.MovieId, mv.ReviewId });

            var data = new SeedData();

            builder.HasData(new MovieReview[]
            {
                data.MRFirstConnection
            });
        }
    }
}
