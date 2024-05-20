using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyShowsLibraryProject.Infrastructure.Migrations
{
    public partial class AddingForumDatabaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Movies_MovieId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Reviews_ReviewId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Series_SeriesId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_AspNetUsers_UserId",
                table: "UsersMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_Movies_MovieId",
                table: "UsersMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_AspNetUsers_UserId",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_Reviews_ReviewId",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSeries_AspNetUsers_UserId",
                table: "UsersSeries");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSeries_Series_SerieId",
                table: "UsersSeries");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MovieId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ReviewId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SeriesId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e656345-a56d-4543-a7c6-4556d32d4db2");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "SerieId",
                table: "UsersSeries",
                newName: "SerieIdentifier");

            migrationBuilder.RenameIndex(
                name: "IX_UsersSeries_SerieId",
                table: "UsersSeries",
                newName: "IX_UsersSeries_SerieIdentifier");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "UsersReviews",
                newName: "ReviewIdentifier");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_ReviewId",
                table: "UsersReviews",
                newName: "IX_UsersReviews_ReviewIdentifier");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "UsersMovies",
                newName: "MovieIdentifier");

            migrationBuilder.RenameIndex(
                name: "IX_UsersMovies_MovieId",
                table: "UsersMovies",
                newName: "IX_UsersMovies_MovieIdentifier");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Movies",
                type: "int",
                nullable: false,
                comment: "Serie identifier",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "User first name");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "User last name");

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false, comment: "Topic Identitfier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Topic name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                },
                comment: "Forum topics");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false, comment: "Post Identitfier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostBody = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Post text body"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Post creation date"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identitfier"),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId");
                },
                comment: "Forum posts");

            migrationBuilder.CreateTable(
                name: "Replys",
                columns: table => new
                {
                    ReplyId = table.Column<int>(type: "int", nullable: false, comment: "Reply Identitfier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyBody = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Reply text body"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identitfier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Reply creation date"),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replys", x => x.ReplyId);
                    table.ForeignKey(
                        name: "FK_Replys_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replys_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                },
                comment: "Posts replies");

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Replys_PostId",
                table: "Replys",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Replys_UserId",
                table: "Replys",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_AspNetUsers_UserId",
                table: "UsersMovies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_Movies_MovieIdentifier",
                table: "UsersMovies",
                column: "MovieIdentifier",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_AspNetUsers_UserId",
                table: "UsersReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Reviews_ReviewIdentifier",
                table: "UsersReviews",
                column: "ReviewIdentifier",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSeries_AspNetUsers_UserId",
                table: "UsersSeries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSeries_Series_SerieIdentifier",
                table: "UsersSeries",
                column: "SerieIdentifier",
                principalTable: "Series",
                principalColumn: "SeriesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_AspNetUsers_UserId",
                table: "UsersMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_Movies_MovieIdentifier",
                table: "UsersMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_AspNetUsers_UserId",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersReviews_Reviews_ReviewIdentifier",
                table: "UsersReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSeries_AspNetUsers_UserId",
                table: "UsersSeries");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersSeries_Series_SerieIdentifier",
                table: "UsersSeries");

            migrationBuilder.DropTable(
                name: "Replys");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "SerieIdentifier",
                table: "UsersSeries",
                newName: "SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersSeries_SerieIdentifier",
                table: "UsersSeries",
                newName: "IX_UsersSeries_SerieId");

            migrationBuilder.RenameColumn(
                name: "ReviewIdentifier",
                table: "UsersReviews",
                newName: "ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersReviews_ReviewIdentifier",
                table: "UsersReviews",
                newName: "IX_UsersReviews_ReviewId");

            migrationBuilder.RenameColumn(
                name: "MovieIdentifier",
                table: "UsersMovies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersMovies_MovieIdentifier",
                table: "UsersMovies",
                newName: "IX_UsersMovies_MovieId");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Serie identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MovieId",
                table: "AspNetUsers",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ReviewId",
                table: "AspNetUsers",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SeriesId",
                table: "AspNetUsers",
                column: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Movies_MovieId",
                table: "AspNetUsers",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Reviews_ReviewId",
                table: "AspNetUsers",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Series_SeriesId",
                table: "AspNetUsers",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_AspNetUsers_UserId",
                table: "UsersMovies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_Movies_MovieId",
                table: "UsersMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_AspNetUsers_UserId",
                table: "UsersReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReviews_Reviews_ReviewId",
                table: "UsersReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSeries_AspNetUsers_UserId",
                table: "UsersSeries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSeries_Series_SerieId",
                table: "UsersSeries",
                column: "SerieId",
                principalTable: "Series",
                principalColumn: "SeriesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
