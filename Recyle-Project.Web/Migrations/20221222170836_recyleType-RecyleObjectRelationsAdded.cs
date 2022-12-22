using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyle_Project.Web.Migrations
{
    public partial class recyleTypeRecyleObjectRelationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recyleObjects_recyletypes_RecyletypeTypeID",
                table: "recyleObjects");

            migrationBuilder.DropIndex(
                name: "IX_recyleObjects_RecyletypeTypeID",
                table: "recyleObjects");

            migrationBuilder.DropColumn(
                name: "RecyletypeTypeID",
                table: "recyleObjects");

            migrationBuilder.CreateIndex(
                name: "IX_recyleObjects_TypeID",
                table: "recyleObjects",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_recyleObjects_recyletypes_TypeID",
                table: "recyleObjects",
                column: "TypeID",
                principalTable: "recyletypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recyleObjects_recyletypes_TypeID",
                table: "recyleObjects");

            migrationBuilder.DropIndex(
                name: "IX_recyleObjects_TypeID",
                table: "recyleObjects");

            migrationBuilder.AddColumn<int>(
                name: "RecyletypeTypeID",
                table: "recyleObjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_recyleObjects_RecyletypeTypeID",
                table: "recyleObjects",
                column: "RecyletypeTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_recyleObjects_recyletypes_RecyletypeTypeID",
                table: "recyleObjects",
                column: "RecyletypeTypeID",
                principalTable: "recyletypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
