using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed.Configurations;
using MyShowsLibraryProject.Infrastructure.Data.Models;


namespace MyShowsLibraryProject.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CrewConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new EpisodesConfiguration());
            builder.ApplyConfiguration(new MovieCrewConfiguration());
            builder.ApplyConfiguration(new MovieGenreConfiguration());
            builder.ApplyConfiguration(new SeasonConfiguration());
            builder.ApplyConfiguration(new SerieConfiguration());
            builder.ApplyConfiguration(new SerieCrewConfiguration());
            builder.ApplyConfiguration(new SerieGenreConfiguration());
            builder.ApplyConfiguration(new CrewRoleConfiguration());
            builder.ApplyConfiguration(new MovieReviewConfiguration());
            builder.ApplyConfiguration(new SerieReviewConfiguration());
            builder.ApplyConfiguration(new UserSerieConfiguration());
            builder.ApplyConfiguration(new UserMovieConfiguration());
            builder.ApplyConfiguration(new UserReviewConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Id = "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR".ToUpper()
                });

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e656345-a56d-4543-a7c6-4556d32d4db2",
                    UserName = "admin1@abv.bg",
                    NormalizedUserName = "ADMIN1@ABV.BG",
                    Email = "admin1@abv.bg",
                    NormalizedEmail = "ADMIN1@ABV.BG",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin_1")
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                UserId = "8e656345-a56d-4543-a7c6-4556d32d4db2"
            });
        }

        public DbSet<Crew> Crews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MovieCrew> MoviesCrews { get; set; }
        public DbSet<SerieCrew> SeriesCrews { get; set; }
        public DbSet<MovieReview> MoviesReviews { get; set; }
        public DbSet<SerieReview> SeriesReviews { get; set; }
        public DbSet<MovieGenre> MoviesGenres { get; set; }
        public DbSet<SerieGenre> SeriesGenres { get; set; }
        public DbSet<UserReview> UsersReviews { get; set; }
        public DbSet<UserSerie> UsersSeries { get; set; }
        public DbSet<UserMovie> UsersMovies { get; set; }
    }
}
