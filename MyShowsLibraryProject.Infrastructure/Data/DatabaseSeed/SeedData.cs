using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Infrastructure.Data.DatabaseSeed
{
    internal class SeedData
    {
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
        public Role DirectorRole { get; set; }
        public Role WriterRole { get; set; }
        public Role ActorRole { get; set; }
        public Role ProducerRole { get; set; }
        public Role MusicComposerRole { get; set; }
        public Role CinematographerRole { get; set; }
        public Role EditorRole { get; set; }
        public Role ArtDirectorRole { get; set; }
        public Role CostumeDesignerRole { get; set; }
        public Movie FirstMovie { get; set; }
        public Serie FirstSerie { get; set; }
        public Season FirstSeason { get; set; }
        public Episode FirstEpisode { get; set; }
        public Episode SecondEpisode { get; set; }
        public Episode ThirdEpisode { get; set; }
        public Episode FourthEpisode { get; set; }
        public Episode FifthEpisode { get; set; }
        public Episode SixthEpisode { get; set; }
        public Episode SeventhEpisode { get; set; }
        public Episode EighthEpisode { get; set; }
        public Episode NinthEpisode { get; set; }
        public Episode TenthEpisode { get; set; }
        public Crew FirstDirector { get; set; }
        public Crew SecondDirector { get; set; }
        public Crew FirstActor { get; set; }
        public Crew SecondActor { get; set; }
        public Crew FirstWriter { get; set; }
        public Crew SecondWriter { get; set; }
        public MovieCrew MCFirstConnection { get; set; }
        public MovieCrew MCSecondConnection { get; set; }
        public MovieCrew MCThirdConnection { get; set; }
        public SerieCrew SCFirstConnection { get; set; }
        public SerieCrew SCSecondConnection { get; set; }
        public SerieCrew SCThirdConnection { get; set; }
        public MovieGenre MGFirstConnection { get; set; }
        public MovieGenre MGSecondConnection { get; set; }
        public MovieGenre MGThirdConnection { get; set; }
        public SerieGenre SGFirstConnection { get; set; }
        public SerieGenre SGSecondConnection { get; set; }
        public SerieGenre SGThirdConnection { get; set; }
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
        }
        private void SeedSeason()
        {
            FirstSeason = new Season()
            {
                SeasonId = 1,
                PosterUrl = "https://static.posters.cz/image/1300/posters/game-of-thrones-season-1-key-art-i161816.jpg",
                SeasonNumberation = 1,
                YearOfRelease = "2011",
                EpisodesInSeason = "10",
                SeriesId = 1,
                Episodes = new List<Episode>()
            };
        }
        private void SeedEpisode()
        {
            FirstEpisode = new Episode()
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

            SecondEpisode = new Episode()
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

            ThirdEpisode = new Episode()
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

            FourthEpisode = new Episode()
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

            FifthEpisode = new Episode()
            {
                EpisodeId = 5,
                SeasonNumber = 1,
                EpisodeNumeration = 5,
                PosterUrl = "https://static.wikia.nocookie.net/gameofthrones/images/4/48/Thrones_S01E05.jpg/revision/latest?cb=20220918160258",
                Summary = "Catelyn has captured Tyrion and plans to bring him to her sister, Lysa Arryn," +
                " at the Vale, to be tried for his, supposed, crimes against Bran. Robert plans to have Daenerys killed," +
                " but Eddard refuses to be a part of it and quits.",
                ReleaseDate = "15 May 2011",
                SeasonId = 1
            };

            SixthEpisode = new Episode()
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

            SeventhEpisode = new Episode()
            {
                EpisodeId = 7,
                SeasonNumber = 1,
                EpisodeNumeration = 7,
                PosterUrl = "https://static.wikia.nocookie.net/gameofthrones/images/7/79/Daenerys_and_Jorah_2x08.jpg/revision/latest/scale-to-width-down/560?cb=20120524205729",
                Summary = "Robert has been injured while hunting and is dying. Jon and the others " +
                "finally take their vows to the Night's Watch. A man, sent by Robert," +
                " is captured for trying to poison Daenerys. Furious, Drogo vows to attack the Seven Kingdoms.",
                ReleaseDate = "29 May 2011",
                SeasonId = 1
            };

            EighthEpisode = new Episode()
            {
                EpisodeId = 8,
                SeasonNumber = 1,
                EpisodeNumeration = 8,
                PosterUrl = "https://static.wikia.nocookie.net/gameofthrones/images/0/0c/Thrones_S01E08.jpg/revision/latest?cb=20220918160919",
                Summary = "The Lannisters press their advantage over the Starks; Robb rallies his father's" +
                " northern allies and heads south to war; The White Walkers attack the Wall; Tyrion returns " +
                "to his father with some new friends.",
                ReleaseDate = "05 Jun 2011",
                SeasonId = 1
            };

            NinthEpisode = new Episode()
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

            TenthEpisode = new Episode()
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
        }
        private void SeedCrew()
        {
            FirstDirector = new Crew()
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

            SecondDirector = new Crew()
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

            FirstActor = new Crew()
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

            SecondActor = new Crew()
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

            FirstWriter = new Crew()
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

            SecondWriter = new Crew()
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
        }
        private void SeedMovieCrew()
        {
            MCFirstConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = SecondDirector.CrewId
            };

            MCSecondConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = FirstActor.CrewId
            };

            MCThirdConnection = new MovieCrew()
            {
                MovieId = 1,
                CrewId = SecondWriter.CrewId
            };
        }
        private void SeedSerieCrew()
        {
            SCFirstConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = FirstDirector.CrewId
            };

            SCSecondConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = SecondActor.CrewId
            };

            SCThirdConnection = new SerieCrew()
            {
                SerieId = 1,
                CrewId = FirstWriter.CrewId
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
        }
    }
}
