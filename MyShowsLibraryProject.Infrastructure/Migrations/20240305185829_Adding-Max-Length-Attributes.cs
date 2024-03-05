using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddingMaxLengthAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfRelease",
                table: "Movies",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                comment: "Movie release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Movie release date");

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

            migrationBuilder.AlterColumn<string>(
                name: "Birthdate",
                table: "Crews",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                comment: "Crew birthdate",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Crew birthdate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfRelease",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Movie release date",
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldComment: "Movie release date");

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

            migrationBuilder.AlterColumn<string>(
                name: "Birthdate",
                table: "Crews",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Crew birthdate",
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldComment: "Crew birthdate");
        }
    }
}
