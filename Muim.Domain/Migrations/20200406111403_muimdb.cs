using Microsoft.EntityFrameworkCore.Migrations;

namespace Muim.Domain.Migrations
{
    public partial class muimdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassCharacter",
                columns: table => new
                {
                    ClassCharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCharacter", x => x.ClassCharacterId);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadActivas",
                columns: table => new
                {
                    HabilidadActivaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
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
                    Descripcion = table.Column<string>(nullable: true)
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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Capacidades",
                columns: table => new
                {
                    CapacidadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    ClassCharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacidades", x => x.CapacidadId);
                    table.ForeignKey(
                        name: "FK_Capacidades_ClassCharacter_ClassCharacterId",
                        column: x => x.ClassCharacterId,
                        principalTable: "ClassCharacter",
                        principalColumn: "ClassCharacterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartidaUsuario",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ParitdaId = table.Column<int>(nullable: false),
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
                        name: "FK_PartidaUsuario_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassCharacterCpacidades",
                columns: table => new
                {
                    CapacidadId = table.Column<int>(nullable: false),
                    ClassCharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCharacterCpacidades", x => new { x.CapacidadId, x.ClassCharacterId });
                    table.ForeignKey(
                        name: "FK_ClassCharacterCpacidades_Capacidades_CapacidadId",
                        column: x => x.CapacidadId,
                        principalTable: "Capacidades",
                        principalColumn: "CapacidadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCharacterCpacidades_ClassCharacter_ClassCharacterId",
                        column: x => x.ClassCharacterId,
                        principalTable: "ClassCharacter",
                        principalColumn: "ClassCharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesCapacidades",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    CapacidadId = table.Column<int>(nullable: false),
                    Nivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesCapacidades", x => new { x.CapacidadId, x.PersonajeId });
                    table.ForeignKey(
                        name: "FK_PersonajesCapacidades_Capacidades_CapacidadId",
                        column: x => x.CapacidadId,
                        principalTable: "Capacidades",
                        principalColumn: "CapacidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Aspecto = table.Column<int>(nullable: false),
                    HerenciMaagica = table.Column<string>(nullable: true),
                    EstadoFisico = table.Column<string>(nullable: true),
                    EstadoMental = table.Column<string>(nullable: true),
                    PoderMagico = table.Column<int>(nullable: false),
                    TierDeArmadura = table.Column<int>(nullable: false),
                    EscudoMásico = table.Column<int>(nullable: false),
                    BaseDeKan = table.Column<int>(nullable: false),
                    PuntosARepartir = table.Column<int>(nullable: false),
                    Tamaño = table.Column<int>(nullable: false),
                    Peso = table.Column<int>(nullable: false),
                    Constitución = table.Column<int>(nullable: false),
                    Potencial = table.Column<int>(nullable: false),
                    PoderPuntos = table.Column<int>(nullable: false),
                    PoderEntrenado = table.Column<int>(nullable: false),
                    ValorPuntos = table.Column<int>(nullable: false),
                    ValorEntrenado = table.Column<int>(nullable: false),
                    AgilidadPuntos = table.Column<int>(nullable: false),
                    AgilidadEntrenado = table.Column<int>(nullable: false),
                    SabiduríaPuntos = table.Column<int>(nullable: false),
                    SabiduríaEntrenado = table.Column<int>(nullable: false),
                    DestrezaPuntos = table.Column<int>(nullable: false),
                    DestrezaEntrenado = table.Column<int>(nullable: false),
                    EsperanzaPuntos = table.Column<int>(nullable: false),
                    EsperanzaEntrenado = table.Column<int>(nullable: false),
                    Fortuna = table.Column<int>(nullable: false),
                    TipoId = table.Column<int>(nullable: true),
                    ClassCharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_Personajes_ClassCharacter_ClassCharacterId",
                        column: x => x.ClassCharacterId,
                        principalTable: "ClassCharacter",
                        principalColumn: "ClassCharacterId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "PersonajeHabilidadActiva",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    HabilidadActivaInt = table.Column<int>(nullable: false),
                    HabilidadActivaId = table.Column<int>(nullable: true),
                    Nivel = table.Column<int>(nullable: false)
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
                    HabilidadPasivaId = table.Column<int>(nullable: false),
                    Nivel = table.Column<int>(nullable: false)
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
                name: "Pup",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ParitdaId = table.Column<int>(nullable: false),
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
                        name: "FK_Pup_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    RazaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    PersonajeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.RazaId);
                    table.ForeignKey(
                        name: "FK_Razas_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_Capacidades_ClassCharacterId",
                table: "Capacidades",
                column: "ClassCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCharacterCpacidades_ClassCharacterId",
                table: "ClassCharacterCpacidades",
                column: "ClassCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PersonajeId",
                table: "Equipos",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_MagiaPersonajes_MagiaId",
                table: "MagiaPersonajes",
                column: "MagiaId");

            migrationBuilder.CreateIndex(
                name: "IX_PartidaUsuario_PartidaId",
                table: "PartidaUsuario",
                column: "PartidaId");

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
                name: "IX_Personajes_ClassCharacterId",
                table: "Personajes",
                column: "ClassCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TipoId",
                table: "Personajes",
                column: "TipoId",
                unique: true,
                filter: "[TipoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesCapacidades_PersonajeId",
                table: "PersonajesCapacidades",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_PartidaId",
                table: "Pup",
                column: "PartidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_PersonajeId",
                table: "Pup",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pup_UserId",
                table: "Pup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Razas_PersonajeId",
                table: "Razas",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipos_RazaId",
                table: "Tipos",
                column: "RazaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonajesCapacidades_Personajes_PersonajeId",
                table: "PersonajesCapacidades",
                column: "PersonajeId",
                principalTable: "Personajes",
                principalColumn: "PersonajeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personajes_Tipos_TipoId",
                table: "Personajes",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "TipoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personajes_ClassCharacter_ClassCharacterId",
                table: "Personajes");

            migrationBuilder.DropForeignKey(
                name: "FK_Razas_Personajes_PersonajeId",
                table: "Razas");

            migrationBuilder.DropTable(
                name: "ClassCharacterCpacidades");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "MagiaPersonajes");

            migrationBuilder.DropTable(
                name: "PartidaUsuario");

            migrationBuilder.DropTable(
                name: "PersonajeHabilidadActiva");

            migrationBuilder.DropTable(
                name: "PersonajeHabilidadPasivas");

            migrationBuilder.DropTable(
                name: "PersonajesCapacidades");

            migrationBuilder.DropTable(
                name: "Pup");

            migrationBuilder.DropTable(
                name: "Magias");

            migrationBuilder.DropTable(
                name: "HabilidadActivas");

            migrationBuilder.DropTable(
                name: "HabilidadPasivas");

            migrationBuilder.DropTable(
                name: "Capacidades");

            migrationBuilder.DropTable(
                name: "Partidas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ClassCharacter");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Razas");
        }
    }
}
