﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            var data = new SeedData();

            builder.HasData(new Movie[]
            {
                data.FirstMovie,
                data.SecondMovie,
                data.ThirdMovie,
                data.FourthMovie,
                data.FifthMovie,
                data.SixthMovie,
                data.SeventhMovie,
                data.EighthMovie,
                data.NinthMovie,
                data.TenthMovie,
                data.EleventhMovie,
                data.TwelfthMovie
            });
        }
    }
}
