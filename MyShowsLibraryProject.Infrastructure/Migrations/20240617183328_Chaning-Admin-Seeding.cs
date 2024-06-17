using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class ChaningAdminSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Replys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "f21b04d9-2d5c-4b86-ac1f-a8cf8bea5fb3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e656345-a56d-4543-a7c6-4556d32d4db2", 0, "97bf7e96-3156-433b-83cb-81a0784b0ea6", "ApplicationUser", "admin1@abv.bg", true, "Admin", "One", false, null, "ADMIN1@ABV.BG", "ADMIN1@ABV.BG", "AQAAAAEAACcQAAAAEA0VY46R82fSyRMd6od6tqyjNQGxjn+pog1n2Tl8q8BaHtJ2VXSiN6avEqusk9ZqSw==", null, false, "a0fe045b-7096-41e2-860d-29c6860cddc1", false, "admin1@abv.bg" });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Replys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Posts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "3f8f2d74-881a-4a5b-ae7a-591dd69b8b65");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e656345-a56d-4543-a7c6-4556d32d4db2", 0, "99ed8278-6841-44ab-a624-5eaa95344836", "IdentityUser", "admin1@abv.bg", true, false, null, "ADMIN1@ABV.BG", "ADMIN1@ABV.BG", "AQAAAAEAACcQAAAAEAIQKgRUjJR5C4iaNZofQ7HeRvzkiuVr+0FPicQDJlBPHlEUf4LMlRkUKt0Kk7me4w==", null, false, "0591842d-49aa-47f3-b79e-8d8fcad14b7a", false, "admin1@abv.bg" });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");
        }
    }
}
