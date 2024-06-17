using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class MakingPostCascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "baac5879-72a6-4ea2-8289-f31cbd3e0eef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82f6998b-9987-4335-ba5c-1a415da15f5e", "AQAAAAEAACcQAAAAEGMVRibxj0Elo80N6hLDh1GqinmuKXr/lGwA36IMPV/599NsLqQWyyn2Wiq6e+TuAA==", "077f20e3-3c83-4606-bfa5-2430c5c56e6f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2c1h4e-3t6e-556f-86af-487y56fd2410",
                column: "ConcurrencyStamp",
                value: "f21b04d9-2d5c-4b86-ac1f-a8cf8bea5fb3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97bf7e96-3156-433b-83cb-81a0784b0ea6", "AQAAAAEAACcQAAAAEA0VY46R82fSyRMd6od6tqyjNQGxjn+pog1n2Tl8q8BaHtJ2VXSiN6avEqusk9ZqSw==", "a0fe045b-7096-41e2-860d-29c6860cddc1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Replys_Posts_PostId",
                table: "Replys",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
