using Microsoft.EntityFrameworkCore.Migrations;

namespace Teleperforme.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Businnes",
                table: "Businnes");

            migrationBuilder.RenameTable(
                name: "Businnes",
                newName: "Business");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Business",
                table: "Business",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Business",
                table: "Business");

            migrationBuilder.RenameTable(
                name: "Business",
                newName: "Businnes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Businnes",
                table: "Businnes",
                column: "Id");
        }
    }
}
