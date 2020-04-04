using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class Muim7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgilidadEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgilidadPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aspecto",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseDeKan",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitución",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestrezaEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestrezaPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EscudoMásico",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EsperanzaEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EsperanzaPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EstadoFisico",
                table: "Personajes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoMental",
                table: "Personajes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fortuna",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HerenciMaagica",
                table: "Personajes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PoderEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PoderMagico",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PoderPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Potencial",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PuntosARepartir",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SabiduríaEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SabiduríaPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tamaño",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TierDeArmadura",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValorEntrenado",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValorPuntos",
                table: "Personajes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgilidadEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "AgilidadPuntos",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Aspecto",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "BaseDeKan",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Constitución",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "DestrezaEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "DestrezaPuntos",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "EscudoMásico",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "EsperanzaEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "EsperanzaPuntos",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "EstadoFisico",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "EstadoMental",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Fortuna",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "HerenciMaagica",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "PoderEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "PoderMagico",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "PoderPuntos",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Potencial",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "PuntosARepartir",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "SabiduríaEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "SabiduríaPuntos",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "Tamaño",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "TierDeArmadura",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "ValorEntrenado",
                table: "Personajes");

            migrationBuilder.DropColumn(
                name: "ValorPuntos",
                table: "Personajes");
        }
    }
}
