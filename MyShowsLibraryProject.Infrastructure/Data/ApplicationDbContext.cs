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
            builder.ApplyConfiguration(new EpisodesConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new MovieCrewConfiguration());
            builder.ApplyConfiguration(new MovieGenreConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new SeasonConfiguration());
            builder.ApplyConfiguration(new SerieConfiguration());
            builder.ApplyConfiguration(new SerieCrewConfiguration());
            builder.ApplyConfiguration(new SerieGenreConfiguration());

            builder.Entity<UserMovie>()
                .HasKey(um => new { um.UserId, um.MovieId });

            builder.Entity<UserMovie>()
                .HasOne(e => e.Movie)
                .WithMany()
                .HasForeignKey(e => e.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserMovie>()
                 .HasOne(e => e.User)
                 .WithMany()
                 .HasForeignKey(e => e.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserSerie>()
                .HasKey(us => new { us.UserId, us.SerieId });

            builder.Entity<UserSerie>()
                .HasOne(e => e.Serie)
                .WithMany()
                .HasForeignKey(e => e.SerieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserSerie>()
                 .HasOne(e => e.User)
                 .WithMany()
                 .HasForeignKey(e => e.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserReview>()
                .HasKey(ur => new { ur.UserId, ur.ReviewId });

            builder.Entity<UserReview>()
                .HasOne(e => e.Review)
                .WithMany()
                .HasForeignKey(e => e.ReviewId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserReview>()
               .HasOne(e => e.User)
               .WithMany()
               .HasForeignKey(e => e.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
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
