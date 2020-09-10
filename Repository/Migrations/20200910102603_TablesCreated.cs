using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class TablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionText",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LabelId",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostedBy",
                table: "Blogs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGalleries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductHighlights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    IsFilter = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Key = table.Column<string>(maxLength: 500, nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductHighlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductHighlights_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductItineraries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    IsFilter = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItineraries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItineraries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    IsFilter = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPolicies_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_LabelId",
                table: "Blogs",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGalleries_ProductId",
                table: "ProductGalleries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductHighlights_ProductId",
                table: "ProductHighlights",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItineraries_ProductId",
                table: "ProductItineraries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPolicies_ProductId",
                table: "ProductPolicies",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Labels_LabelId",
                table: "Blogs",
                column: "LabelId",
                principalTable: "Labels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Labels_LabelId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "ProductGalleries");

            migrationBuilder.DropTable(
                name: "ProductHighlights");

            migrationBuilder.DropTable(
                name: "ProductItineraries");

            migrationBuilder.DropTable(
                name: "ProductPolicies");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_LabelId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ActionText",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LabelId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PostedBy",
                table: "Blogs");
        }
    }
}
