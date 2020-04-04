using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personajes_Razas_RazaId",
                table: "Personajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Personajes_Tipos_TipoId",
                table: "Personajes");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "RazaId",
                table: "Personajes");

            migrationBuilder.AddColumn<int>(
                name: "PersonajeId",
                table: "Razas",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoId",
                table: "Personajes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Razas_PersonajeId",
                table: "Razas",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes",
                column: "TipoId",
                unique: true,
                filter: "[TipoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Personajes_Tipos_TipoId",
                table: "Personajes",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "TipoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Razas_Personajes_PersonajeId",
                table: "Razas",
                column: "PersonajeId",
                principalTable: "Personajes",
                principalColumn: "PersonajeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personajes_Tipos_TipoId",
                table: "Personajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Razas_Personajes_PersonajeId",
                table: "Razas");

            migrationBuilder.DropIndex(
                name: "IX_Razas_PersonajeId",
                table: "Razas");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "PersonajeId",
                table: "Razas");

            migrationBuilder.AlterColumn<int>(
                name: "TipoId",
                table: "Personajes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RazaId",
                table: "Personajes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Personajes_Razas_RazaId",
                table: "Personajes",
                column: "RazaId",
                principalTable: "Razas",
                principalColumn: "RazaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personajes_Tipos_TipoId",
                table: "Personajes",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "TipoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
