using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class UserReviewConfiguration : IEntityTypeConfiguration<UserReview>
    {
        public void Configure(EntityTypeBuilder<UserReview> builder)
        {
            builder
              .HasKey(ur => new { ur.UserId, ur.ReviewIdentifier });

            var data = new SeedData();

            builder.HasData(new UserReview[]
            {
                data.URFirstConnection,
                data.URSecondConnection
            });
        }
    }
}
