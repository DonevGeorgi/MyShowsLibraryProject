using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class ChangingSeasonNumerationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeasonNumberation",
                table: "Seasons",
                newName: "SeasonNumeration");

            migrationBuilder.AlterTable(
                name: "CrewRole",
                comment: "Crew role");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeasonNumeration",
                table: "Seasons",
                newName: "SeasonNumberation");

            migrationBuilder.AlterTable(
                name: "CrewRole",
                oldComment: "Crew role");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "bfdc76e0-35a0-40f4-a829-0a20ec3ff67e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f302b46b-1bad-44c3-adca-412127fce1c8", "AQAAAAEAACcQAAAAEOuWAOyFB8KWNmOS/jTktgqXzPjyYs5L3rHvPqe5ZN82Tzfk/RxlA67x3s5AZeJ1Ug==", "487376fb-8f09-4f63-9d7f-b8808596327e" });
        }
    }
}
