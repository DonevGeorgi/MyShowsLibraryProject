using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class ChangingModelsAndSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Crews_CrewId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_CrewId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CrewId",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfRelease",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Movie release date",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldComment: "Movie release date");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Episode release date",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldComment: "Episode release date");

            migrationBuilder.AlterColumn<string>(
                name: "Birthdate",
                table: "Crews",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Crew birthdate",
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldComment: "Crew birthdate");

            migrationBuilder.CreateTable(
                name: "CrewRole",
                columns: table => new
                {
                    CrewId = table.Column<int>(type: "int", nullable: false, comment: "Crew identifier"),
                    RoleId = table.Column<int>(type: "int", nullable: false, comment: "Role identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewRole", x => new { x.CrewId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_CrewRole_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "CrewId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrewRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "CrewId", "Biography", "Birthdate", "MoreInfo", "Name", "Nationality", "PictureUrl", "Pseudonyms" },
                values: new object[,]
                {
                    { 1, "David Benioff was born on September 25, 1970 in New York City, New York, USA. He is a producer and writer, known for Game of Thrones (2011) , The Kite Runner (2007) and The 25th Hour (2002) . He has been married to Amanda Peet since September 30, 2006. They have three children.", "25 Sep 1970", "https://en.wikipedia.org/wiki/David_Benioff", "David Benioff", "USA", "https://resizing.flixster.com/-XZAfHZM39UwaGJIFWKAE8fS0ak=/v3/t/assets/289653_v9_bc.jpg", "" },
                    { 2, " whiz-kid with special effects, Robert is from the Spielberg camp of film-making (Steven Spielberg produced many of his films). Usually working with writing partner Bob Gale, Robert's earlier films show he has a talent for zany comedy (Romance of the Stone (1984), 1941 (1979)) and special effect vehicles (Who Drove Roger Rabbit? (1988) and Back to the Future ( 1985)). His later films have become more serious, with the hugely successful Tom Hanks vehicle Forrest Gump (1994) and the Jodie Foster film Contact (1997), both critically acclaimed movies. Again, these films incorporate stunning effects. Robert has proven he can work a serious story around great effects.", "14 May 1952", "https://en.wikipedia.org/wiki/Robert_Zemeckis", "Robert Zemeckis", "USA", "https://m.media-amazon.com/images/M/MV5BMTgyMTMzMDUyNl5BMl5BanBnXkFtZTcwODA0ODMyMw@@._V1_.jpg", "Bob" },
                    { 3, "Michael J. Fox was born Michael Andrew Fox on June 9, 1961 in Edmonton, Alberta, Canada, to Phyllis Fox (née Piper), a payroll clerk, and William Fox. His parents moved their 10-year-old son, his three sisters, Kelli Fox, Karen, and Jacki, and his brother Steven, to Vancouver, British Columbia, after his father, a sergeant in the Canadian Army Signal Corps, retired. During these years Michael developed his desire to act. At 15 he successfully auditioned for the role of a 10-year-old in a series called Leo and Me (1978). Gaining attention as a bright new star in Canadian television and movies, Michael realized his love for acting when he appeared on stage in \"The Shadow Box.\" At 18 he moved to Los Angeles and was offered a few television-series roles, but soon they stopped coming and he was surviving on boxes of macaroni and cheese. Then his agent called to tell him that he got the part of Alex P. Keaton on the situation comedy Family Ties (1982). He starred in the feature films The Wolf (1985), High School U.S.A. (1983), Poison Ivy (1985) and Back to the Future (1985).", "09 Jun 1961", "https://en.wikipedia.org/wiki/Michael_J._Fox", "Michael J. Fox", "Canadian", "https://cdn.britannica.com/33/130633-050-DA6DF1CF/Michael-J-Fox-activist.jpg", "Mike" },
                    { 4, "Kit Harington was born Christopher Catesby Harington in Acton, London, to Deborah Jane (Catesby), a former playwright, and David Richard Harington, a businessman. His mother named him after 16th-century British playwright and poet Christopher Marlowe, whose first name was shortened to Kit, a name Harington prefers. Harington's uncle is Sir Nicholas John Harington, the 14th Baronet Harington, and his paternal great-grandfather was Sir Richard Harington, the 12th Baronet Harington. Through his paternal grandmother, Lavender Cecilia Denny, Kit's eight times great-grandfather was King Charles II of England. Also through his father, Harington descends from politician Henry Dundas, 1st Viscount Melville, the bacon merchant T. A. Denny, clergyman Baptist Wriothesley Noel, merchant and politician Peter Baillie, peer William Legge, 4th Earl of Dartmouth, and MP Sir William Molesworth, 6th Baronet.", "26 Dec 1986", "https://en.wikipedia.org/wiki/Kit_Harington", "Kit Harington", "English", "https://hips.hearstapps.com/harpersbazaaruk.cdnds.net/15/37/original/original-kit-sq-jpg-68954c3a.jpg?resize=980:*", "" },
                    { 5, "George R.R. Martin is an American novelist and short-story writer in the fantasy, horror, and science fiction genres, a screenwriter, and television producer. He is known for his international bestselling series of epic fantasy novels, A Song of Ice and Fire, which was later adapted into the HBO dramatic series Игра на тронове (2011).Martin serves as the series' co-executive producer, and also scripted four episodes of the series. In 2005, Lev Grossman of Time called Martin \"the American Tolkien\".", "20 Sep 1948", "https://en.wikipedia.org/wiki/George_R._R._Martin", "George R.R. Martin", "USA", "https://miro.medium.com/v2/resize:fit:7800/1*v0RCTUY4rmOHvBH2vCNBcQ.jpeg", "" },
                    { 6, "Bob Gale is an Oscar-nominated screenwriter-producer-director, best known as co-creator, co-writer and co-producer of Back to the Future (1985) and its sequels. Gale was born and raised in St. Louis, Missouri, and graduated Phi Beta Kappa with a B.A. in Cinema from the University of Southern California in 1973. He has written over 30 screenplays; his other film credits include 1941 (1979), I Want to Hold Your Hand (1978), Old Cars (1980), Foreign Property (1992) and Highway 60 (2002), the latter which he directed. In addition to writing movies and occasionally television, Gale has written comic books including Spider-Man, Batman and the IDW Back to the Future title, thus proving to his father that he did not waste hours and hours reading comics in his youth. He has also served as an expert witness in over 25 plagiarism cases, even though this has occasionally required him to wear a suit and tie (oh, the horror!). When he's not in production, writing, shooting off his mouth or wasting time on the internet, he actually does take out the trash even when his wife doesn't ask. Well, sometimes he does...", "25 May 1951", "https://en.wikipedia.org/wiki/Bob_Gale", "Bob Gale", "USA", "https://images.squarespace-cdn.com/content/v1/5c62c09c4d546e27dc1016c7/1610218958633-L970L7NUPENE6D2M1DUW/107_bob.jpg", "" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drame" },
                    { 4, "Fantasy" },
                    { 5, "Horror" },
                    { 6, "Mystery" },
                    { 7, "Romance" },
                    { 8, "Thriller" },
                    { 9, "Western" },
                    { 10, "Adventure" },
                    { 11, "Sci-Fi" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateOfRelease", "Duration", "ForMoreSummaryUrl", "OriginalAudioLanguage", "PosterUrl", "Summary", "Title", "TrailerUrl" },
                values: new object[] { 1, "03 Jul 1985", 116, "https://en.wikipedia.org/wiki/Back_to_the_Future", "English", "https://upload.wikimedia.org/wikipedia/en/thumb/d/d2/Back_to_the_Future.jpg/220px-Back_to_the_Future.jpg", "Marty McFly, a 17-year-old high school student, is accidentally sent 30 years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.", "Back to the Future", "https://www.youtube.com/watch?v=qvsgGtivCgs&ab_channel=RottenTomatoesClassicTrailers" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 1, "Director" },
                    { 2, "Writer" },
                    { 3, "Actor" },
                    { 4, "Producer" },
                    { 5, "Music Composer" },
                    { 6, "Cinematographer" },
                    { 7, "Editor" },
                    { 8, "ArtDirector" },
                    { 9, "CostumeDesigner" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "SeriesId", "ForMoreSummaryUrl", "OriginalAudioLanguage", "PosterUrl", "Summary", "Title", "TrailerUrl", "YearOfEnd", "YearOfStart" },
                values: new object[] { 1, "https://en.wikipedia.org/wiki/Game_of_Thrones", "English", "https://i.pinimg.com/originals/ac/4f/fd/ac4ffd8309980a091dd1dc57abe908b4.jpg", "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for a millennia.", "Game of Thrones", "https://www.youtube.com/watch?v=bjqEWgDVPe0&ab_channel=HBOUK", "2019", "2011" });

            migrationBuilder.InsertData(
                table: "CrewRole",
                columns: new[] { "CrewId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 2 },
                    { 5, 4 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "MoviesCrews",
                columns: new[] { "CrewId", "MovieId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "MoviesGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 10, 1 },
                    { 11, 1 }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "EpisodesInSeason", "PosterUrl", "SeriesId", "YearOfRelease" },
                values: new object[] { 1, "10", "https://static.posters.cz/image/1300/posters/game-of-thrones-season-1-key-art-i161816.jpg", 1, "2011" });

            migrationBuilder.InsertData(
                table: "SeriesCrews",
                columns: new[] { "CrewId", "SerieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "SeriesGenres",
                columns: new[] { "GenreId", "SerieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "EpisodeNumeration", "PosterUrl", "ReleaseDate", "SeasonId", "SeasonNumber", "Summary" },
                values: new object[,]
                {
                    { 1, 1, "https://static.hbo.com/content/dam/hbodata/series/game-of-thrones/video-stills/season-01/game-of-thrones-season-1-episode-1-full-stitched-607175_PRO35_10-1920.jpg", "18 Apr 2011", 1, 1, "Eddard Stark is torn between his family and an old friend when asked to serve at the side of King Robert Baratheon,And in the other side of the world Viserys Targaryen plans to wed his sister to a nomadic warlord in exchange for an army." },
                    { 2, 2, "https://cdn.vox-cdn.com/thumbor/hPCyBds5DKp5JcmzCgiBrQrQdi4=/0x0:1280x720/1600x900/cdn.vox-cdn.com/uploads/chorus_image/image/46094226/Jon_snow.0.jpg", "25 Apr 2011", 1, 1, "While Bran recovers from his fall, Ned takes only his daughters to King's Landing. Jon Snow goes with his uncle Benjen to the Wall. Tyrion joins them." },
                    { 3, 3, "https://images.cdn.prd.api.discomax.com/2023/02/15/a2ca6975-7063-3bc0-a74a-634b49b97d74.jpeg?f=jpg&q=75&w=1280", "1 May 2011", 1, 1, "Jon begins his training with the Night's Watch; Ned confronts his past and future at King's Landing; Daenerys finds herself at odds with Viserys." },
                    { 4, 4, "https://m.media-amazon.com/images/M/MV5BMTMwNDQ0MTIyMl5BMl5BanBnXkFtZTcwODkxMzkxNA@@._V1_.jpg", "08 May 2011", 1, 1, "Eddard investigates Jon Arryn's murder. Jon befriends Samwell Tarly, a coward who has come to join the Night's Watch." },
                    { 5, 5, "https://static.wikia.nocookie.net/gameofthrones/images/4/48/Thrones_S01E05.jpg/revision/latest?cb=20220918160258", "15 May 2011", 1, 1, "Catelyn has captured Tyrion and plans to bring him to her sister, Lysa Arryn, at the Vale, to be tried for his, supposed, crimes against Bran. Robert plans to have Daenerys killed, but Eddard refuses to be a part of it and quits." },
                    { 6, 6, "https://cdn.vox-cdn.com/thumbor/MKfDGE4yoWdp_x39u5yQyjaCjbw=/0x0:1920x1080/1400x1050/filters:focal(848x506:1154x812):no_upscale()/cdn.vox-cdn.com/uploads/chorus_image/image/56051735/a_golden_crown_1920.0.jpg", "22 May 2011", 1, 1, "While recovering from his battle with Jaime, Eddard is forced to run the kingdom while Robert goes hunting. Tyrion demands a trial by combat for his freedom. Viserys is losing his patience with Drogo." },
                    { 7, 7, "https://static.wikia.nocookie.net/gameofthrones/images/7/79/Daenerys_and_Jorah_2x08.jpg/revision/latest/scale-to-width-down/560?cb=20120524205729", "29 May 2011", 1, 1, "Robert has been injured while hunting and is dying. Jon and the others finally take their vows to the Night's Watch. A man, sent by Robert, is captured for trying to poison Daenerys. Furious, Drogo vows to attack the Seven Kingdoms." },
                    { 8, 8, "https://static.wikia.nocookie.net/gameofthrones/images/0/0c/Thrones_S01E08.jpg/revision/latest?cb=20220918160919", "05 Jun 2011", 1, 1, "The Lannisters press their advantage over the Starks; Robb rallies his father's northern allies and heads south to war; The White Walkers attack the Wall; Tyrion returns to his father with some new friends." },
                    { 9, 9, "https://jackandthegeekstalk.files.wordpress.com/2017/08/maxresdefault-7.jpg?w=1080", "12 Jun 2011", 1, 1, "Robb goes to war against the Lannisters. Jon finds himself struggling on deciding if his place is with Robb or the Night's Watch. Drogo has fallen ill from a fresh battle wound. Daenerys is desperate to save him." },
                    { 10, 10, "https://s1.dmcdn.net/v/GQYpO1ZeIODLfiWno/x1080", "19 Jun 2011", 1, 1, "Robb vows to get revenge on the Lannisters. Jon must officially decide if his place is with Robb or the Night's Watch. Daenerys says her final goodbye to Drogo." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrewRole_RoleId",
                table: "CrewRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewRole");

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MoviesCrews",
                keyColumns: new[] { "CrewId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesCrews",
                keyColumns: new[] { "CrewId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesCrews",
                keyColumns: new[] { "CrewId", "MovieId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "MoviesGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesCrews",
                keyColumns: new[] { "CrewId", "SerieId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesGenres",
                keyColumns: new[] { "GenreId", "SerieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesGenres",
                keyColumns: new[] { "GenreId", "SerieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SeriesGenres",
                keyColumns: new[] { "GenreId", "SerieId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "CrewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "CrewId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Crew identifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRelease",
                table: "Movies",
                type: "Date",
                nullable: false,
                comment: "Movie release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Movie release date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Episodes",
                type: "Date",
                nullable: false,
                comment: "Episode release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Episode release date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Crews",
                type: "Date",
                nullable: false,
                comment: "Crew birthdate",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Crew birthdate");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CrewId",
                table: "Roles",
                column: "CrewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Crews_CrewId",
                table: "Roles",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "CrewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
