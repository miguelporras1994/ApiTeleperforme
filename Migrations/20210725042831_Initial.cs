using Microsoft.EntityFrameworkCore.Migrations;

namespace Teleperforme.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<int>(type: "int", nullable: false),
                    Identification_number = table.Column<int>(type: "int", nullable: false),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Second_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Second_last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businnes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businnes");
        }
    }
}
