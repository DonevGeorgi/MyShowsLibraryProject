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
                date.BTFDirector,
                date.BTFFirstActor,
                date.BTFWriter,
                date.GOTDirector,
                date.GOTFirstActor,
                date.GOTWriter,
                date.GOTSecondActor,
                date.GOTThirdActor,
                date.GOTFourthActor,
                date.GOTFifthActor
            });
        }
    }
}
