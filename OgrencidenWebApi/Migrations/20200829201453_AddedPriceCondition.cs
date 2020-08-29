using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrencidenWebApi.Migrations
{
    public partial class AddedPriceCondition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Ads",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ads");
        }
    }
}
