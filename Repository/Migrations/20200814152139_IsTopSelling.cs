using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class IsTopSelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTopSelling",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTopSelling",
                table: "Products");
        }
    }
}
