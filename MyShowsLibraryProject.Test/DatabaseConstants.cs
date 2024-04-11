using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.EpisodeModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Models.SeasonModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    public static class DatabaseConstants
    {
        public static MovieFormModel? Movie;
        public static SerieFormModel? Serie;
        public static CrewFormModel? Crew;
        public static GenreFormModel? Genre;
        public static RoleFormModel? Role;
        public static SeasonFormModel? Season;
        public static EpisodeFormModel? Episode;
        public static MovieReview? MovieReview; 

        public static MovieFormModel CreateMovieModel()
        {
            var movie = new MovieFormModel()
            {
                Title = "Test",
                Duration = 156,
                PosterUrl = "https://timesofindia.indiatimes.com/photo/90355881.cms",
                TrailerUrl = "https://youtu.be/TWqxHhSS218?si=VLqylZjkkAZKr7H6",
                DateOfRelease = "25 may 2007",
                OriginalAudioLanguage = "english",
                Summary = "Black Manta seeks revenge on Aquaman for his father's death. Wielding the Black Trident's power, he becomes a formidable foe." +
                   " To defend Atlantis, Aquaman forges an alliance with his imprisoned brother." +
                   " They must protect the kingdom.",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Aquaman_and_the_Lost_Kingdom"
            };


            return movie;
        }
        public static SerieFormModel CreateSerieModel()
        {
            var serie = new SerieFormModel()
            {
                Title = "Test",
                PosterUrl = "https://i.pinimg.com/736x/66/25/6b/66256bac418df674bd50ab9e63e14e42.jpg",
                TrailerUrl = "https://youtu.be/MczMB8nU1sY?si=Q2f0MfUNwWEQyNRJ",
                YearOfStart = "2004",
                YearOfEnd = "2012",
                Summary = "Using a crack team of doctors and his wits, an antisocial maverick doctor specializing in diagnostic" +
                " medicine does whatever it takes to solve puzzling cases that come his way.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/House_(TV_series)",
                Seasons = new List<Season>()
            };

            return serie;
        }
        public static CrewFormModel CreateCrewModel()
        {
            var crew = new CrewFormModel()
            {
                Name = "Test",
                Pseudonyms = string.Empty,
                Birthdate = "13 Jan 1995",
                Nationality = "American",
                PictureUrl = "https://image.tmdb.org/t/p/original/es3M6TgJxhe43G4NOFn1zQeJ0LI.jpg",
                Biography = "Natalia Dyer is an American actress known primarily" +
               " for her role as Nancy Wheeler in the Netflix science-fiction drama" +
               " series Stranger Things (2016). Her career began around the age of 12" +
               " in 2009 in the family comedic drama Hannah Montana: The Movie (2009)," +
               " starring Miley Cyrus. It was not until her late teens that she landed " +
               "her breakthrough role on Netflix's horror drama series Stranger Things (2016).",
                MoreInfo = "https://en.wikipedia.org/wiki/Natalia_Dyer"
            };

            return crew;
        }
        public static CrewFormModel CreateNullCrewModel()
        {
            var crew = new CrewFormModel()
            {
                Name = "Kit Harington",
                Pseudonyms = string.Empty,
                Birthdate = "26 Dec 1986",
                Nationality = "English",
                PictureUrl = "https://hips.hearstapps.com/harpersbazaaruk.cdnds.net/15/37/original/original-kit-sq-jpg-68954c3a.jpg?resize=980:*",
                Biography = "Kit Harington was born Christopher Catesby Harington in Acton, London, " +
                "to Deborah Jane (Catesby), a former playwright, and David Richard Harington, a businessman. " +
                "His mother named him after 16th-century British playwright and poet Christopher Marlowe, " +
                "whose first name was shortened to Kit, a name Harington prefers. Harington's uncle is " +
                "Sir Nicholas John Harington, the 14th Baronet Harington, and his paternal great-grandfather " +
                "was Sir Richard Harington, the 12th Baronet Harington. Through his paternal grandmother, " +
                "Lavender Cecilia Denny, Kit's eight times great-grandfather was King Charles II of England." +
                " Also through his father, Harington descends from politician Henry Dundas, 1st Viscount Melville," +
                " the bacon merchant T. A. Denny, clergyman Baptist Wriothesley Noel, merchant and politician Peter Baillie," +
                " peer William Legge, 4th Earl of Dartmouth, and MP Sir William Molesworth, 6th Baronet.",
                MoreInfo = "https://en.wikipedia.org/wiki/Kit_Harington"
            };

            return crew;
        }
        public static SeasonFormModel CreateSeasonModel()
        {
            var season = new SeasonFormModel()
            {
                PosterUrl = "https://fr.web.img5.acsta.net/pictures/19/06/05/14/48/2098547.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2004",
                EpisodesInSeason = "22",
                SeriesId = 1
            };

            return season;
        }
        public static EpisodeFormModel CreateEpisodeModel()
        {
            var episode = new EpisodeFormModel()
            {
                SeasonNumber = 1,
                EpisodeNumeration = 1,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BOTAwMDc3NTQ3NF5BMl5BanBnXkFtZTcwNTM3MjEwMg@@._V1_FMjpg_UX1000_.jpg",
                Summary = "Young kindergarten teacher Rebecca Adler collapses in her classroom after losing intelligible" +
                " speech while teaching students.",
                ReleaseDate = "16 Nov 2004",
                SeasonId = 1
            };

            return episode;
        }
        public static ReviewFormModel CreateReview()
        {
            var movieReview = new ReviewFormModel()
            {
                Rating = 5,
                Content = "Test review!"
            };

            return movieReview;
        }
        public static MovieFormModel MovieForEdit()
        {
            var movieToEdit = new MovieFormModel()
            {
                Title = "Test",
                Duration = 116,
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d2/Back_to_the_Future.jpg/220px-Back_to_the_Future.jpg",
                TrailerUrl = "https://www.youtube.com/embed/qvsgGtivCgs?si=fc5W3Tjq1xSBOYoZ&amp",
                DateOfRelease = "03 Jul 1985",
                Summary = "Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the " +
                "past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Back_to_the_Future"
            };

            return movieToEdit;
        }
        public static SerieFormModel SerieForEdit()
        {
            var serieToEdit = new SerieFormModel()
            {
                Title = "Test",
                PosterUrl = "https://i.pinimg.com/originals/ac/4f/fd/ac4ffd8309980a091dd1dc57abe908b4.jpg",
                TrailerUrl = "https://www.youtube.com/embed/bjqEWgDVPe0?si=1az-pQmunA3VvNlG",
                YearOfStart = "2011",
                YearOfEnd = "2019",
                Summary = "Nine noble families fight for control over the lands of Westeros," +
                " while an ancient enemy returns after being dormant for a millennia.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Game_of_Thrones",
                Seasons = new List<Season>()
            };

            return serieToEdit;
        }
        public static CrewFormModel CrewForEdit()
        {
            var crew = new CrewFormModel()
            {
                Name = "Test",
                Pseudonyms = string.Empty,
                Birthdate = "26 Dec 1986",
                Nationality = "English",
                PictureUrl = "https://hips.hearstapps.com/harpersbazaaruk.cdnds.net/15/37/original/original-kit-sq-jpg-68954c3a.jpg?resize=980:*",
                Biography = "Kit Harington was born Christopher Catesby Harington in Acton, London, " +
               "to Deborah Jane (Catesby), a former playwright, and David Richard Harington, a businessman. " +
               "His mother named him after 16th-century British playwright and poet Christopher Marlowe, " +
               "whose first name was shortened to Kit, a name Harington prefers. Harington's uncle is " +
               "Sir Nicholas John Harington, the 14th Baronet Harington, and his paternal great-grandfather " +
               "was Sir Richard Harington, the 12th Baronet Harington. Through his paternal grandmother, " +
               "Lavender Cecilia Denny, Kit's eight times great-grandfather was King Charles II of England." +
               " Also through his father, Harington descends from politician Henry Dundas, 1st Viscount Melville," +
               " the bacon merchant T. A. Denny, clergyman Baptist Wriothesley Noel, merchant and politician Peter Baillie," +
               " peer William Legge, 4th Earl of Dartmouth, and MP Sir William Molesworth, 6th Baronet.",
                MoreInfo = "https://en.wikipedia.org/wiki/Kit_Harington"
            };

            return crew;
        }
        public static GenreFormModel GenreForEditAndCreate()
        {
            var genre = new GenreFormModel()
            {
                Name = "Test"
            };

            return genre;
        }
        public static RoleFormModel RoleForEditAndCreate()
        {
            var role = new RoleFormModel()
            {
                Name = "Test"
            };

            return role;
        }
        public static RoleFormModel ExistedRole()
        {
            var role = new RoleFormModel()
            {
                Name = "Actor",
            };

            return role;
        }
        public static SeasonFormModel SeasonForEdit()
        {
            var season = new SeasonFormModel()
            {
                PosterUrl = "https://fr.web.img5.acsta.net/pictures/19/06/05/14/48/2098547.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2000",
                EpisodesInSeason = "22",
                SeriesId = 1
            };

            return season;
        }
        public static EpisodeFormModel EpisodeForEdit()
        {
            var episode = new EpisodeFormModel()
            {
                SeasonNumber = 1,
                EpisodeNumeration = 1,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BOTAwMDc3NTQ3NF5BMl5BanBnXkFtZTcwNTM3MjEwMg@@._V1_FMjpg_UX1000_.jpg",
                Summary = "Young kindergarten teacher Rebecca Adler collapses in her classroom after losing intelligible" +
                " speech while teaching students.",
                ReleaseDate = "16 Dec 2000",
                SeasonId = 1
            };

            return episode;
        }
        public static ReviewFormModel ReviewForEdit()
        {
            var review = new ReviewFormModel()
            {
                Rating = 5,
                Content = "Test!"
            };

            return review;
        }
    }
}
