using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class IsAwesomePack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAwsomePack",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAwsomePack",
                table: "Products");
        }
    }
}
