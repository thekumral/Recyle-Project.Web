using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class ProfilImageStringAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReValue",
                table: "users",
                newName: "ReValueWallet");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "ReValueWallet",
                table: "users",
                newName: "ReValue");
        }
    }
}
