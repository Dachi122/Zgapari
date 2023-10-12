using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zgapari.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zgaprebi",
                columns: table => new
                {
                    ZgapariId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zgaprebi", x => x.ZgapariId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zgaprebi");
        }
    }
}
