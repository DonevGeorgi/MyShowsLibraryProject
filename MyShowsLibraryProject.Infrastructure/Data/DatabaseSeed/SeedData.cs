using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed
{
    internal class SeedData
    {
        //Genres
        public Genre ActionGenre { get; set; }
        public Genre ComedyGenre { get; set; }
        public Genre DramaGenre { get; set; }
        public Genre FantasyGenre { get; set; }
        public Genre HorrorGenre { get; set; }
        public Genre MysteryGenre { get; set; }
        public Genre RomanceGenre { get; set; }
        public Genre ThrillerGenre { get; set; }
        public Genre WesternGenre { get; set; }
        public Genre AdventureGenre { get; set; }
        public Genre SciFiGenre { get; set; }
        //Roles
        public Role DirectorRole { get; set; }
        public Role WriterRole { get; set; }
        public Role ActorRole { get; set; }
        public Role ProducerRole { get; set; }
        public Role MusicComposerRole { get; set; }
        public Role CinematographerRole { get; set; }
        public Role EditorRole { get; set; }
        public Role ArtDirectorRole { get; set; }
        public Role CostumeDesignerRole { get; set; }
        //Movies
        public Movie FirstMovie { get; set; }
        public Movie SecondMovie { get; set; }
        public Movie ThirdMovie { get; set; }
        public Movie FourthMovie { get; set; }
        public Movie FifthMovie { get; set; }
        public Movie SixthMovie { get; set; }
        public Movie SeventhMovie { get; set; }
        public Movie EighthMovie { get; set; }
        public Movie NinthMovie { get; set; }
        public Movie TenthMovie { get; set; }
        public Movie EleventhMovie { get; set; }
        public Movie TwelfthMovie { get; set; }

        //Series
        public Serie FirstSerie { get; set; }
        public Serie SecondSerie { get; set; }
        public Serie ThirdSerie { get; set; }
        public Serie FourthSerie { get; set; }
        public Serie FifthSerie { get; set; }
        public Serie SixthSerie { get; set; }
        public Serie SeventhSerie { get; set; }
        public Serie EighthSerie { get; set; }
        public Serie NinthSerie { get; set; }
        public Serie TenthSerie { get; set; }
        public Serie EleventhSerie { get; set; }
        public Serie TwelfthSerie { get; set; }
        //Seasons
        public Season GotFirstSeason { get; set; }
        public Season GotSecondSeason { get; set; }
        public Season GotThirdSeason { get; set; }
        public Season GotFourthSeason { get; set; }
        public Season DaredevilFirstSeason { get; set; }
        public Season StrangerThingsFirstSeason { get; set; }
        public Season StrangerThingsSecondSeason { get; set; }
        public Season ThreeBodyProblemFirstSeason { get; set; }
        //Episodes
        public Episode GotS1FirstEpisode { get; set; }
        public Episode GotS1SecondEpisode { get; set; }
        public Episode GotS1ThirdEpisode { get; set; }
        public Episode GotS1FourthEpisode { get; set; }
        public Episode GotS1FifthEpisode { get; set; }
        public Episode GotS1SixthEpisode { get; set; }
        public Episode GotS1SeventhEpisode { get; set; }
        public Episode GotS1EighthEpisode { get; set; }
        public Episode GotS1NinthEpisode { get; set; }
        public Episode GotS1TenthEpisode { get; set; }
        public Episode GotS2FirstEpisode { get; set; }
        public Episode GotS2SecondEpisode { get; set; }
        public Episode GotS2ThirdEpisode { get; set; }
        public Episode GotS2FourthEpisode { get; set; }
        public Episode GotS2FifthEpisode { get; set; }
        public Episode GotS2SixthEpisode { get; set; }
        public Episode GotS2SeventhEpisode { get; set; }
        public Episode GotS2EighthEpisode { get; set; }
        public Episode GotS2NinthEpisode { get; set; }
        public Episode GotS2TenthEpisode { get; set; }
        public Episode GotS3FirstEpisode { get; set; }
        public Episode GotS3SecondEpisode { get; set; }
        public Episode GotS3ThirdEpisode { get; set; }
        public Episode GotS3FourthEpisode { get; set; }
        public Episode GotS3FifthEpisode { get; set; }
        public Episode GotS3SixthEpisode { get; set; }
        public Episode GotS3SeventhEpisode { get; set; }
        public Episode GotS3EighthEpisode { get; set; }
        public Episode GotS3NinthEpisode { get; set; }
        public Episode GotS3TenthEpisode { get; set; }
        public Episode GotS4FirstEpisode { get; set; }
        public Episode GotS4SecondEpisode { get; set; }
        public Episode GotS4ThirdEpisode { get; set; }
        public Episode GotS4FourthEpisode { get; set; }
        public Episode GotS4FifthEpisode { get; set; }
        public Episode GotS4SixthEpisode { get; set; }
        public Episode GotS4SeventhEpisode { get; set; }
        public Episode GotS4EighthEpisode { get; set; }
        public Episode GotS4NinthEpisode { get; set; }
        public Episode GotS4TenthEpisode { get; set; }
        public Episode BPS1FirstEpisode { get; set; }
        public Episode BPS1SecondEpisode { get; set; }
        public Episode BPS1ThirdEpisode { get; set; }
        public Episode BPS1FourthEpisode { get; set; }
        public Episode BPS1FifthEpisode { get; set; }
        public Episode BPS1SixthEpisode { get; set; }
        public Episode BPS1SeventhEpisode { get; set; }
        public Episode BPS1EighthEpisode { get; set; }
        //Crews
        public Crew BTFDirector { get; set; }
        public Crew BTFFirstActor { get; set; }
        public Crew BTFWriter { get; set; }
        public Crew GOTDirector { get; set; }
        public Crew GOTWriter { get; set; }
        public Crew GOTFirstActor { get; set; }
        public Crew GOTSecondActor { get; set; }
        public Crew GOTThirdActor { get; set; }
        public Crew GOTFourthActor { get; set; }
        public Crew GOTFifthActor { get; set; }

        //MovieCrews
        public MovieCrew MCFirstConnection { get; set; }
        public MovieCrew MCSecondConnection { get; set; }
        public MovieCrew MCThirdConnection { get; set; }
        //SerieCrews
        public SerieCrew SCFirstConnection { get; set; }
        public SerieCrew SCSecondConnection { get; set; }
        public SerieCrew SCThirdConnection { get; set; }
        public SerieCrew SCFourthConnection { get; set; }
        public SerieCrew SCFifthConnection { get; set; }
        public SerieCrew SCSixthConnection { get; set; }
        public SerieCrew SCSeventhConnection { get; set; }
        public SerieCrew SCEighthConnection { get; set; }
        public SerieCrew SCNinthConnection { get; set; }
        //MovieGenres
        public MovieGenre MGFirstConnection { get; set; }
        public MovieGenre MGSecondConnection { get; set; }
        public MovieGenre MGThirdConnection { get; set; }
        //SerieGenres
        public SerieGenre SGFirstConnection { get; set; }
        public SerieGenre SGSecondConnection { get; set; }
        public SerieGenre SGThirdConnection { get; set; }
        //CrewRoles
        public CrewRole CRFirstConnection { get; set; }
        public CrewRole CRSecondConnection { get; set; }
        public CrewRole CRThirdConnection { get; set; }
        public CrewRole CRFourthConnection { get; set; }
        public CrewRole CRFifthConnection { get; set; }
        public CrewRole CRSixthConnection { get; set; }
        public CrewRole CRSeventhConnection { get; set; }
        public CrewRole CREighthConnection { get; set; }
        public CrewRole CRNinthConnection { get; set; }
        public CrewRole CRTenthConnection { get; set; }
        public CrewRole CREleventhConnection { get; set; }
        public CrewRole CRTwelfthConnection { get; set; }
        public CrewRole CRThirteenthConnection { get; set; }
        public CrewRole CRFourteenthConnection { get; set; }
        public CrewRole CRFifteenthConnection { get; set; }
        public CrewRole CRSixteenthConnection { get; set; }
        public CrewRole CRSeventeenthConnection { get; set; }
        public CrewRole CREighteenthConnection { get; set; }
        public CrewRole CRNineteenthConnection { get; set; }
        public CrewRole CRTwentiethConnection { get; set; }
        public CrewRole CRTwentyFirstConnection { get; set; }
        public CrewRole CRTwentySecondConnection { get; set; }
        public CrewRole CRTwentyThirdConnection { get; set; }
        //Reviews
        public Review ReviewForMovie { get; set; }
        public Review ReviewForSerie { get; set; }
        //MovieReviews
        public MovieReview MRFirstConnection { get; set; }
        //SerieReviews
        public SerieReview SRFirstConnection { get; set; }
        //UserReviews
        public UserReview URFirstConnection { get; set; }
        public UserReview URSecondConnection { get; set; }

        public SeedData()
        {
            SeedCrew();
            SeedGenre();
            SeedMovie();
            SeedSerie();
            SeedSeason();
            SeedRole();
            SeedEpisode();
            SeedMovieCrew();
            SeedSerieCrew();
            SeedMovieGenres();
            SeedSerieGenres();
            SeedCrewRole();
            SeedReview();
            SeedMovieReview();
            SeedSerieReview();
            SeedUserReview();
        }

        private void SeedGenre()
        {
            ActionGenre = new Genre()
            {
                GenreId = 1,
                Name = "Action"
            };

            ComedyGenre = new Genre()
            {
                GenreId = 2,
                Name = "Comedy"
            };

            DramaGenre = new Genre()
            {
                GenreId = 3,
                Name = "Drama"
            };

            FantasyGenre = new Genre()
            {
                GenreId = 4,
                Name = "Fantasy"
            };

            HorrorGenre = new Genre()
            {
                GenreId = 5,
                Name = "Horror"
            };

            MysteryGenre = new Genre()
            {
                GenreId = 6,
                Name = "Mystery"
            };

            RomanceGenre = new Genre()
            {
                GenreId = 7,
                Name = "Romance"
            };

            ThrillerGenre = new Genre()
            {
                GenreId = 8,
                Name = "Thriller"
            };

            WesternGenre = new Genre()
            {
                GenreId = 9,
                Name = "Western"
            };

            AdventureGenre = new Genre()
            {
                GenreId = 10,
                Name = "Adventure"
            };

            SciFiGenre = new Genre()
            {
                GenreId = 11,
                Name = "Sci-Fi"
            };
        }
        private void SeedRole()
        {
            DirectorRole = new Role()
            {
                RoleId = 1,
                Name = "Director"
            };

            WriterRole = new Role()
            {
                RoleId = 2,
                Name = "Writer"
            };

            ActorRole = new Role()
            {
                RoleId = 3,
                Name = "Actor"
            };

            ProducerRole = new Role()
            {
                RoleId = 4,
                Name = "Producer"
            };

            MusicComposerRole = new Role()
            {
                RoleId = 5,
                Name = "Music Composer"
            };

            CinematographerRole = new Role()
            {
                RoleId = 6,
                Name = "Cinematographer"
            };

            EditorRole = new Role()
            {
                RoleId = 7,
                Name = "Editor"
            };

            ArtDirectorRole = new Role()
            {
                RoleId = 8,
                Name = "ArtDirector"
            };

            CostumeDesignerRole = new Role()
            {
                RoleId = 9,
                Name = "CostumeDesigner"
            };
        }
        private void SeedMovie()
        {
            FirstMovie = new Movie()
            {
                MovieId = 1,
                Title = "Back to the Future",
                Duration = 116,
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d2/Back_to_the_Future.jpg/220px-Back_to_the_Future.jpg",
                TrailerUrl = "https://www.youtube.com/embed/qvsgGtivCgs?si=fc5W3Tjq1xSBOYoZ&amp",
                DateOfRelease = "03 Jul 1985",
                Summary = "Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the " +
                "past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Back_to_the_Future"
            };
            SecondMovie = new Movie()
            {
                MovieId = 2,
                Title = "The Godfather",
                Duration = 175,
                PosterUrl = "https://media.posterlounge.com/img/products/710000/707663/707663_poster.jpg",
                TrailerUrl = "https://www.youtube.com/embed/UaVTIH8mujA?si=nO7BYx5S4L8-CYZk",
                DateOfRelease = "14 Mar 1972",
                Summary = "The aging patriarch of an organized crime dynasty transfers control of his" +
                " clandestine empire to his reluctant son.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/The_Godfather"
            };
            ThirdMovie = new Movie()
            {
                MovieId = 3,
                Title = "The Dark Knight",
                Duration = 152,
                PosterUrl = "https://musicart.xboxlive.com/7/abb02f00-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080",
                TrailerUrl = "https://www.youtube.com/embed/EXeTwQWrcwY?si=d59GNM5M9oKK3tlv",
                DateOfRelease = "14 Jun 2008",
                Summary = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and" +
                " physical tests of his ability to fight injustice.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/The_Dark_Knight"
            };
            FourthMovie = new Movie()
            {
                MovieId = 4,
                Title = "Fight Club",
                Duration = 139,
                PosterUrl = "https://img.peliplat.com/api/resize/v1?imagePath=std/202202/6/b/6baf78ae0fc42ca861b7fcc908fe7c82.jpg",
                TrailerUrl = "https://www.youtube.com/embed/SUXWAEX2jlg?si=Ij-le8G1Vt-9xT8l",
                DateOfRelease = "10 Sep 1999",
                Summary = "An insomniac office worker and a devil-may-care soap maker form an underground" +
                " fight club that evolves into much more.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Fight_Club"
            };
            FifthMovie = new Movie()
            {
                MovieId = 5,
                Title = "Inception",
                Duration = 148,
                PosterUrl = "https://www.scope.dk/shared/39/204/syncopy-inception_400x600c.jpg",
                TrailerUrl = "https://www.youtube.com/embed/YoHD9XEInc0?si=_NbDbg1IoSGsPppZ",
                DateOfRelease = "08 Jul 2010",
                Summary = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., " +
                "but his tragic past may doom the project and his team to disaster.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Inception"
            };
            SixthMovie = new Movie()
            {
                MovieId = 6,
                Title = "Se7en",
                Duration = 127,
                PosterUrl = "https://vistapointe.net/images/se7en-wallpaper-11.jpg",
                TrailerUrl = "https://www.youtube.com/embed/znmZoVkCjpI?si=3THi5wYLOiRpBgA7",
                DateOfRelease = "22 Sep 1995",
                Summary = "Two detectives, a rookie and a veteran, hunt a serial killer who " +
                "uses the seven deadly sins as his motives.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Seven_(1995_film)"
            };
            SeventhMovie = new Movie()
            {
                MovieId = 7,
                Title = "Interstellar",
                Duration = 169,
                PosterUrl = "https://consequence.net/wp-content/uploads/2014/11/interstellar.png?resize=768",
                TrailerUrl = "https://www.youtube.com/embed/zSWdZVtXT7E?si=_bQcYaqCJw9DuzxO",
                DateOfRelease = "26 Oct 2014",
                Summary = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft," +
                " along with a team of researchers, to find a new planet for humans.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Interstellar_(film)"
            };
            EighthMovie = new Movie()
            {
                MovieId = 8,
                Title = "Law Abiding Citizen",
                Duration = 118,
                PosterUrl = "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/p3632501_p_v8_ao.jpg",
                TrailerUrl = "https://www.youtube.com/embed/LX6kVRsdXW4?si=z4JvIvrRC-OC07ZZ",
                DateOfRelease = "16 Oct 2009",
                Summary = "A frustrated man decides to take justice into his own hands" +
                " after a plea bargain sets one of his family's killers free.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Law_Abiding_Citizen"
            };
            NinthMovie = new Movie()
            {
                MovieId = 9,
                Title = "Spider-Man: Across the Spider-Verse",
                Duration = 140,
                PosterUrl = "https://tickets.imagix.be/system/images/posters/000/000/905/medium.jpg?1684928515",
                TrailerUrl = "https://www.youtube.com/embed/cqGjhVJWtEg?si=I6najQbKn348h0Av",
                DateOfRelease = "30 May 2023",
                Summary = "Miles Morales catapults across the multiverse, where he encounters" +
                " a team of Spider-People charged with protecting its very existence. " +
                "When the heroes clash on how to handle a new threat, " +
                "Miles must redefine what it means to be a hero.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Spider-Man:_Across_the_Spider-Verse"
            };
            TenthMovie = new Movie()
            {
                MovieId = 10,
                Title = "Spirited Away",
                Duration = 125,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjlmZmI5MDctNDE2YS00YWE0LWE5ZWItZDBhYWQ0NTcxNWRhXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/ByXuk9QqQkk?si=qym82LBRSX9w_0Vd",
                DateOfRelease = "20 Jun 2001",
                Summary = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods," +
                " witches and spirits, and where humans are changed into beasts.",
                OriginalAudioLanguage = "Japanese",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Spirited_Away"
            };
            EleventhMovie = new Movie()
            {
                MovieId = 11,
                Title = "Gladiator",
                Duration = 155,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMDliMmNhNDEtODUyOS00MjNlLTgxODEtN2U3NzIxMGVkZTA1L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/P5ieIbInFpg?si=Vrd2Zatk6M3ichNU",
                DateOfRelease = "01 May 2000",
                Summary = "A former Roman General sets out to exact vengeance against the " +
                "corrupt emperor who murdered his family and sent him into slavery.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Gladiator_(2000_film)"
            };
            TwelfthMovie = new Movie()
            {
                MovieId = 12,
                Title = "The Lion King",
                Duration = 88,
                PosterUrl = "https://lumiere-a.akamaihd.net/v1/images/p_thelionking_19752_1_0b9de87b.jpeg?region=0%2C0%2C540%2C810",
                TrailerUrl = "https://www.youtube.com/embed/lFzVJEksoDY?si=FkT-KFkh8eehzta_",
                DateOfRelease = "15 Jun 1994",
                Summary = "Lion prince Simba and his father are targeted by his bitter uncle," +
                " who wants to ascend the throne himself.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/The_Lion_King"
            };
        }
        private void SeedSerie()
        {
            FirstSerie = new Serie()
            {
                SeriesId = 1,
                Title = "Game of Thrones",
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
            SecondSerie = new Serie()
            {
                SeriesId = 2,
                Title = "Daredevil",
                PosterUrl = "https://i.ebayimg.com/images/g/4roAAOSwU-pXtiYt/s-l1600.jpg",
                TrailerUrl = "https://www.youtube.com/embed/jAy6NJ_D5vU?si=bipQvQKvZA5weoWd",
                YearOfStart = "2015",
                YearOfEnd = "2018",
                Summary = "A blind lawyer by day, vigilante by night." +
                " Matt Murdock fights the crime of New York as Daredevil.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Daredevil_(TV_series)",
                Seasons = new List<Season>()
            };
            ThirdSerie = new Serie()
            {
                SeriesId = 3,
                Title = "3 Body Problem",
                PosterUrl = "https://dnm.nflximg.net/api/v6/2DuQlx0fM4wd1nzqm5BFBi6ILa8/AAAAQZlc5jetJ-D7HB82kd0QKhDPoQtVo0ez6AgsRBt7WnoqCe1NMdjNxuZPe5fQVeMXvQAvlZTQwo5NL_M2xhpfNikQkyynm0hjIpAEJ63kaCMD7tpb7DE2GyspOeL_u8idcYLvtb0c6_XMzHCqScBJNLW6.jpg?r=c4c",
                TrailerUrl = "https://www.youtube.com/embed/mogSbMD6EcY?si=waJ7TQKmX5OsPE02",
                YearOfStart = "2024",
                YearOfEnd = "",
                Summary = "A fateful decision made in 1960s China reverberates in the present, where a group of" +
                " scientists partner with a detective to confront an existential planetary threat.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/3_Body_Problem_(TV_series)",
                Seasons = new List<Season>()
            };
            FourthSerie = new Serie()
            {
                SeriesId = 4,
                Title = "The Flash",
                PosterUrl = "https://hips.hearstapps.com/digitalspyuk.cdnds.net/14/35/ustv-the-flash-poster.jpg",
                TrailerUrl = "https://www.youtube.com/embed/IgVyroQjZbE?si=PxdjkywdsIYAOKPv",
                YearOfStart = "2014",
                YearOfEnd = "2023",
                Summary = "After being struck by lightning, Barry Allen wakes up from " +
                "his coma to discover he's been given the power of super speed, becoming the Flash," +
                " and fighting crime in Central City.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/The_Flash_(2014_TV_series)",
                Seasons = new List<Season>()
            };
            FifthSerie = new Serie()
            {
                SeriesId = 5,
                Title = "Breaking Bad",
                PosterUrl = "https://images.genius.com/9cb7e19233ebb2693a005c8621504c34.1000x1000x1.jpg",
                TrailerUrl = "https://www.youtube.com/embed/HhesaQXLuRY?si=R-ATc5J-7f8YlAJT",
                YearOfStart = "2008",
                YearOfEnd = "2013",
                Summary = "A chemistry teacher diagnosed with inoperable lung cancer turns to " +
                "manufacturing and selling methamphetamine with a former student in order to secure" +
                " his family's future.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Breaking_Bad",
                Seasons = new List<Season>()
            };
            SixthSerie = new Serie()
            {
                SeriesId = 6,
                Title = "Sherlock",
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMWEzNTFlMTQtMzhjOS00MzQ1LWJjNjgtY2RhMjFhYjQwYjIzXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/IrBKwzL3K7s?si=rwD1zOXk1yJgpwNn",
                YearOfStart = "2010",
                YearOfEnd = "2017",
                Summary = "The quirky spin on Conan Doyle's iconic sleuth pitches him as a \"high-functioning sociopath\" in modern-day" +
                " London. Assisting him in his investigations: Afghanistan War vet John Watson, who's introduced to Holmes by a " +
                "mutual acquaintance.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Sherlock_(TV_series)",
                Seasons = new List<Season>()
            };
            SeventhSerie = new Serie()
            {
                SeriesId = 7,
                Title = "Black Mirror",
                PosterUrl = "https://www.revue-etudes.com/prod/file/etudes/article/picture/2946.jpg",
                TrailerUrl = "https://www.youtube.com/embed/5jY1ecibLYo?si=jaL2j2czFEXQT8oL",
                YearOfStart = "2011",
                YearOfEnd = "",
                Summary = "Featuring stand-alone dramas -- sharp, suspenseful, satirical tales that" +
                " explore techno-paranoia -- \"Black Mirror\" is a contemporary reworking of" +
                " \"The Twilight Zone\" with stories that tap into the collective unease about the" +
                " modern world.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Black_Mirror",
                Seasons = new List<Season>()
            };
            EighthSerie = new Serie()
            {
                SeriesId = 8,
                Title = "The Last of Us",
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BZGUzYTI3M2EtZmM0Yy00NGUyLWI4ODEtN2Q3ZGJlYzhhZjU3XkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/uLtkt8BonwM?si=7lVv06Q_ZAV7c8Au",
                YearOfStart = "2023",
                YearOfEnd = "",
                Summary = "After a global pandemic destroys civilization, a hardened survivor takes" +
                " charge of a 14-year-old girl who may be humanity's last hope.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/The_Last_of_Us_(TV_series)",
                Seasons = new List<Season>()
            };
            NinthSerie = new Serie()
            {
                SeriesId = 9,
                Title = "Peaky Blinders",
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BZjYzZDgzMmYtYjY5Zi00YTk1LThhMDYtNjFlNzM4MTZhYzgyXkEyXkFqcGdeQXVyMTE5NDQ1MzQ3._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/X3PGOaEfCmQ?si=lpU4Q_3Hy1v0uZqH",
                YearOfStart = "2013",
                YearOfEnd = "2022",
                Summary = "A gangster family epic set in 1900s England, centering on a gang who" +
                " sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Peaky_Blinders_(TV_series)",
                Seasons = new List<Season>()
            };
            TenthSerie = new Serie()
            {
                SeriesId = 10,
                Title = "Stranger Things",
                PosterUrl = "https://resizing.flixster.com/0xxuABVVuzJrUT130WFHKE-irEg=/ems.cHJkLWVtcy1hc3NldHMvdHZzZWFzb24vNzUyMTFhOTktZTU4Ni00ODkyLWJlYjQtZTgxYTllZmU2OGM0LmpwZw==",
                TrailerUrl = "https://www.youtube.com/embed/b9EkMc79ZSU?si=mRkshg9SYuYkdtYy",
                YearOfStart = "2016",
                YearOfEnd = "2025",
                Summary = "When a young boy vanishes, a small town uncovers a mystery involving " +
                "secret experiments, terrifying supernatural forces and one strange little girl.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Stranger_Things",
                Seasons = new List<Season>()
            };
            EleventhSerie = new Serie()
            {
                SeriesId = 11,
                Title = "House",
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMDA4NjQzN2ItZDhhNC00ZjVlLWFjNTgtMTEyNDQyOGNjMDE1XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/MczMB8nU1sY?si=AqO4vj535nUmLTRg",
                YearOfStart = "2004",
                YearOfEnd = "2012",
                Summary = "Using a crack team of doctors and his wits, an antisocial maverick doctor" +
                " specializing in diagnostic medicine does whatever it takes to solve puzzling cases " +
                "that come his way.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/House_(TV_series)",
                Seasons = new List<Season>()
            };
            TwelfthSerie = new Serie()
            {
                SeriesId = 12,
                Title = "Westworld",
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BZDg1OWRiMTktZDdiNy00NTZlLTg2Y2EtNWRiMTcxMGE5YTUxXkEyXkFqcGdeQXVyMTM2MDY0OTYx._V1_.jpg",
                TrailerUrl = "https://www.youtube.com/embed/9BqKiZhEFFw?si=p2zuNikDGCptxPAT",
                YearOfStart = "2016",
                YearOfEnd = "2022",
                Summary = "At the intersection of the near future and the reimagined past, " +
                "waits a world in which every human appetite can be indulged without consequence.",
                OriginalAudioLanguage = "English",
                ForMoreSummaryUrl = "https://en.wikipedia.org/wiki/Westworld_(TV_series)",
                Seasons = new List<Season>()
            };
        }
        private void SeedSeason()
        {
            GotFirstSeason = new Season()
            {
                SeasonId = 1,
                PosterUrl = "https://static.posters.cz/image/1300/posters/game-of-thrones-season-1-key-art-i161816.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2011",
                EpisodesInSeason = "10",
                SeriesId = 1,
                Episodes = new List<Episode>()
            };
            GotSecondSeason = new Season()
            {
                SeasonId = 2,
                PosterUrl = "https://game-of-thrones.io/Resources/Assets/images/cover-ss02.webp",
                SeasonNumeration = 2,
                YearOfRelease = "2012",
                EpisodesInSeason = "10",
                SeriesId = 1,
                Episodes = new List<Episode>()
            };
            GotThirdSeason = new Season()
            {
                SeasonId = 3,
                PosterUrl = "https://image.tmdb.org/t/p/original/5MkZjRnCKiIGn3bkXrXfndEzqOU.jpg",
                SeasonNumeration = 3,
                YearOfRelease = "2013",
                EpisodesInSeason = "10",
                SeriesId = 1,
                Episodes = new List<Episode>()
            };
            GotFourthSeason = new Season()
            {
                SeasonId = 4,
                PosterUrl = "https://cdn.europosters.eu/image/1300/art-photo/game-of-thrones-season-4-key-art-i135464.jpg",
                SeasonNumeration = 4,
                YearOfRelease = "2014",
                EpisodesInSeason = "10",
                SeriesId = 1,
                Episodes = new List<Episode>()
            };
            DaredevilFirstSeason = new Season()
            {
                SeasonId = 5,
                PosterUrl = "https://s3.thcdn.com/productimg/960/960/11312344-1464426542292674.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2015",
                EpisodesInSeason = "13",
                SeriesId = 2,
                Episodes = new List<Episode>()
            };
            StrangerThingsFirstSeason = new Season()
            {
                SeasonId = 6,
                PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/81cB9M7ZLwL._AC_SL1200_.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2016",
                EpisodesInSeason = "8",
                SeriesId = 10,
                Episodes = new List<Episode>()
            };
            StrangerThingsSecondSeason = new Season()
            {
                SeasonId = 7,
                PosterUrl = "https://assets.exclaim.ca/image/upload/strangerthings2_2.jpg",
                SeasonNumeration = 2,
                YearOfRelease = "2017",
                EpisodesInSeason = "9",
                SeriesId = 10,
                Episodes = new List<Episode>()
            };
            ThreeBodyProblemFirstSeason = new Season()
            {
                SeasonId = 8,
                PosterUrl = "https://res.cloudinary.com/jerrick/image/upload/c_crop,fl_progressive,h_630,q_auto,w_1200/xulbxvddyuexuzcdv3yt.jpg",
                SeasonNumeration = 1,
                YearOfRelease = "2024",
                EpisodesInSeason = "08",
                SeriesId = 3,
                Episodes = new List<Episode>()
            };
        }
        private void SeedEpisode()
        {
            GotS1FirstEpisode = new Episode()
            {
                EpisodeId = 1,
                SeasonNumber = 1,
                EpisodeNumeration = 1,
                PosterUrl = "https://static.hbo.com/content/dam/hbodata/series/game-of-thrones/video-stills/season-01/game-of-thrones-season-1-episode-1-full-stitched-607175_PRO35_10-1920.jpg",
                Summary = "Eddard Stark is torn between his family and an old " +
                "friend when asked to serve at the side of King Robert Baratheon," +
                "And in the other side of the world Viserys Targaryen plans to wed " +
                "his sister to a nomadic warlord in exchange for an army.",
                ReleaseDate = "18 Apr 2011",
                SeasonId = 1
            };
            GotS1SecondEpisode = new Episode()
            {
                EpisodeId = 2,
                SeasonNumber = 1,
                EpisodeNumeration = 2,
                PosterUrl = "https://cdn.vox-cdn.com/thumbor/hPCyBds5DKp5JcmzCgiBrQrQdi4=/0x0:1280x720/1600x900/cdn.vox-cdn.com/uploads/chorus_image/image/46094226/Jon_snow.0.jpg",
                Summary = "While Bran recovers from his fall, Ned takes only his daughters to King's Landing." +
                " Jon Snow goes with his uncle Benjen to the Wall. Tyrion joins them.",
                ReleaseDate = "25 Apr 2011",
                SeasonId = 1
            };
            GotS1ThirdEpisode = new Episode()
            {
                EpisodeId = 3,
                SeasonNumber = 1,
                EpisodeNumeration = 3,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/15/a2ca6975-7063-3bc0-a74a-634b49b97d74.jpeg?f=jpg&q=75&w=1280",
                Summary = "Jon begins his training with the Night's Watch;" +
                " Ned confronts his past and future at King's Landing;" +
                " Daenerys finds herself at odds with Viserys.",
                ReleaseDate = "1 May 2011",
                SeasonId = 1
            };
            GotS1FourthEpisode = new Episode()
            {
                EpisodeId = 4,
                SeasonNumber = 1,
                EpisodeNumeration = 4,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTMwNDQ0MTIyMl5BMl5BanBnXkFtZTcwODkxMzkxNA@@._V1_.jpg",
                Summary = "Eddard investigates Jon Arryn's murder. Jon befriends Samwell Tarly, " +
                "a coward who has come to join the Night's Watch.",
                ReleaseDate = "08 May 2011",
                SeasonId = 1
            };
            GotS1FifthEpisode = new Episode()
            {
                EpisodeId = 5,
                SeasonNumber = 1,
                EpisodeNumeration = 5,
                PosterUrl = "https://i.pinimg.com/originals/46/91/59/469159fbaa4eb301dbdc7717d823cd7a.jpg",
                Summary = "Catelyn has captured Tyrion and plans to bring him to her sister, Lysa Arryn," +
                " at the Vale, to be tried for his, supposed, crimes against Bran. Robert plans to have Daenerys killed," +
                " but Eddard refuses to be a part of it and quits.",
                ReleaseDate = "15 May 2011",
                SeasonId = 1
            };
            GotS1SixthEpisode = new Episode()
            {
                EpisodeId = 6,
                SeasonNumber = 1,
                EpisodeNumeration = 6,
                PosterUrl = "https://cdn.vox-cdn.com/thumbor/MKfDGE4yoWdp_x39u5yQyjaCjbw=/0x0:1920x1080/1400x1050/filters:focal(848x506:1154x812):no_upscale()/cdn.vox-cdn.com/uploads/chorus_image/image/56051735/a_golden_crown_1920.0.jpg",
                Summary = "While recovering from his battle with Jaime, Eddard is forced to run the kingdom " +
                "while Robert goes hunting. Tyrion demands a trial by combat for his freedom. " +
                "Viserys is losing his patience with Drogo.",
                ReleaseDate = "22 May 2011",
                SeasonId = 1
            };
            GotS1SeventhEpisode = new Episode()
            {
                EpisodeId = 7,
                SeasonNumber = 1,
                EpisodeNumeration = 7,
                PosterUrl = "https://img.buzzfeed.com/buzzfeed-static/static/2019-05/10/8/enhanced/buzzfeed-prod-web-03/enhanced-14778-1557491500-1.jpg",
                Summary = "Robert has been injured while hunting and is dying. Jon and the others " +
                "finally take their vows to the Night's Watch. A man, sent by Robert," +
                " is captured for trying to poison Daenerys. Furious, Drogo vows to attack the Seven Kingdoms.",
                ReleaseDate = "29 May 2011",
                SeasonId = 1
            };
            GotS1EighthEpisode = new Episode()
            {
                EpisodeId = 8,
                SeasonNumber = 1,
                EpisodeNumeration = 8,
                PosterUrl = "https://th.bing.com/th/id/R.3eb701872d74385c16cf27b11f08b8b3?rik=RltDJccLs1%2bT9A&pid=ImgRaw&r=0",
                Summary = "The Lannisters press their advantage over the Starks; Robb rallies his father's" +
                " northern allies and heads south to war; The White Walkers attack the Wall; Tyrion returns " +
                "to his father with some new friends.",
                ReleaseDate = "05 Jun 2011",
                SeasonId = 1
            };
            GotS1NinthEpisode = new Episode()
            {
                EpisodeId = 9,
                SeasonNumber = 1,
                EpisodeNumeration = 9,
                PosterUrl = "https://jackandthegeekstalk.files.wordpress.com/2017/08/maxresdefault-7.jpg?w=1080",
                Summary = "Robb goes to war against the Lannisters. Jon finds himself struggling on deciding " +
                "if his place is with Robb or the Night's Watch. Drogo has fallen ill from a fresh battle wound." +
                " Daenerys is desperate to save him.",
                ReleaseDate = "12 Jun 2011",
                SeasonId = 1
            };
            GotS1TenthEpisode = new Episode()
            {
                EpisodeId = 10,
                SeasonNumber = 1,
                EpisodeNumeration = 10,
                PosterUrl = "https://s1.dmcdn.net/v/GQYpO1ZeIODLfiWno/x1080",
                Summary = "Robb vows to get revenge on the Lannisters. Jon must officially decide if his place " +
                "is with Robb or the Night's Watch. Daenerys says her final goodbye to Drogo.",
                ReleaseDate = "19 Jun 2011",
                SeasonId = 1
            };
            GotS2FirstEpisode = new Episode()
            {
                EpisodeId = 11,
                SeasonNumber = 2,
                EpisodeNumeration = 1,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/e12b0dce-4721-3764-a31b-c216f26d70d8.jpeg?f=jpg&q=75&w=1280",
                Summary = "Tyrion arrives at King's Landing to take his father's place as " +
                "Hand of the King. Stannis Baratheon plans to take the Iron Throne for his own." +
                " Robb tries to decide his next move in the war. The Night's Watch arrive at " +
                "the house of Craster.",
                ReleaseDate = "01 Apr 2012",
                SeasonId = 2
            };
            GotS2SecondEpisode = new Episode()
            {
                EpisodeId = 12,
                SeasonNumber = 2,
                EpisodeNumeration = 2,
                PosterUrl = "https://advancelocal-adapter-image-uploads.s3.amazonaws.com/image.nj.com/home/njo-media/width2048/img/entertainment_impact_tv/photo/game-of-thrones-season-two-2-hbo-jon-snow-beyond-the-walljpg-2aa8494941b27aed.jpg",
                Summary = "Arya makes friends with Gendry. Tyrion tries to take control " +
                "of the Small Council. Theon arrives at his home, Pyke, in order to persuade " +
                "his father into helping Robb with the war. Jon tries to investigate Craster's secret.",
                ReleaseDate = "08 Apr 2012",
                SeasonId = 2
            };
            GotS2ThirdEpisode = new Episode()
            {
                EpisodeId = 13,
                SeasonNumber = 2,
                EpisodeNumeration = 3,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/587b66d8-ab0b-3ac7-ab7c-58582fdcfd2a.jpeg?f=jpg&q=75&w=1280",
                Summary = "Tyrion tries to see who he can trust in the Small Council. " +
                "Catelyn visits Renly to try and persuade him to join Robb in the war. " +
                "Theon must decide if his loyalties lie with his own family or with Robb.",
                ReleaseDate = "15 Apr 2012",
                SeasonId = 2
            };
            GotS2FourthEpisode = new Episode()
            {
                EpisodeId = 14,
                SeasonNumber = 2,
                EpisodeNumeration = 4,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/6e978756-92fd-3b3b-a377-b9c64d3e6760.jpeg?f=jpg&q=75&w=1280",
                Summary = "Lord Baelish arrives at Renly's camp just before he faces off against Stannis." +
                " Daenerys and her company are welcomed into the city of Qarth. Arya, Gendry, " +
                "and Hot Pie find themselves imprisoned at Harrenhal.",
                ReleaseDate = "22 Apr 2012",
                SeasonId = 2
            };
            GotS2FifthEpisode = new Episode()
            {
                EpisodeId = 15,
                SeasonNumber = 2,
                EpisodeNumeration = 5,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMWE0NjQ0MDQtM2E1Zi00MmRmLWI1NTUtNjJjMjQxMjY1Y2QxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg",
                Summary = "Tyrion investigates a secret weapon that King Joffrey plans to use against " +
                "Stannis. Meanwhile, as a token for saving his life, Jaqen H'ghar offers to kill " +
                "three people that Arya chooses.",
                ReleaseDate = "29 Apr 2012",
                SeasonId = 2
            };
            GotS2SixthEpisode = new Episode()
            {
                EpisodeId = 16,
                SeasonNumber = 2,
                EpisodeNumeration = 6,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BNDEyNDg1MzA4Ml5BMl5BanBnXkFtZTcwMDY4MTc3Nw@@._V1_.jpg",
                Summary = "Theon seizes control of Winterfell. Jon captures a wildling, named Ygritte." +
                " The people of King's Landing begin to turn against King Joffrey. " +
                "Daenerys looks to buy ships to sail for the Seven Kingdoms.",
                ReleaseDate = "06 May 2012",
                SeasonId = 2
            };
            GotS2SeventhEpisode = new Episode()
            {
                EpisodeId = 17,
                SeasonNumber = 2,
                EpisodeNumeration = 7,
                PosterUrl = "https://wallup.net/wp-content/uploads/2016/05/02/43210-Game_of_Thrones-Daenerys_Targaryen-Jorah_Mormont-748x421.jpg",
                Summary = "Bran and Rickon have escaped Winterfell. Theon tries to hunt them down. " +
                "Daenerys' dragons have been stolen. Jon travels through the wilderness with " +
                "Ygritte as his prisoner. Sansa has bled and is now ready to have Joffrey's children.",
                ReleaseDate = "13 May 2012",
                SeasonId = 2
            };
            GotS2EighthEpisode = new Episode()
            {
                EpisodeId = 18,
                SeasonNumber = 2,
                EpisodeNumeration = 8,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BM2FiNmM4OWItMmM5Yi00ODAwLWE5YTUtZGRmMmIyZTAwMDkxXkEyXkFqcGdeQXVyMjg2MTMyNTM@._V1_.jpg",
                Summary = "Stannis is just days from King's Landing. Tyrion prepares for his arrival. " +
                "Jon and Qhorin are taken prisoner by the wildlings. Catelyn is arrested for releasing " +
                "Jaime. Arya, Gendry, and Hot Pie plan to escape from Harrenhal.",
                ReleaseDate = "20 May 2012",
                SeasonId = 2
            };
            GotS2NinthEpisode = new Episode()
            {
                EpisodeId = 19,
                SeasonNumber = 2,
                EpisodeNumeration = 9,
                PosterUrl = "https://i.ytimg.com/vi/p-W8l3E4NVw/maxresdefault.jpg",
                Summary = "Stannis Baratheon's fleet and army arrive at King's Landing and the battle for the " +
                "city begins. Cersei plans for her and her children's future.",
                ReleaseDate = "27 May 2012",
                SeasonId = 2
            };
            GotS2TenthEpisode = new Episode()
            {
                EpisodeId = 20,
                SeasonNumber = 2,
                EpisodeNumeration = 10,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/9093fc33-7da9-3f45-a644-7953fe96e7ec.jpeg?f=jpg&q=75&w=1280",
                Summary = "Joffrey puts Sansa aside for Margaery Tyrell. Robb marries Talisa Maegyr. Jon prepares to meet Mance Rayder. " +
                "Arya says farewell to Jaqen H'ghar. Daenerys tries to rescue her dragons.",
                ReleaseDate = "03 Jun 2012",
                SeasonId = 2
            };
            GotS3FirstEpisode = new Episode()
            {
                EpisodeId = 21,
                SeasonNumber = 3,
                EpisodeNumeration = 1,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/53532aa4-1284-3b32-84fe-b1931862c929.jpeg?f=jpg&q=75&w=1280",
                Summary = "Jon is brought before Mance Rayder, the King Beyond the Wall, " +
                "while the Night's Watch survivors retreat south. In King's Landing, " +
                "Tyrion asks for his reward. Littlefinger offers Sansa a way out.",
                ReleaseDate = "31 May 2013",
                SeasonId = 3
            };
            GotS3SecondEpisode = new Episode()
            {
                EpisodeId = 22,
                SeasonNumber = 3,
                EpisodeNumeration = 2,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjAyNzk5NDQwNl5BMl5BanBnXkFtZTcwMTkxNTcyOQ@@._V1_.jpg",
                Summary = "Bran and company meet Jojen and Meera Reed. Arya, Gendry, " +
                "and Hot Pie meet the Brotherhood. Jaime travels through the wilderness with Brienne." +
                " Sansa confesses her true feelings about Joffery to Margaery.",
                ReleaseDate = "07 Apr 2013",
                SeasonId = 3
            };
            GotS3ThirdEpisode = new Episode()
            {
                EpisodeId = 23,
                SeasonNumber = 3,
                EpisodeNumeration = 3,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjA4ODQxNDEzMV5BMl5BanBnXkFtZTcwNjM4MzA0OQ@@._V1_.jpg",
                Summary = "Robb and Catelyn arrive at Riverrun for Lord Hoster Tully's funeral. " +
                "Tywin names Tyrion the new Master of Coin. Arya says goodbye to Hot Pie. " +
                "The Night's Watch returns to Craster's. Brienne and Jaime are taken prisoner.",
                ReleaseDate = "14 Apr 2013",
                SeasonId = 3
            };
            GotS3FourthEpisode = new Episode()
            {
                EpisodeId = 24,
                SeasonNumber = 3,
                EpisodeNumeration = 4,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTQ3MzEzMjA1Ml5BMl5BanBnXkFtZTcwMTcyMTEwOQ@@._V1_.jpg",
                Summary = "Jaime mopes over his lost hand. Cersei is growing uncomfortable with the " +
                "Tyrells. The Night's Watch is growing impatient with Craster. Daenerys buys the " +
                "Unsullied.",
                ReleaseDate = "21 Apr 2013",
                SeasonId = 3
            };
            GotS3FifthEpisode = new Episode()
            {
                EpisodeId = 25,
                SeasonNumber = 3,
                EpisodeNumeration = 5,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/03803cf5-f1b5-368c-8c9a-be2cb70a4b18.jpeg?f=jpg&q=75&w=1280",
                Summary = "Robb's army is falling apart. Jaime reveals a story, to Brienne, " +
                "that he has never told anyone. Jon breaks his vows. The Hound is granted his freedom." +
                " The Lannisters hatch a new plan.",
                ReleaseDate = "28 Apr 2013",
                SeasonId = 3
            };
            GotS3SixthEpisode = new Episode()
            {
                EpisodeId = 26,
                SeasonNumber = 3,
                EpisodeNumeration = 6,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/b0394adf-ca5e-3c46-b0cc-116931c56aae.jpeg?f=jpg&q=75&w=1280",
                Summary = "Jon and the wildlings scale the Wall. The Brotherhood sells Gendry to" +
                " Melisandre. Robb does what he can to win back the Freys. Tyrion tells Sansa" +
                " about their engagement.",
                ReleaseDate = "05 May 2013",
                SeasonId = 3
            };
            GotS3SeventhEpisode = new Episode()
            {
                EpisodeId = 27,
                SeasonNumber = 3,
                EpisodeNumeration = 7,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTQwMjQ1Njg5N15BMl5BanBnXkFtZTcwNzE1MjE1OQ@@._V1_.jpg",
                Summary = "Jon and the wildlings travel south of the Wall. Talisa tells Robb that she's " +
                "pregnant. Arya runs away from the Brotherhood. Daenerys arrives at Yunkai. " +
                "Jaime leaves Brienne behind at Harrenhal.",
                ReleaseDate = "12 May 2013",
                SeasonId = 3
            };
            GotS3EighthEpisode = new Episode()
            {
                EpisodeId = 28,
                SeasonNumber = 3,
                EpisodeNumeration = 8,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMzQ3NTgzNDUyN15BMl5BanBnXkFtZTcwNjAxODk1OQ@@._V1_.jpg",
                Summary = "Daenerys tries to persuade the Second Sons to join her against Yunkai." +
                " Stannis releases Davos from the dungeons. Sam and Gilly are attacked by a White Walker. Sansa and Tyrion wed.",
                ReleaseDate = "19 May 2013",
                SeasonId = 3
            };
            GotS3NinthEpisode = new Episode()
            {
                EpisodeId = 29,
                SeasonNumber = 3,
                EpisodeNumeration = 9,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTU3OTc2MTAxNF5BMl5BanBnXkFtZTcwODMxNDM2OQ@@._V1_.jpg",
                Summary = "Robb and Catelyn arrive at the Twins for the wedding. Jon is put to the " +
                "test to see where his loyalties truly lie. Bran's group decides to split up. " +
                "Daenerys plans an invasion of Yunkai.",
                ReleaseDate = "02 Jun 2013",
                SeasonId = 3
            };
            GotS3TenthEpisode = new Episode()
            {
                EpisodeId = 30,
                SeasonNumber = 3,
                EpisodeNumeration = 10,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/06d0f8ac-742c-3ae9-8938-479c759756ba.jpeg?f=jpg&q=75&w=1280",
                Summary = "Bran and company travel beyond the Wall. Sam returns to Castle Black." +
                " Jon says goodbye to Ygritte. Jaime returns to King's Landing." +
                " The Night's Watch asks for help from Stannis.",
                ReleaseDate = "09 Jun 2013",
                SeasonId = 3
            };
            GotS4FirstEpisode = new Episode()
            {
                EpisodeId = 31,
                SeasonNumber = 4,
                EpisodeNumeration = 1,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTA2NTk0OTY5MjdeQTJeQWpwZ15BbWU4MDk1MjUyNTEx._V1_.jpg",
                Summary = "Tyrion welcomes a guest to King's Landing. At Castle Black, " +
                "Jon stands trial. Daenerys is pointed to Meereen, the mother of all slave cities." +
                " Arya runs into an old enemy.",
                ReleaseDate = "06 Apr 2014",
                SeasonId = 4
            };
            GotS4SecondEpisode = new Episode()
            {
                EpisodeId = 32,
                SeasonNumber = 4,
                EpisodeNumeration = 2,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BNTE5ZjRkODItZDVmZi00MzY2LWE5OGEtZjBmMmY4MTQ1OTdkXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg",
                Summary = "Joffrey and Margaery's wedding has come. Tyrion breaks up with Shae." +
                " Ramsay tries to prove his worth to his father. Bran and company find a" +
                " Weirwood tree.",
                ReleaseDate = "13 Apr 2014",
                SeasonId = 4
            };
            GotS4ThirdEpisode = new Episode()
            {
                EpisodeId = 33,
                SeasonNumber = 4,
                EpisodeNumeration = 3,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/0a6306ca-cd2a-3fa6-aca2-486de26c4a20.jpeg?f=jpg&q=75&w=1280",
                Summary = "Tyrion is arrested for murder and awaits trial. Sansa escapes King's Landing." +
                " Sam sends Gilly to Mole's Town as the Night's Watch finds itself in a tight spot." +
                " Meereen challenges Daenerys.",
                ReleaseDate = "20 Apr 2014",
                SeasonId = 4
            };
            GotS4FourthEpisode = new Episode()
            {
                EpisodeId = 34,
                SeasonNumber = 4,
                EpisodeNumeration = 4,
                PosterUrl = "https://media.vanityfair.com/photos/535a7973e8628ff16b000216/master/w_2560%2Cc_limit/760000_got_mp_092013_ep404-4912%255B1%255D.jpg",
                Summary = "Jaime entrusts a task to Brienne. Daenerys frees Meereen. " +
                "Jon is given permission to lead a group of Night's Watchmen to Craster's Keep." +
                " Bran and company are taken hostage.",
                ReleaseDate = "27 Apr 2014",
                SeasonId = 4
            };
            GotS4FifthEpisode = new Episode()
            {
                EpisodeId = 35,
                SeasonNumber = 4,
                EpisodeNumeration = 5,
                PosterUrl = "https://imageio.forbes.com/blogs-images/erikkain/files/2014/06/game-of-thrones-s4e5-arya.png?format=png&height=600&width=1200&fit=bounds",
                Summary = "Tommen is crowned King of the Seven Kingdoms. Cersei builds her case against" +
                " Tyrion. Sansa and Lord Baelish arrive at the Eyrie. The Night's Watch attacks" +
                " Craster's Keep.",
                ReleaseDate = "04 May 2014",
                SeasonId = 4
            };
            GotS4SixthEpisode = new Episode()
            {
                EpisodeId = 36,
                SeasonNumber = 4,
                EpisodeNumeration = 6,
                PosterUrl = "https://m.media-amazon.com/images/M/MV5BMTUxMjIwMjYyMV5BMl5BanBnXkFtZTgwNTE2OTg3MTE@._V1_.jpg",
                Summary = "Tyrion's trial has come. Yara and her troops storm the Dreadfort to free Theon." +
                " Daenerys meets Hizdar zo Loraq. Stannis makes a deal with the Iron Bank of Braavos.",
                ReleaseDate = "11 May 2014",
                SeasonId = 4
            };
            GotS4SeventhEpisode = new Episode()
            {
                EpisodeId = 37,
                SeasonNumber = 4,
                EpisodeNumeration = 7,
                PosterUrl = "https://i.pinimg.com/736x/b7/ed/6c/b7ed6c179e1582f3f776891fbf088a88.jpg",
                Summary = "Tyrion tries to find a champion. Daenerys sleeps with Daario. " +
                "The Hound becomes wounded. Jon's advice is ignored at Castle Black. Brienne" +
                " and Podrick receive a tip on Arya's whereabouts.",
                ReleaseDate = "18 May 2014",
                SeasonId = 4
            };
            GotS4EighthEpisode = new Episode()
            {
                EpisodeId = 38,
                SeasonNumber = 4,
                EpisodeNumeration = 8,
                PosterUrl = "https://thatshelf.com/wp-content/uploads/2014/06/Game-of-Thrones-Season-4-Episode-8-Viper-and-Mountain.jpg",
                Summary = "Theon helps Ramsay seize Moat Cailin. The wildlings attack Mole's Town. " +
                "Sansa comes up with a story to protect Lord Baelish. Daenerys finds out a secret about" +
                " Jorah Mormont. Oberyn Martell faces Gregor Clegane, the Mountain.",
                ReleaseDate = "01 Jun 2014",
                SeasonId = 4
            };
            GotS4NinthEpisode = new Episode()
            {
                EpisodeId = 39,
                SeasonNumber = 4,
                EpisodeNumeration = 9,
                PosterUrl = "https://hips.hearstapps.com/digitalspyuk.cdnds.net/14/24/tv-game-of-thrones-jon-snow-s04e09.jpg",
                Summary = "The battle between the Night's Watch and the wildlings has come.",
                ReleaseDate = "08 Jun 2014",
                SeasonId = 4
            };
            GotS4TenthEpisode = new Episode()
            {
                EpisodeId = 40,
                SeasonNumber = 4,
                EpisodeNumeration = 10,
                PosterUrl = "https://images.cdn.prd.api.discomax.com/2023/02/09/13a327af-12e2-377e-9d3f-360756f8cd1a.jpeg?f=jpg&q=75&w=1280",
                Summary = "Jon makes an important decision. Daenerys experiences new consequences. " +
                "Brienne and Podrick have an unexpected encounter. Bran achieves a goal, " +
                "while Tyrion makes an important discovery.",
                ReleaseDate = "15 Jun 2014",
                SeasonId = 4
            };
            BPS1FirstEpisode = new Episode()
            {
                EpisodeId = 41,
                SeasonNumber = 1,
                EpisodeNumeration = 1,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "Unsettling events put a group of brilliant friends on edge as a mystery " +
                "unravels with origins tracing back to China during the Cultural Revolution.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1SecondEpisode = new Episode()
            {
                EpisodeId = 42,
                SeasonNumber = 1,
                EpisodeNumeration = 2,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "Auggie's countdown jeopardizes her nanotech work. Jin becomes engrossed" +
                " in an otherworldly VR game. Ye Wenjie follows through on a radical idea.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1ThirdEpisode = new Episode()
            {
                EpisodeId = 43,
                SeasonNumber = 1,
                EpisodeNumeration = 3,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "Obsessed with their virtual reality quest, Jin and Jack race to " +
                "solve a complex riddle but advancing to the next level brings harrowing consequences.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1FourthEpisode = new Episode()
            {
                EpisodeId = 44,
                SeasonNumber = 1,
                EpisodeNumeration = 4,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "Jin seeks justice after a death rattles the group. Investigators " +
                "learn of an extremist group devoted to an otherworldly entity ahead of a" +
                " major summit.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1FifthEpisode = new Episode()
            {
                EpisodeId = 45,
                SeasonNumber = 1,
                EpisodeNumeration = 5,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "As threat levels rise, a secret mission to retrieve enemy intel ventures " +
                "into dangerous territory. An ominous message reaches Earth.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1SixthEpisode = new Episode()
            {
                EpisodeId = 46,
                SeasonNumber = 1,
                EpisodeNumeration = 6,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "With the world in a state of panic following a momentous declaration," +
                " Wade gathers the world's greatest minds to prepare a defense plan.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1SeventhEpisode = new Episode()
            {
                EpisodeId = 47,
                SeasonNumber = 1,
                EpisodeNumeration = 7,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "A bold proposition for the Staircase Project puts the group at odds." +
                " Will weighs his options. Ye returns to a familiar place.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
            BPS1EighthEpisode = new Episode()
            {
                EpisodeId = 48,
                SeasonNumber = 1,
                EpisodeNumeration = 8,
                PosterUrl = "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg",
                Summary = "A high-level operation upends Saul's life. With emotions and expectations high," +
                " the probe launches into space as humanity enters a daunting new era.",
                ReleaseDate = "21 Mar 2024",
                SeasonId = 8
            };
        }
        private void SeedCrew()
        {
            BTFDirector = new Crew()
            {
                CrewId = 2,
                Name = "Robert Zemeckis",
                Pseudonyms = "Bob",
                Birthdate = "14 May 1952",
                Nationality = "USA",
                PictureUrl = "https://m.media-amazon.com/images/M/MV5BMTgyMTMzMDUyNl5BMl5BanBnXkFtZTcwODA0ODMyMw@@._V1_.jpg",
                Biography = " whiz-kid with special effects, Robert is from the Spielberg camp of film-making " +
                "(Steven Spielberg produced many of his films). Usually working with writing partner Bob Gale," +
                " Robert's earlier films show he has a talent for zany comedy (Romance of the Stone (1984)," +
                " 1941 (1979)) and special effect vehicles (Who Drove Roger Rabbit? (1988) and Back to the " +
                "Future ( 1985)). His later films have become more serious, with the hugely successful Tom " +
                "Hanks vehicle Forrest Gump (1994) and the Jodie Foster film Contact (1997), both critically" +
                " acclaimed movies. Again, these films incorporate stunning effects. Robert has proven he can" +
                " work a serious story around great effects.",
                MoreInfo = "https://en.wikipedia.org/wiki/Robert_Zemeckis"
            };
            BTFFirstActor = new Crew()
            {
                CrewId = 3,
                Name = "Michael J. Fox",
                Pseudonyms = "Mike",
                Birthdate = "09 Jun 1961",
                Nationality = "Canadian",
                PictureUrl = "https://cdn.britannica.com/33/130633-050-DA6DF1CF/Michael-J-Fox-activist.jpg",
                Biography = "Michael J. Fox was born Michael Andrew Fox on June 9, 1961 in Edmonton, Alberta," +
                " Canada, to Phyllis Fox (née Piper), a payroll clerk, and William Fox. His parents moved their" +
                " 10-year-old son, his three sisters, Kelli Fox, Karen, and Jacki, and his brother Steven, " +
                "to Vancouver, British Columbia, after his father, a sergeant in the Canadian Army Signal Corps," +
                " retired. During these years Michael developed his desire to act. At 15 he successfully " +
                "auditioned for the role of a 10-year-old in a series called Leo and Me (1978). Gaining attention" +
                " as a bright new star in Canadian television and movies, Michael realized his love for acting " +
                "when he appeared on stage in \"The Shadow Box.\" At 18 he moved to Los Angeles and was offered " +
                "a few television-series roles, but soon they stopped coming and he was surviving on boxes of " +
                "macaroni and cheese. Then his agent called to tell him that he got the part of Alex P. Keaton " +
                "on the situation comedy Family Ties (1982). He starred in the feature films The Wolf (1985), " +
                "High School U.S.A. (1983), Poison Ivy (1985) and Back to the Future (1985).",
                MoreInfo = "https://en.wikipedia.org/wiki/Michael_J._Fox"
            };
            BTFWriter = new Crew()
            {
                CrewId = 6,
                Name = "Bob Gale",
                Pseudonyms = string.Empty,
                Birthdate = "25 May 1951",
                Nationality = "USA",
                PictureUrl = "https://images.squarespace-cdn.com/content/v1/5c62c09c4d546e27dc1016c7/1610218958633-L970L7NUPENE6D2M1DUW/107_bob.jpg",
                Biography = "Bob Gale is an Oscar-nominated screenwriter-producer-director, " +
                "best known as co-creator, co-writer and co-producer of Back to the Future (1985) " +
                "and its sequels. Gale was born and raised in St. Louis, Missouri, and graduated Phi Beta Kappa" +
                " with a B.A. in Cinema from the University of Southern California in 1973. He has written " +
                "over 30 screenplays; his other film credits include 1941 (1979), I Want to Hold Your Hand (1978)," +
                " Old Cars (1980), Foreign Property (1992) and Highway 60 (2002), the latter which he directed." +
                " In addition to writing movies and occasionally television, Gale has written comic books including" +
                " Spider-Man, Batman and the IDW Back to the Future title, thus proving to his father that he did" +
                " not waste hours and hours reading comics in his youth. He has also served as an expert witness in" +
                " over 25 plagiarism cases, even though this has occasionally required him to wear a suit and tie " +
                "(oh, the horror!). When he's not in production, writing, shooting off his mouth or wasting time on" +
                " the internet, he actually does take out the trash even when his wife doesn't ask. Well, sometimes he does...",
                MoreInfo = "https://en.wikipedia.org/wiki/Bob_Gale"
            };
            GOTWriter = new Crew()
            {
                CrewId = 5,
                Name = "George R.R. Martin",
                Pseudonyms = string.Empty,
                Birthdate = "20 Sep 1948",
                Nationality = "USA",
                PictureUrl = "https://miro.medium.com/v2/resize:fit:7800/1*v0RCTUY4rmOHvBH2vCNBcQ.jpeg",
                Biography = "George R.R. Martin is an American novelist and short-story writer in the fantasy, horror, and science fiction genres," +
                " a screenwriter, and television producer. He is known for his international bestselling series of epic fantasy novels, " +
                "A Song of Ice and Fire, which was later adapted into the HBO dramatic series Игра на тронове (2011)." +
                "Martin serves as the series' co-executive producer, and also scripted four episodes of the series. In 2005, Lev Grossman of Time called Martin \"the American Tolkien\".",
                MoreInfo = "https://en.wikipedia.org/wiki/George_R._R._Martin"
            };
            GOTDirector = new Crew()
            {
                CrewId = 1,
                Name = "David Benioff",
                Pseudonyms = string.Empty,
                Birthdate = "25 Sep 1970",
                Nationality = "USA",
                PictureUrl = "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/289653_v9_bc.jpg",
                Biography = "David Benioff was born on September 25, 1970 in New York City, " +
                "New York, USA. He is a producer and writer, known for Game of Thrones (2011) , " +
                "The Kite Runner (2007) and The 25th Hour (2002) . He has been married to Amanda Peet" +
                " since September 30, 2006. They have three children.",
                MoreInfo = "https://en.wikipedia.org/wiki/David_Benioff"
            };
            GOTFirstActor = new Crew()
            {
                CrewId = 4,
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
            GOTSecondActor = new Crew()
            {
                CrewId = 7,
                Name = "Emilia Clarke",
                Pseudonyms = "Milly",
                Birthdate = "23 Oct 1986",
                Nationality = "British",
                PictureUrl = "https://th.bing.com/th/id/OIP.jQ8W5xuSZtGGDRKkKa1IGgHaKs?rs=1&pid=ImgDetMain",
                Biography = "British actress Emilia Clarke was born in London and grew up in Oxfordshire," +
                " England. Her father was a theatre sound engineer and her mother is a businesswoman." +
                " Her father was working on a theatre production of \"Show Boat\" and her mother took " +
                "her along to the performance. This is when, at the age of 3, her passion for acting " +
                "began. From 2000 to 2005, she attended St. Edward's School of Oxford, where she appeared" +
                " in two school plays. She went on to study acting at the prestigious Drama Centre " +
                "London, where she took part in 10 plays. During this time, Emilia first appeared on " +
                "television with a guest role in the BBC soap opera Doctors (2000).\r\n\r\nIn 2010, after" +
                " graduating from the Drama Centre London, Emilia got her first film role in the " +
                "television movie Triassic Attack (2010). In 2011, her breakthrough role came in when " +
                "she replaced fellow newcomer Tamzin Merchant on Game of Thrones (2011) after the filming" +
                " of the original pilot episode. From March to April 2013, she played Holly Golightly in" +
                " a Broadway production of \"Breakfast at Tiffany's\". She played Sarah Connor in " +
                "Terminator Genisys (2015), opposite Arnold Schwarzenegger, Jai Courtney and Jason Clarke. " +
                "She played the lead role of Louisa Clark in the romantic comedy blockbuster Me Before You (2016)" +
                " and went on to star in Solo: A Star Wars Story (2018) as Qi'ra.\r\n\r\nSince her rise to prominence," +
                " Emilia has contributed to various charitable organisations. In 2018, she was named as the " +
                "ambassador to the Royal College of Nursing because of her efforts in raising awareness about the" +
                " working condition of the nurses in the UK. In 2019, she was named as the first ambassador for the " +
                "global Nursing Now campaign. In 2019, in a personal essay published in The New Yorker, Emilia revealed " +
                "that she had suffered from two life threatening brain aneurysms in 2011 and 2013. She launched her own" +
                " charity SameYou in 2019, which aims to broaden neurorehabilitation access for young people after a" +
                " brain injury or stroke.",
                MoreInfo = "https://en.wikipedia.org/wiki/Emilia_Clarke"
            };
            GOTThirdActor = new Crew()
            {
                CrewId = 8,
                Name = "Peter Dinklage",
                Pseudonyms = string.Empty,
                Birthdate = "11 Jun 1969",
                Nationality = "American",
                PictureUrl = "https://th.bing.com/th/id/R.acf3c43e277f14048800c509b4949b5a?rik=stTnKvBHKvrKEg&pid=ImgRaw&r=0",
                Biography = "Peter Dinklage is an American actor. Since his breakout role in The Station Agent (2003)," +
                " he has appeared in numerous films and theatre plays. Since 2011, Dinklage has " +
                "portrayed Tyrion Lannister in the HBO series Game of Thrones (2011) . " +
                "For this he won an Emmy for Outstanding Supporting Actor in a Drama Series and " +
                "a Golden Globe Award for Best Supporting Actor - Series, Miniseries or Television Film" +
                " in 2011.\r\n\r\nPeter Hayden Dinklage was born in Morristown, New Jersey, to " +
                "Diane (Hayden), an elementary school teacher, and John Carl Dinklage, an insurance " +
                "salesman. He is of German, Irish, and English descent. In 1991, he received a degree " +
                "in drama from Bennington College and began his career. ",
                MoreInfo = "https://en.wikipedia.org/wiki/Peter_Dinklage"
            };
            GOTFourthActor = new Crew()
            {
                CrewId = 9,
                Name = "John Bradley",
                Pseudonyms = string.Empty,
                Birthdate = "15 Sep 1988",
                Nationality = "English",
                PictureUrl = "https://th.bing.com/th/id/R.e552352f327cdff6d0633b8342b58a55?rik=0K3o%2f3tBxmB%2bfg&pid=ImgRaw&r=0",
                Biography = "John was born as John Bradley West in 1988. Brought up in Wythenshawe, " +
                "South Manchester, he attended St Paul's High School and Loreto College, Hulme before" +
                " going on to Manchester Metropolitan University from where he graduated in 2010 with " +
                "a B.A. degree in acting. It was via his college website that he obtained his first " +
                "big television role in the epic fantasy series 'Game of Thrones (2011)' though he has " +
                "since moved nearer home to appear in 'Shameless (2004)'. He is also an accomplished " +
                "drummer and has experience in stand up comedy.",
                MoreInfo = "https://en.wikipedia.org/wiki/John_Bradley_(English_actor)"
            };
            GOTFifthActor = new Crew()
            {
                CrewId = 10,
                Name = "Liam Cunningham",
                Pseudonyms = string.Empty,
                Birthdate = "02 Jun 1961",
                Nationality = "Irish",
                PictureUrl = "https://ipravda.sk/res/2019/04/15/thumbs/herec-liam-cunningham-nestandard1.jpg",
                Biography = "Irish actor Liam Cunningham was an electrician in the mid-'80s. " +
                "He saw an ad for an acting school and he decided to give it a try. His first " +
                "film role was as a policeman in \"Into the West.\" Since then, he has been involved" +
                " in many films and theater productions on both sides of the Atlantic.",
                MoreInfo = "https://en.wikipedia.org/wiki/Liam_Cunningham"
            };
        }
        private void SeedMovieCrew()
        {
            MCFirstConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = BTFDirector.CrewId
            };

            MCSecondConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = BTFFirstActor.CrewId
            };

            MCThirdConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = BTFWriter.CrewId
            };
        }
        private void SeedSerieCrew()
        {
            SCFirstConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTDirector.CrewId
            };
            SCThirdConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTWriter.CrewId
            };
            SCSecondConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTFirstActor.CrewId
            };
            SCFourthConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTSecondActor.CrewId
            };
            SCFifthConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTThirdActor.CrewId
            };
            SCSixthConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTFourthActor.CrewId
            };
            SCSeventhConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = GOTFifthActor.CrewId
            };
            SCEighthConnection = new SerieCrew()
            {
                SerieId = 3,
                CrewId = GOTFourthActor.CrewId
            };
            SCNinthConnection = new SerieCrew()
            {
                SerieId = 3,
                CrewId = GOTFifthActor.CrewId
            };
        }
        private void SeedMovieGenres()
        {
            MGFirstConnection = new MovieGenre()
            {
                MovieId = 1,
                GenreId = AdventureGenre.GenreId,
            };

            MGSecondConnection = new MovieGenre()
            {
                MovieId = 1,
                GenreId = ComedyGenre.GenreId,
            };

            MGThirdConnection = new MovieGenre()
            {
                MovieId = 1,
                GenreId = SciFiGenre.GenreId,
            };
        }
        private void SeedSerieGenres()
        {
            SGFirstConnection = new SerieGenre()
            {
                SerieId = 1,
                GenreId = ActionGenre.GenreId
            };

            SGSecondConnection = new SerieGenre()
            {
                SerieId = 1,
                GenreId = AdventureGenre.GenreId
            };

            SGThirdConnection = new SerieGenre()
            {
                SerieId = 1,
                GenreId = DramaGenre.GenreId
            };
        }
        private void SeedCrewRole()
        {
            CRFirstConnection = new CrewRole()
            {
                CrewId = 1,
                RoleId = WriterRole.RoleId
            };
            CRSecondConnection = new CrewRole()
            {
                CrewId = 1,
                RoleId = ProducerRole.RoleId
            };
            CRThirdConnection = new CrewRole()
            {
                CrewId = 1,
                RoleId = DirectorRole.RoleId
            };
            CRFourthConnection = new CrewRole()
            {
                CrewId = 2,
                RoleId = ProducerRole.RoleId
            };
            CRFifthConnection = new CrewRole()
            {
                CrewId = 2,
                RoleId = WriterRole.RoleId
            };
            CRSixthConnection = new CrewRole()
            {
                CrewId = 3,
                RoleId = ActorRole.RoleId

            };
            CRSeventhConnection = new CrewRole()
            {
                CrewId = 3,
                RoleId = ProducerRole.RoleId
            };
            CREighthConnection = new CrewRole()
            {
                CrewId = 4,
                RoleId = ProducerRole.RoleId
            };
            CRNinthConnection = new CrewRole()
            {
                CrewId = 4,
                RoleId = ActorRole.RoleId
            };
            CRTenthConnection = new CrewRole()
            {
                CrewId = 4,
                RoleId = WriterRole.RoleId
            };
            CREleventhConnection = new CrewRole()
            {
                CrewId = 5,
                RoleId = WriterRole.RoleId
            };
            CRTwelfthConnection = new CrewRole()
            {
                CrewId = 5,
                RoleId = ProducerRole.RoleId
            };
            CRThirteenthConnection = new CrewRole()
            {
                CrewId = 6,
                RoleId = DirectorRole.RoleId
            };
            CRFourteenthConnection = new CrewRole()
            {
                CrewId = 6,
                RoleId = ProducerRole.RoleId
            };
            CRFifteenthConnection = new CrewRole()
            {
                CrewId = 6,
                RoleId = WriterRole.RoleId
            };
            CRSixteenthConnection = new CrewRole()
            {
                CrewId = 7,
                RoleId = ActorRole.RoleId
            };
            CRSeventeenthConnection = new CrewRole()
            {
                CrewId = 7,
                RoleId = ProducerRole.RoleId
            };
            CREighteenthConnection = new CrewRole()
            {
                CrewId = 8,
                RoleId = ActorRole.RoleId
            };
            CRNineteenthConnection = new CrewRole()
            {
                CrewId = 8,
                RoleId = ProducerRole.RoleId
            };
            CRTwentiethConnection = new CrewRole()
            {
                CrewId = 9,
                RoleId = ActorRole.RoleId
            };
            CRTwentyFirstConnection = new CrewRole()
            {
                CrewId = 10,
                RoleId = ActorRole.RoleId
            };
            CRTwentySecondConnection = new CrewRole()
            {
                CrewId = 10,
                RoleId = DirectorRole.RoleId
            };
            CRTwentyThirdConnection = new CrewRole()
            {
                CrewId = 10,
                RoleId = ProducerRole.RoleId
            };
        }
        private void SeedReview()
        {
            ReviewForMovie = new Review()
            {
                ReviewId = 67,
                Rating = 5,
                Content = "Movie was great!"
            };

            ReviewForSerie = new Review()
            {
                ReviewId = 68,
                Rating = 5,
                Content = "Serie was great!"
            };
        }
        private void SeedMovieReview()
        {
            MRFirstConnection = new MovieReview()
            {
                MovieId = 1,
                ReviewId = 67
            };
        }
        private void SeedSerieReview()
        {
            SRFirstConnection = new SerieReview()
            {
                SerieId = 1,
                ReviewId = 68
            };
        }
        private void SeedUserReview()
        {
            URFirstConnection = new UserReview()
            {
                UserId = "8e656345-a56d-4543-a7c6-4556d32d4db2",
                ReviewId = 67
            };

            URSecondConnection = new UserReview()
            {
                UserId = "8e656345-a56d-4543-a7c6-4556d32d4db2",
                ReviewId = 68
            };
        }
    }
}
