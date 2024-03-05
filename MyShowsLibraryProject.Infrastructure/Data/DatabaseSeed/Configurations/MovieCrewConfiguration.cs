using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class MovieCrewConfiguration : IEntityTypeConfiguration<MovieCrew>
    {
        public void Configure(EntityTypeBuilder<MovieCrew> builder)
        {
            builder
                .HasKey(mc => new { mc.MovieId, mc.CrewId });
           
            var data = new SeedData();

            builder.HasData(new MovieCrew[] 
            {
                data.MCFirstConnection,
                data.MCSecondConnection,
                data.MCThirdConnection
            });
        }
    }
}
