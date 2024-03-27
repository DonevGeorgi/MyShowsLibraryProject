using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewService : ICrewService
    {
        private readonly IRepository repository;
        private readonly IRoleService roleService;

        public CrewService(IRepository _repository,
            IRoleService _roleService)
        {
            repository = _repository;
            roleService = _roleService;
        }

        public async Task<IEnumerable<CrewInfoServiceModel>> GetAllReadonlyAsync()
        {
            var crew = await repository
                .TakeAllReadOnly<Crew>()
                .Select(c => new CrewInfoServiceModel
                {
                    Name = c.Name
                })
                .ToListAsync();

            return crew;
        }
        public async Task<int> CreateAsync(CrewFormModel crew)
        {
            var newCrew = new Crew()
            {
                Name = crew.Name,
                Pseudonyms = crew.Pseudonyms,
                Birthdate = crew.Birthdate,
                Nationality = crew.Nationality,
                PictureUrl = crew.PictureUrl,
                Biography = crew.Biography,
                MoreInfo = crew.MoreInfo          
            };

            await repository.AddAsync(newCrew);
            //await repository.SaveChangesAsync();

            var roles = crew.Roles
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var role in roles)
            {
                var currRoleId = await roleService.GetRoleIdFromName(role);

                if (currRoleId == 0)
                {
                    //Exception
                }

                var newCrewRole = new CrewRole()
                {
                    CrewId = newCrew.CrewId,
                    RoleId = currRoleId
                };

                await repository.AddAsync(newCrewRole);
            }

            //await repository.SaveChangesAsync();

            return newCrew.CrewId;
        }
        public async Task<CrewDetailsServiceModel> GetCrewDetailsById(int crewId)
        {
            var crew = await repository
                .TakeAllReadOnly<Crew>()
                .Where(c => c.CrewId == crewId)
                .Select(c => new CrewDetailsServiceModel()
                {
                    Name = c.Name,
                    Pseudonyms = c.Pseudonyms,
                    Birthdate = c.Birthdate,
                    Nationality = c.Nationality,
                    PictureUrl = c.PictureUrl,
                    Biography = c.Biography,
                    MoreInfo = c.MoreInfo,
                    Roles = repository
                        .TakeAllReadOnly<CrewRole>()
                        .Where(cr => cr.CrewId == c.CrewId)
                        .Select(cr => new RoleInfoServiceModel 
                        { 
                            Name = cr.Role.Name
                        })
                        .ToList(),
                    Series = repository
                        .TakeAllReadOnly<SerieCrew>()
                        .Where(sc => sc.CrewId == c.CrewId)
                        .Select(sc => new SeriesCardInfoServiceModel 
                        { 
                            SerieId = sc.SerieId,
                            Title = sc.Serie.Title,
                            PosterUrl = sc.Serie.PosterUrl,
                            StartYear = sc.Serie.YearOfStart,
                            EndYear = sc.Serie.YearOfEnd,
                        })
                        .ToList(),
                    Movies = repository
                        .TakeAllReadOnly<MovieCrew>()
                        .Where(mc => mc.CrewId == c.CrewId)
                        .Select(mc => new MoviesCardInfoServiceModel 
                        { 
                            MovieId = mc.MovieId,
                            Title = mc.Movie.Title,
                            PosterUrl = mc.Movie.PosterUrl,
                            YearOfRelease = mc.Movie.DateOfRelease
                        })
                        .ToList()
                })
                .FirstAsync();

            return crew;
        }
    }
}
