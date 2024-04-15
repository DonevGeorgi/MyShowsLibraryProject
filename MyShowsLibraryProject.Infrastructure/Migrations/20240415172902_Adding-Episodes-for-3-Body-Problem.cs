using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddingEpisodesfor3BodyProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "03758fd6-f962-4378-8295-e917004a5776");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ad6d26b-70c5-4759-847c-3ac4b5a4e0a2", "AQAAAAEAACcQAAAAEGoPDIqDYdAZXF9K7RmkAdZ3atvPDOLC4qYW5p/B8H64xFibTJe643EGLIjXuuwfiA==", "e7f4f7f9-e3fa-4f77-9396-5b59f3dc5ec3" });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "EpisodeNumeration", "PosterUrl", "ReleaseDate", "SeasonId", "SeasonNumber", "Summary" },
                values: new object[,]
                {
                    { 41, 1, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "Unsettling events put a group of brilliant friends on edge as a mystery unravels with origins tracing back to China during the Cultural Revolution." },
                    { 42, 2, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "Auggie's countdown jeopardizes her nanotech work. Jin becomes engrossed in an otherworldly VR game. Ye Wenjie follows through on a radical idea." },
                    { 43, 3, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "Obsessed with their virtual reality quest, Jin and Jack race to solve a complex riddle but advancing to the next level brings harrowing consequences." },
                    { 44, 4, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "Jin seeks justice after a death rattles the group. Investigators learn of an extremist group devoted to an otherworldly entity ahead of a major summit." },
                    { 45, 5, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "As threat levels rise, a secret mission to retrieve enemy intel ventures into dangerous territory. An ominous message reaches Earth." },
                    { 46, 6, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "With the world in a state of panic following a momentous declaration, Wade gathers the world's greatest minds to prepare a defense plan." },
                    { 47, 7, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "A bold proposition for the Staircase Project puts the group at odds. Will weighs his options. Ye returns to a familiar place." },
                    { 48, 8, "https://www.flatpanelshd.com/pictures/3bodyproblem.jpg", "21 Mar 2024", 8, 1, "A high-level operation upends Saul's life. With emotions and expectations high, the probe launches into space as humanity enters a daunting new era." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "f545a72d-4969-4cfc-a7de-8c41e283010a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e01b48e-aaa4-4a29-b10b-02231fba6cd0", "AQAAAAEAACcQAAAAECvSUvxpqPpXzxRnYXmIGrtovtRJ+2U8TGgdlNryH3wJKw9O9NBZ9ewIDNWw4n8rhg==", "b1cb7b4b-007e-465d-98e2-fc639097847e" });
        }
    }
}
