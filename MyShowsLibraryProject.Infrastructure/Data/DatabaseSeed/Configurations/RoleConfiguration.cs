using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            var data = new SeedData();

            builder.HasData(new Role[] 
            {
                data.DirectorRole,
                data.WriterRole,
                data.ActorRole,
                data.ProducerRole,
                data.MusicComposerRole,
                data.CinematographerRole,
                data.EditorRole,
                data.ArtDirectorRole,
                data.CostumeDesignerRole
            });
        }
    }
}
