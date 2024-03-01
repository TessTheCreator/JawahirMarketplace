using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jawahir.Migrations
{
    public partial class addCategoriies1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCategoryName",
                table: "SubCategories");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "SubCategoryName",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
