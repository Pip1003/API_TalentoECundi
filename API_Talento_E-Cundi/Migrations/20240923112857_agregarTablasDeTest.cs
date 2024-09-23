using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Talento_E_Cundi.Migrations
{
    /// <inheritdoc />
    public partial class agregarTablasDeTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tiempo_minutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pregunta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    test_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregunta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pregunta_Test_test_id",
                        column: x => x.test_id,
                        principalTable: "Test",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TestEgresado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    egresado_id = table.Column<int>(type: "int", nullable: false),
                    test_id = table.Column<int>(type: "int", nullable: false),
                    TotalCorrectas = table.Column<int>(type: "int", nullable: false),
                    Precision = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    puntaje = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEgresado", x => x.id);
                    table.ForeignKey(
                        name: "FK_TestEgresado_Egresado_egresado_id",
                        column: x => x.egresado_id,
                        principalTable: "Egresado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_TestEgresado_Test_test_id",
                        column: x => x.test_id,
                        principalTable: "Test",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "HabilidadPregunta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    habilidad_id = table.Column<int>(type: "int", nullable: false),
                    pregunta_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadPregunta", x => x.id);
                    table.ForeignKey(
                        name: "FK_HabilidadPregunta_Habilidad_habilidad_id",
                        column: x => x.habilidad_id,
                        principalTable: "Habilidad",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_HabilidadPregunta_Pregunta_pregunta_id",
                        column: x => x.pregunta_id,
                        principalTable: "Pregunta",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Opcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contenido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respuesta = table.Column<bool>(type: "bit", nullable: false),
                    pregunta_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opcion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Opcion_Pregunta_pregunta_id",
                        column: x => x.pregunta_id,
                        principalTable: "Pregunta",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RespuestaEgresado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_test_egresado = table.Column<int>(type: "int", nullable: false),
                    id_pregunta = table.Column<int>(type: "int", nullable: false),
                    id_opcion_respuesta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaEgresado", x => x.id);
                    table.ForeignKey(
                        name: "FK_RespuestaEgresado_Opcion_id_opcion_respuesta",
                        column: x => x.id_opcion_respuesta,
                        principalTable: "Opcion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_RespuestaEgresado_Pregunta_id_pregunta",
                        column: x => x.id_pregunta,
                        principalTable: "Pregunta",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_RespuestaEgresado_TestEgresado_id_test_egresado",
                        column: x => x.id_test_egresado,
                        principalTable: "TestEgresado",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadPregunta_habilidad_id",
                table: "HabilidadPregunta",
                column: "habilidad_id");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadPregunta_pregunta_id",
                table: "HabilidadPregunta",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "IX_Opcion_pregunta_id",
                table: "Opcion",
                column: "pregunta_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pregunta_test_id",
                table: "Pregunta",
                column: "test_id");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaEgresado_id_opcion_respuesta",
                table: "RespuestaEgresado",
                column: "id_opcion_respuesta");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaEgresado_id_pregunta",
                table: "RespuestaEgresado",
                column: "id_pregunta");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaEgresado_id_test_egresado",
                table: "RespuestaEgresado",
                column: "id_test_egresado");

            migrationBuilder.CreateIndex(
                name: "IX_TestEgresado_egresado_id",
                table: "TestEgresado",
                column: "egresado_id");

            migrationBuilder.CreateIndex(
                name: "IX_TestEgresado_test_id",
                table: "TestEgresado",
                column: "test_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabilidadPregunta");

            migrationBuilder.DropTable(
                name: "RespuestaEgresado");

            migrationBuilder.DropTable(
                name: "Habilidad");

            migrationBuilder.DropTable(
                name: "Opcion");

            migrationBuilder.DropTable(
                name: "TestEgresado");

            migrationBuilder.DropTable(
                name: "Pregunta");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
