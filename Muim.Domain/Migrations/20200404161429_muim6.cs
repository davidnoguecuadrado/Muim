using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muim6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MagiaPersonajes",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    MagiaId = table.Column<int>(nullable: false),
                    Nivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagiaPersonajes", x => new { x.PersonajeId, x.MagiaId });
                    table.ForeignKey(
                        name: "FK_MagiaPersonajes_Magias_MagiaId",
                        column: x => x.MagiaId,
                        principalTable: "Magias",
                        principalColumn: "MagiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MagiaPersonajes_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partidas",
                columns: table => new
                {
                    PartidaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas", x => x.PartidaId);
                });

            migrationBuilder.CreateTable(
                name: "PartidaUsuario",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ParitdaId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    PartidaId = table.Column<int>(nullable: true),
                    Rol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidaUsuario", x => new { x.UserId, x.ParitdaId });
                    table.ForeignKey(
                        name: "FK_PartidaUsuario_Partidas_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partidas",
                        principalColumn: "PartidaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartidaUsuario_Users_UserName",
                        column: x => x.UserName,
                        principalTable: "Users",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pup",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ParitdaId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    PartidaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pup", x => new { x.ParitdaId, x.PersonajeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Pup_Partidas_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partidas",
                        principalColumn: "PartidaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pup_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pup_Users_UserName",
                        column: x => x.UserName,
                        principalTable: "Users",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MagiaPersonajes_MagiaId",
                table: "MagiaPersonajes",
                column: "MagiaId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidaUsuario_PartidaId",
                table: "PartidaUsuario",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidaUsuario_UserName",
                table: "PartidaUsuario",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_PartidaId",
                table: "Pup",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_PersonajeId",
                table: "Pup",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_UserName",
                table: "Pup",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MagiaPersonajes");

            migrationBuilder.DropTable(
                name: "PartidaUsuario");

            migrationBuilder.DropTable(
                name: "Pup");

            migrationBuilder.DropTable(
                name: "Partidas");
        }
    }
}
