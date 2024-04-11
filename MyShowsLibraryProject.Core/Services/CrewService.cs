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

        public CrewService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<CrewInfoServiceModel>> GetAllReadonlyAsync()
        {
            var crew = await repository
                .TakeAllReadOnly<Crew>()
                .Select(c => new CrewInfoServiceModel
                {
                    CrewId = c.CrewId,
                    Name = c.Name
                })
                .ToListAsync();

            return crew;
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
                            RoleId = cr.Role.RoleId,
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
                .FirstOrDefaultAsync();

            if (crew == null)
            {
                throw new ArgumentNullException("Crew does not exists!");
            }

            return crew;
        }
        public async Task<int> GetCrewName(string crewName)
        {
            var crewId = await repository.TakeAllReadOnly<Crew>()
                .Where(c => c.Name == crewName)
                .Select(c => c.CrewId)
                .FirstOrDefaultAsync();

            return crewId;
        }
        public async Task<int> CreateAsync(CrewFormModel crew)
        {
            var crewId = await GetCrewName(crew.Name);

            if (crewId != 0)
            {
                throw new ArgumentException("Crew with this name already exists!");
            }

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
            await repository.SaveChangesAsync();

            return newCrew.CrewId;
        }
        public async Task EditAsync(int crewId, CrewFormModel crew)
        {
        var crewToEdit = await repository.GetByIdAsync<Crew>(crewId);

            if (crewToEdit == null)
            {
                throw new ArgumentNullException("Crew does not exists!");
            }

            crewToEdit.Name = crew.Name;
            crewToEdit.Pseudonyms = crew.Pseudonyms;
            crewToEdit.Birthdate = crew.Birthdate;
            crewToEdit.Nationality = crew.Nationality;
            crewToEdit.PictureUrl = crew.PictureUrl;
            crewToEdit.Biography = crew.Biography;
            crewToEdit.MoreInfo = crew.MoreInfo;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int crewId)
        {
            await repository.DeleteAsync<Crew>(crewId);
            await repository.SaveChangesAsync();
        }
    }
}
