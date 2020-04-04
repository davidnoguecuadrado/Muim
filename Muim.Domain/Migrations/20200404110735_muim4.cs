using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personajes_Magias_MagiaId",
                table: "Personajes");

            migrationBuilder.DropIndex(
                name: "IX_Personajes_MagiaId",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "MagiaId",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "HabilidadPasivas");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "HabilidadActivas");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Canciones");

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "PersonajesCapacidades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "PersonajeHabilidadPasivas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "PersonajeHabilidadActiva",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "PersonajesCapacidades");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "PersonajeHabilidadPasivas");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "PersonajeHabilidadActiva");

            migrationBuilder.AddColumn<int>(
                name: "MagiaId",
                table: "Personajes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "HabilidadPasivas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "HabilidadActivas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "Canciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_MagiaId",
                table: "Personajes",
                column: "MagiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personajes_Magias_MagiaId",
                table: "Personajes",
                column: "MagiaId",
                principalTable: "Magias",
                principalColumn: "MagiaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
