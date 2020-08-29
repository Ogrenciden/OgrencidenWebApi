using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrencidenWebApi.Migrations
{
    public partial class DbSetupRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserProfilePhotos_UserProfilePhotoPhotoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserProfilePhotoPhotoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserProfilePhotoPhotoId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserProfilePhotos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfilePhotos_UserId",
                table: "UserProfilePhotos",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfilePhotos_Users_UserId",
                table: "UserProfilePhotos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfilePhotos_Users_UserId",
                table: "UserProfilePhotos");

            migrationBuilder.DropIndex(
                name: "IX_UserProfilePhotos_UserId",
                table: "UserProfilePhotos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserProfilePhotos");

            migrationBuilder.AddColumn<int>(
                name: "UserProfilePhotoPhotoId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfilePhotoPhotoId",
                table: "Users",
                column: "UserProfilePhotoPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserProfilePhotos_UserProfilePhotoPhotoId",
                table: "Users",
                column: "UserProfilePhotoPhotoId",
                principalTable: "UserProfilePhotos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
