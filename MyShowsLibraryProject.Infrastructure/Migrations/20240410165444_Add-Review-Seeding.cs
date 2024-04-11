using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddReviewSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EpisodesInSeason",
                table: "Seasons",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Number of episodes in the season",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldComment: "Number of episodes in the season");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Episode release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldComment: "Episode release date");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "cd16a960-c63b-4c4d-aa5f-fb2f4ddd9c53");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56179d24-f278-419f-a56b-7eb7c532453b", "AQAAAAEAACcQAAAAEDzPIt4Avpk1KE/9rhzMy3TYny1gwd7DXvU5Frj/oJKxwwFlUmPQF3nU478mIvWwqQ==", "80052daa-86bf-4b36-b1bd-c8d27d8b014f" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "Rating" },
                values: new object[,]
                {
                    { 67, "Movie was great!", 5 },
                    { 68, "Serie was great!", 5 }
                });

            migrationBuilder.InsertData(
                table: "MoviesReviews",
                columns: new[] { "MovieId", "ReviewId" },
                values: new object[] { 1, 67 });

            migrationBuilder.InsertData(
                table: "SeriesReviews",
                columns: new[] { "ReviewId", "SerieId" },
                values: new object[] { 68, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MoviesReviews",
                keyColumns: new[] { "MovieId", "ReviewId" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "SeriesReviews",
                keyColumns: new[] { "ReviewId", "SerieId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 68);

            migrationBuilder.AlterColumn<string>(
                name: "EpisodesInSeason",
                table: "Seasons",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                comment: "Number of episodes in the season",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Number of episodes in the season");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Episodes",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                comment: "Episode release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Episode release date");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "bf082a53-5901-462f-9c7b-4cdca4c1f94e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df6715d4-415f-4041-b1fc-48484a7dba7f", "AQAAAAEAACcQAAAAEIRVJPEkCqzmzKSvqQ7HTlNwlqgLrJ7AYg+szAk1sBKRGSP/0ohquTvXyw52ozFszw==", "21c6d125-3bd9-4ab3-89de-780951d1dc2e" });
        }
    }
}
