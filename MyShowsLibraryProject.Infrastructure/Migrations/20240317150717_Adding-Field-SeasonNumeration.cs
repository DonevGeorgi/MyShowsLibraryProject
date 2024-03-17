using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddingFieldSeasonNumeration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeasonNumberation",
                table: "Seasons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Season numberation");

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1,
                column: "SeasonNumberation",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeasonNumberation",
                table: "Seasons");
        }
    }
}
