using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryTracking.Data.Migrations
{
    public partial class locationAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Location",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Location");
        }
    }
}
