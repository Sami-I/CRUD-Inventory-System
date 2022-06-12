using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryTracking.Data.Migrations
{
    public partial class fixId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Location_LocationID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Location_LocationId",
                table: "Product",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Location_LocationId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Product",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Location_LocationID",
                table: "Product",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
