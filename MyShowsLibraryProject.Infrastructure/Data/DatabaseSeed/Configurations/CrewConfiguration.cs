using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class CrewConfiguration : IEntityTypeConfiguration<Crew>
    {
        public void Configure(EntityTypeBuilder<Crew> builder)
        {
            var date = new SeedData();

            builder.HasData(new Crew[] 
            {
                date.FirstDirector,
                date.SecondDirector,
                date.FirstActor,
                date.SecondActor,
                date.FirstWriter,
                date.SecondWriter
            });
        }
    }
}
