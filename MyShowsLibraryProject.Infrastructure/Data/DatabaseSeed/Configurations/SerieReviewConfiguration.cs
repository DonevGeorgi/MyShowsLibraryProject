using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class SerieReviewConfiguration : IEntityTypeConfiguration<SerieReview>
    {
        public void Configure(EntityTypeBuilder<SerieReview> builder)
        {
            builder
                .HasKey(sv => new { sv.SerieId, sv.ReviewId });
        }
    }
}
