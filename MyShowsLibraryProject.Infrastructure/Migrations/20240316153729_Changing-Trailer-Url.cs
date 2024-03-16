using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class ChangingTrailerUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                column: "Name",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/qvsgGtivCgs?si=fc5W3Tjq1xSBOYoZ&amp");

            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.youtube.com/embed/bjqEWgDVPe0?si=1az-pQmunA3VvNlG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                column: "Name",
                value: "Drame");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.youtube.com/watch?v=qvsgGtivCgs&ab_channel=RottenTomatoesClassicTrailers");

            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "SeriesId",
                keyValue: 1,
                column: "TrailerUrl",
                value: "https://www.youtube.com/watch?v=bjqEWgDVPe0&ab_channel=HBOUK");
        }
    }
}
