using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BlogAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogDetailId",
                table: "Favorites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    BlogId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    PostedBy = table.Column<string>(nullable: true),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    BlogId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogDetails_Blogs_BlogId1",
                        column: x => x.BlogId1,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    BlogDetailId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CraetedBy = table.Column<string>(maxLength: 100, nullable: false),
                    Review = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogReviews_BlogDetails_BlogDetailId",
                        column: x => x.BlogDetailId,
                        principalTable: "BlogDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_BlogDetailId",
                table: "Favorites",
                column: "BlogDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogDetails_BlogId1",
                table: "BlogDetails",
                column: "BlogId1");

            migrationBuilder.CreateIndex(
                name: "IX_BlogReviews_BlogDetailId",
                table: "BlogReviews",
                column: "BlogDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogReviews_UserId",
                table: "BlogReviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_BlogDetails_BlogDetailId",
                table: "Favorites",
                column: "BlogDetailId",
                principalTable: "BlogDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_BlogDetails_BlogDetailId",
                table: "Favorites");

            migrationBuilder.DropTable(
                name: "BlogReviews");

            migrationBuilder.DropTable(
                name: "BlogDetails");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_BlogDetailId",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "BlogDetailId",
                table: "Favorites");
        }
    }
}
