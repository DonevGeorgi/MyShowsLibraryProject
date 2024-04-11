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
              .HasKey(ur => new { ur.UserId, ur.ReviewId });

            builder
                .HasOne(e => e.Review)
                .WithMany()
                .HasForeignKey(e => e.ReviewId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(e => e.User)
               .WithMany()
               .HasForeignKey(e => e.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new UserReview[]
            {
                data.URFirstConnection,
                data.URSecondConnection
            });
        }
    }
}
