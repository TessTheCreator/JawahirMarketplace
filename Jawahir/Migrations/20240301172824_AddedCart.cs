using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jawahir.Migrations
{
    public partial class AddedCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Markets_MarketId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Carts_MarketId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MarketId",
                table: "Carts");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartItems",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartItems",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarketId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                table: "Products",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_MarketId",
                table: "Carts",
                column: "MarketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Markets_MarketId",
                table: "Carts",
                column: "MarketId",
                principalTable: "Markets",
                principalColumn: "MarketId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId");
        }
    }
}
