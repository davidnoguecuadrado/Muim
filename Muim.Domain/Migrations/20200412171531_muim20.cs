using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Magias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Magias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
