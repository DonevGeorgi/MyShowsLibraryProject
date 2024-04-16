using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<ISerieService, SerieService>();
            services.AddScoped<IEpisodeService, EpisodeService>();
            services.AddScoped<ISeasonService, SeasonService>();
            services.AddScoped<ICrewService, CrewService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IRoleService, RoleService>();    
            services.AddScoped<IMovieGenreService, MovieGenreService>();
            services.AddScoped<ISerieGenreService, SerieGenreService>();
            services.AddScoped<ICrewRoleService, CrewRoleService>();
            services.AddScoped<ICrewMovieService, CrewMovieService>();
            services.AddScoped<ICrewSerieService, CrewSerieService>();
            services.AddScoped<IHomeService, HomeService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository,Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(
                options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}