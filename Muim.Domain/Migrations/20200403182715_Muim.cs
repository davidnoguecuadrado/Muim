using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class Muim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HabilidadActivas",
                columns: table => new
                {
                    HabilidadActivaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadActivas", x => x.HabilidadActivaId);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadPasivas",
                columns: table => new
                {
                    HabilidadPasivaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadPasivas", x => x.HabilidadPasivaId);
                });

            migrationBuilder.CreateTable(
                name: "Magias",
                columns: table => new
                {
                    MagiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magias", x => x.MagiaId);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    RazaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.RazaId);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    RazaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                    table.ForeignKey(
                        name: "FK_Tipos_Razas_RazaId",
                        column: x => x.RazaId,
                        principalTable: "Razas",
                        principalColumn: "RazaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Canciones",
                columns: table => new
                {
                    CapacidadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    TipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canciones", x => x.CapacidadId);
                    table.ForeignKey(
                        name: "FK_Canciones_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    RazaId = table.Column<int>(nullable: false),
                    TipoId = table.Column<int>(nullable: false),
                    MagiaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_Personajes_Magias_MagiaId",
                        column: x => x.MagiaId,
                        principalTable: "Magias",
                        principalColumn: "MagiaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Personajes_Razas_RazaId",
                        column: x => x.RazaId,
                        principalTable: "Razas",
                        principalColumn: "RazaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Personajes_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Tier = table.Column<int>(nullable: false),
                    PersonajeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoId);
                    table.ForeignKey(
                        name: "FK_Equipos_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajeHabilidadActiva",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    HabilidadActivaInt = table.Column<int>(nullable: false),
                    HabilidadActivaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajeHabilidadActiva", x => new { x.HabilidadActivaInt, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PersonajeHabilidadActiva_HabilidadActivas_HabilidadActivaId",
                        column: x => x.HabilidadActivaId,
                        principalTable: "HabilidadActivas",
                        principalColumn: "HabilidadActivaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonajeHabilidadActiva_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajeHabilidadPasivas",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    HabilidadPasivaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajeHabilidadPasivas", x => new { x.HabilidadPasivaId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PersonajeHabilidadPasivas_HabilidadPasivas_HabilidadPasivaId",
                        column: x => x.HabilidadPasivaId,
                        principalTable: "HabilidadPasivas",
                        principalColumn: "HabilidadPasivaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajeHabilidadPasivas_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesCapacidades",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    CapacidadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesCapacidades", x => new { x.CapacidadId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PersonajesCapacidades_Canciones_CapacidadId",
                        column: x => x.CapacidadId,
                        principalTable: "Canciones",
                        principalColumn: "CapacidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesCapacidades_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_TipoId",
                table: "Canciones",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PersonajeId",
                table: "Equipos",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeHabilidadActiva_HabilidadActivaId",
                table: "PersonajeHabilidadActiva",
                column: "HabilidadActivaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeHabilidadActiva_PersonajeId",
                table: "PersonajeHabilidadActiva",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajeHabilidadPasivas_PersonajeId",
                table: "PersonajeHabilidadPasivas",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_MagiaId",
                table: "Personajes",
                column: "MagiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes",
                column: "RazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesCapacidades_PersonajeId",
                table: "PersonajesCapacidades",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_RazaId",
                table: "Tipos",
                column: "RazaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "PersonajeHabilidadActiva");

            migrationBuilder.DropTable(
                name: "PersonajeHabilidadPasivas");

            migrationBuilder.DropTable(
                name: "PersonajesCapacidades");

            migrationBuilder.DropTable(
                name: "HabilidadActivas");

            migrationBuilder.DropTable(
                name: "HabilidadPasivas");

            migrationBuilder.DropTable(
                name: "Canciones");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Magias");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Razas");
        }
    }
}
