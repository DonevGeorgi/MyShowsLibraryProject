using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class UserSerieConfiguration : IEntityTypeConfiguration<UserSerie>
    {
        public void Configure(EntityTypeBuilder<UserSerie> builder)
        {
            builder
                .HasKey(us => new { us.UserId, us.SerieId });

            builder
                .HasOne(e => e.Serie)
                .WithMany()
                .HasForeignKey(e => e.SerieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(e => e.User)
                 .WithMany()
                 .HasForeignKey(e => e.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
