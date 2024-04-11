using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            var data = new SeedData();

            builder.HasData(new Review[]
            {
                data.ReviewForMovie,
                data.ReviewForSerie
            });
        }
    }
}
