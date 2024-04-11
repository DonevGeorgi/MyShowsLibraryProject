using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class SeedingUserReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "c3e5ab60-7376-45ab-a951-8c054ba57c49");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b221b4-dcf0-4f89-a7c0-9e930c87a789", "AQAAAAEAACcQAAAAELl2LtfEDUOxTY8uv+8dQiG1n2hIEV3cRdMOyBZBgkidz272HXcijYhb4hqbZ2Bs4g==", "cfb49ab8-3a9b-4584-b6ff-cbedc63acf77" });

            migrationBuilder.InsertData(
                table: "UsersReviews",
                columns: new[] { "ReviewId", "UserId" },
                values: new object[,]
                {
                    { 67, "8e656345-a56d-4543-a7c6-4556d32d4db2" },
                    { 68, "8e656345-a56d-4543-a7c6-4556d32d4db2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UsersReviews",
                keyColumns: new[] { "ReviewId", "UserId" },
                keyValues: new object[] { 67, "8e656345-a56d-4543-a7c6-4556d32d4db2" });

            migrationBuilder.DeleteData(
                table: "UsersReviews",
                keyColumns: new[] { "ReviewId", "UserId" },
                keyValues: new object[] { 68, "8e656345-a56d-4543-a7c6-4556d32d4db2" });

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
        }
    }
}
