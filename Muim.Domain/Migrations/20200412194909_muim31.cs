using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Razas_Personajes_PersonajeId",
                table: "Razas");

            migrationBuilder.DropIndex(
                name: "IX_Razas_PersonajeId",
                table: "Razas");

            migrationBuilder.DropColumn(
                name: "PersonajeId",
                table: "Razas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonajeId",
                table: "Razas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Razas_PersonajeId",
                table: "Razas",
                column: "PersonajeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Razas_Personajes_PersonajeId",
                table: "Razas",
                column: "PersonajeId",
                principalTable: "Personajes",
                principalColumn: "PersonajeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
