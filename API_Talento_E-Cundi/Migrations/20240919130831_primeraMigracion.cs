using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Talento_E_Cundi.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modalidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Titulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_ciudad = table.Column<int>(type: "int", nullable: false),
                    id_departamento = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    id_rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_id_rol",
                        column: x => x.id_rol,
                        principalTable: "Rol",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Egresado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    codigo_estudiante = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    id_residencia = table.Column<int>(type: "int", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ano_graduacion = table.Column<int>(type: "int", nullable: true),
                    imagen_perfil = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    curriculum = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresado", x => x.id);
                    table.ForeignKey(
                        name: "FK_Egresado_Ubicacion_id_residencia",
                        column: x => x.id_residencia,
                        principalTable: "Ubicacion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Egresado_Usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    nit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    correo_contacto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    pagina_web = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    banner = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    id_ubicacion_empresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_Empresa_Ubicacion_id_ubicacion_empresa",
                        column: x => x.id_ubicacion_empresa,
                        principalTable: "Ubicacion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Empresa_Usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Notificacion_Usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Egresado_Titulo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_egresado = table.Column<int>(type: "int", nullable: false),
                    id_titulo = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresado_Titulo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Egresado_Titulo_Egresado_id_egresado",
                        column: x => x.id_egresado,
                        principalTable: "Egresado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Egresado_Titulo_Titulo_id_titulo",
                        column: x => x.id_titulo,
                        principalTable: "Titulo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_empresa = table.Column<int>(type: "int", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    id_modalidad = table.Column<int>(type: "int", nullable: false),
                    id_ubicacion_oferta = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_publicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tipo_contrato = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    experiencia_requerida = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hora_trabajo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vacantes_disponibles = table.Column<int>(type: "int", nullable: false),
                    habilidades = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idiomas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Oferta_Empresa_id_empresa",
                        column: x => x.id_empresa,
                        principalTable: "Empresa",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Oferta_Modalidad_id_modalidad",
                        column: x => x.id_modalidad,
                        principalTable: "Modalidad",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Oferta_Ubicacion_id_ubicacion_oferta",
                        column: x => x.id_ubicacion_oferta,
                        principalTable: "Ubicacion",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_oferta = table.Column<int>(type: "int", nullable: false),
                    id_egresado = table.Column<int>(type: "int", nullable: false),
                    fecha_inscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Egresado_id_egresado",
                        column: x => x.id_egresado,
                        principalTable: "Egresado",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Inscripcion_Oferta_id_oferta",
                        column: x => x.id_oferta,
                        principalTable: "Oferta",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_codigo_estudiante",
                table: "Egresado",
                column: "codigo_estudiante",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_documento",
                table: "Egresado",
                column: "documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_id_residencia",
                table: "Egresado",
                column: "id_residencia");

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_id_usuario",
                table: "Egresado",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_Titulo_id_egresado",
                table: "Egresado_Titulo",
                column: "id_egresado");

            migrationBuilder.CreateIndex(
                name: "IX_Egresado_Titulo_id_titulo",
                table: "Egresado_Titulo",
                column: "id_titulo");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_id_ubicacion_empresa",
                table: "Empresa",
                column: "id_ubicacion_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_id_usuario",
                table: "Empresa",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_nit",
                table: "Empresa",
                column: "nit",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_id_egresado",
                table: "Inscripcion",
                column: "id_egresado");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_id_oferta",
                table: "Inscripcion",
                column: "id_oferta");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_id_usuario",
                table: "Notificacion",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_id_empresa",
                table: "Oferta",
                column: "id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_id_modalidad",
                table: "Oferta",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_id_ubicacion_oferta",
                table: "Oferta",
                column: "id_ubicacion_oferta");

            migrationBuilder.CreateIndex(
                name: "IX_Titulo_codigo",
                table: "Titulo",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_correo",
                table: "Usuario",
                column: "correo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_id_rol",
                table: "Usuario",
                column: "id_rol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Egresado_Titulo");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "Titulo");

            migrationBuilder.DropTable(
                name: "Egresado");

            migrationBuilder.DropTable(
                name: "Oferta");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Modalidad");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
