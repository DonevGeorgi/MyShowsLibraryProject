using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AdminAndUserAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c2c1h4e-3t6e-556f-86af-487y56fd2410", "84ac1574-f546-47f1-956b-e83c47494a97", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MovieId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ReviewId", "SecurityStamp", "SeriesId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e656345-a56d-4543-a7c6-4556d32d4db2", 0, "43d9c8da-4d5f-4590-a168-fb3521e8ed7c", "admin1@abv.bg", true, false, null, null, "ADMIN1@ABV.BG", "ADMIN1@ABV.BG", "AQAAAAEAACcQAAAAEBWBYS3nUYd3hAJo2inq9uvLbuEPG8srHoMuzIuP47lxb3wyY5T+7WGwt5eqFp5GaQ==", null, false, null, "3b75a223-d4ce-4521-af35-7af08fad4151", null, false, "admin1@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c2c1h4e-3t6e-556f-86af-487y56fd2410", "8e656345-a56d-4543-a7c6-4556d32d4db2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c2c1h4e-3t6e-556f-86af-487y56fd2410", "8e656345-a56d-4543-a7c6-4556d32d4db2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2");
        }
    }
}
