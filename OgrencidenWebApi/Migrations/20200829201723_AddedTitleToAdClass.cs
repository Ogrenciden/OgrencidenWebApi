using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrencidenWebApi.Migrations
{
    public partial class AddedTitleToAdClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdTitle",
                table: "Ads",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdTitle",
                table: "Ads");
        }
    }
}
