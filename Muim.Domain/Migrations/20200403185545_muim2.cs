using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes",
                column: "RazaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes",
                column: "TipoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes",
                column: "RazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes",
                column: "TipoId");
        }
    }
}
