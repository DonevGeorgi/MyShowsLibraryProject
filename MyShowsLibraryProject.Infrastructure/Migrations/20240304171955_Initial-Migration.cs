using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    CrewId = table.Column<int>(type: "int", nullable: false, comment: "Crew identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Crew name"),
                    Pseudonyms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Crew pseudonym"),
                    Birthdate = table.Column<DateTime>(type: "Date", nullable: false, comment: "Crew birthdate"),
                    Nationality = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Crew nationality"),
                    PictureUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Crew picture link"),
                    Biography = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false, comment: "Crew biography"),
                    MoreInfo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Crew link for more biography")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.CrewId);
                },
                comment: "Shows crew");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Genre identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Genre name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                },
                comment: "Shows genres");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Movie title"),
                    Duration = table.Column<int>(type: "int", nullable: false, comment: "Movie runtime"),
                    PosterUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Movie poster URL"),
                    TrailerUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Movie trailer URL"),
                    DateOfRelease = table.Column<DateTime>(type: "Date", nullable: false, comment: "Movie release date"),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Movie summary"),
                    OriginalAudioLanguage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Movie original lenguage"),
                    ForMoreSummaryUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "URL for more info")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                },
                comment: "Movie model");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false, comment: "Review identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "Rating given to the movie"),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 8000, nullable: false, comment: "Review content")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                },
                comment: "Review model");

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Serie title"),
                    PosterUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Serie poster URL"),
                    TrailerUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Serie trailer URL"),
                    YearOfStart = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false, comment: "Serie start year"),
                    YearOfEnd = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false, comment: "Series end year"),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Serie summary"),
                    OriginalAudioLanguage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Serie original language"),
                    ForMoreSummaryUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "URL for more info")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                },
                comment: "Serie model");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false, comment: "Role identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Role name"),
                    CrewId = table.Column<int>(type: "int", nullable: false, comment: "Crew identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "CrewId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Crew role in the show");

            migrationBuilder.CreateTable(
                name: "MoviesCrews",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false, comment: "Movie identifier"),
                    CrewId = table.Column<int>(type: "int", nullable: false, comment: "Crew identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesCrews", x => new { x.MovieId, x.CrewId });
                    table.ForeignKey(
                        name: "FK_MoviesCrews_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "CrewId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesCrews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Movie crew");

            migrationBuilder.CreateTable(
                name: "MoviesGenres",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false, comment: "Movie identifier"),
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Genre identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MoviesGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Movie genres");

            migrationBuilder.CreateTable(
                name: "MoviesReviews",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false, comment: "Movie identifier"),
                    ReviewId = table.Column<int>(type: "int", nullable: false, comment: "Review identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesReviews", x => new { x.MovieId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_MoviesReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Movie reviews");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    SeriesId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "int", nullable: false, comment: "Season identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosterUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Url for the season poster"),
                    YearOfRelease = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false, comment: "The year saeson is released"),
                    EpisodesInSeason = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, comment: "Number of episodes in the season"),
                    SeriesId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Show season");

            migrationBuilder.CreateTable(
                name: "SeriesCrews",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier"),
                    CrewId = table.Column<int>(type: "int", nullable: false, comment: "Crew identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesCrews", x => new { x.SerieId, x.CrewId });
                    table.ForeignKey(
                        name: "FK_SeriesCrews_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "CrewId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeriesCrews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Serie crew");

            migrationBuilder.CreateTable(
                name: "SeriesGenres",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier"),
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Genre identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesGenres", x => new { x.SerieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_SeriesGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeriesGenres_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Serie genres");

            migrationBuilder.CreateTable(
                name: "SeriesReviews",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier"),
                    ReviewId = table.Column<int>(type: "int", nullable: false, comment: "Review identitfier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesReviews", x => new { x.SerieId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_SeriesReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeriesReviews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Serie reviews");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersMovies",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    MovieId = table.Column<int>(type: "int", nullable: false, comment: "Movie identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMovies", x => new { x.UserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_UsersMovies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "User movies");

            migrationBuilder.CreateTable(
                name: "UsersReviews",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    ReviewId = table.Column<int>(type: "int", nullable: false, comment: "Review identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersReviews", x => new { x.UserId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_UsersReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "User reviews");

            migrationBuilder.CreateTable(
                name: "UsersSeries",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    SerieId = table.Column<int>(type: "int", nullable: false, comment: "Serie identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSeries", x => new { x.UserId, x.SerieId });
                    table.ForeignKey(
                        name: "FK_UsersSeries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersSeries_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "User series");

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonNumber = table.Column<int>(type: "int", nullable: false, comment: "Number of season"),
                    EpisodeNumeration = table.Column<int>(type: "int", nullable: false, comment: "Number of the episode in the season"),
                    PosterUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Url for the episode poster"),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Episode summary"),
                    ReleaseDate = table.Column<DateTime>(type: "Date", nullable: false, comment: "Episode release date"),
                    SeasonId = table.Column<int>(type: "int", nullable: false, comment: "Season identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.EpisodeId);
                    table.ForeignKey(
                        name: "FK_Episodes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Season episode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MovieId",
                table: "AspNetUsers",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ReviewId",
                table: "AspNetUsers",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SeriesId",
                table: "AspNetUsers",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesCrews_CrewId",
                table: "MoviesCrews",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesGenres_GenreId",
                table: "MoviesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesReviews_ReviewId",
                table: "MoviesReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CrewId",
                table: "Roles",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SeriesId",
                table: "Seasons",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCrews_CrewId",
                table: "SeriesCrews",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesGenres_GenreId",
                table: "SeriesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesReviews_ReviewId",
                table: "SeriesReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMovies_MovieId",
                table: "UsersMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersReviews_ReviewId",
                table: "UsersReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSeries_SerieId",
                table: "UsersSeries",
                column: "SerieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "MoviesCrews");

            migrationBuilder.DropTable(
                name: "MoviesGenres");

            migrationBuilder.DropTable(
                name: "MoviesReviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SeriesCrews");

            migrationBuilder.DropTable(
                name: "SeriesGenres");

            migrationBuilder.DropTable(
                name: "SeriesReviews");

            migrationBuilder.DropTable(
                name: "UsersMovies");

            migrationBuilder.DropTable(
                name: "UsersReviews");

            migrationBuilder.DropTable(
                name: "UsersSeries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
