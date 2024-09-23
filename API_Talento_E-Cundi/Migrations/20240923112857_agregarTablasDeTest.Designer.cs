﻿// <auto-generated />
using System;
using API_Talento_E_Cundi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Talento_E_Cundi.Migrations
{
    [DbContext(typeof(AplicacionDBContext))]
    [Migration("20240923112857_agregarTablasDeTest")]
    partial class agregarTablasDeTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Egresado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AnoGraduacion")
                        .HasColumnType("int")
                        .HasColumnName("ano_graduacion");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("apellidos");

                    b.Property<string>("CodigoEstudiante")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("codigo_estudiante");

                    b.Property<byte[]>("Curriculum")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("curriculum");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("documento");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_nacimiento");

                    b.Property<string>("Genero")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("genero");

                    b.Property<int?>("IdResidencia")
                        .HasColumnType("int")
                        .HasColumnName("id_residencia");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<byte[]>("ImagenPerfil")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("imagen_perfil");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombres");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.HasIndex("CodigoEstudiante")
                        .IsUnique();

                    b.HasIndex("Documento")
                        .IsUnique();

                    b.HasIndex("IdResidencia");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Egresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Egresado_Titulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<int>("IdEgresado")
                        .HasColumnType("int")
                        .HasColumnName("id_egresado");

                    b.Property<int>("IdTitulo")
                        .HasColumnType("int")
                        .HasColumnName("id_titulo");

                    b.HasKey("Id");

                    b.HasIndex("IdEgresado");

                    b.HasIndex("IdTitulo");

                    b.ToTable("Egresado_Titulo");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Banner")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("banner");

                    b.Property<string>("CorreoContacto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("correo_contacto");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdUbicacionEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_ubicacion_empresa");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("logo");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("nit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.Property<string>("PaginaWeb")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("pagina_web");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefono");

                    b.HasKey("Id");

                    b.HasIndex("IdUbicacionEmpresa");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("Nit")
                        .IsUnique();

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Habilidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Habilidad");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.HabilidadPregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HabilidadId")
                        .HasColumnType("int")
                        .HasColumnName("habilidad_id");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int")
                        .HasColumnName("pregunta_id");

                    b.HasKey("Id");

                    b.HasIndex("HabilidadId");

                    b.HasIndex("PreguntaId");

                    b.ToTable("HabilidadPregunta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaInscripcion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_inscripcion");

                    b.Property<int>("IdEgresado")
                        .HasColumnType("int")
                        .HasColumnName("id_egresado");

                    b.Property<int>("IdOferta")
                        .HasColumnType("int")
                        .HasColumnName("id_oferta");

                    b.HasKey("Id");

                    b.HasIndex("IdEgresado");

                    b.HasIndex("IdOferta");

                    b.ToTable("Inscripcion");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Modalidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Modalidad");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fecha");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("mensaje");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Notificacion");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("estado");

                    b.Property<string>("ExperienciaRequerida")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("experiencia_requerida");

                    b.Property<DateTime>("FechaCierre")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_cierre");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_publicacion");

                    b.Property<string>("Habilidades")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("habilidades");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<int>("IdModalidad")
                        .HasColumnType("int")
                        .HasColumnName("id_modalidad");

                    b.Property<int>("IdUbicacionOferta")
                        .HasColumnType("int")
                        .HasColumnName("id_ubicacion_oferta");

                    b.Property<string>("Idiomas")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("idiomas");

                    b.Property<string>("Jornada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("hora_trabajo");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("salario");

                    b.Property<string>("TipoContrato")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("tipo_contrato");

                    b.Property<int>("VacantesDisponibles")
                        .HasColumnType("int")
                        .HasColumnName("vacantes_disponibles");

                    b.Property<string>("cargo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("cargo");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdModalidad");

                    b.HasIndex("IdUbicacionOferta");

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Opcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("contenido");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int")
                        .HasColumnName("pregunta_id");

                    b.Property<bool>("Respuesta")
                        .HasColumnType("bit")
                        .HasColumnName("respuesta");

                    b.HasKey("Id");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Opcion");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("contenido");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("imagen");

                    b.Property<int>("TestId")
                        .HasColumnType("int")
                        .HasColumnName("test_id");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Pregunta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.RespuestaEgresado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdOpcionRespuesta")
                        .HasColumnType("int")
                        .HasColumnName("id_opcion_respuesta");

                    b.Property<int>("IdPregunta")
                        .HasColumnType("int")
                        .HasColumnName("id_pregunta");

                    b.Property<int>("IdTestEgresado")
                        .HasColumnType("int")
                        .HasColumnName("id_test_egresado");

                    b.HasKey("Id");

                    b.HasIndex("IdOpcionRespuesta");

                    b.HasIndex("IdPregunta");

                    b.HasIndex("IdTestEgresado");

                    b.ToTable("RespuestaEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<int>("TiempoMinutos")
                        .HasColumnType("int")
                        .HasColumnName("tiempo_minutos");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.TestEgresado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EgresadoId")
                        .HasColumnType("int")
                        .HasColumnName("egresado_id");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_fin");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_inicio");

                    b.Property<decimal>("Precision")
                        .HasColumnType("decimal(4, 2)")
                        .HasColumnName("Precision");

                    b.Property<decimal>("Puntaje")
                        .HasColumnType("decimal(4, 2)")
                        .HasColumnName("puntaje");

                    b.Property<int>("TestId")
                        .HasColumnType("int")
                        .HasColumnName("test_id");

                    b.Property<int>("TotalCorrectas")
                        .HasColumnType("int")
                        .HasColumnName("TotalCorrectas");

                    b.HasKey("Id");

                    b.HasIndex("EgresadoId");

                    b.HasIndex("TestId");

                    b.ToTable("TestEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Titulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("categoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("codigo");

                    b.HasKey("Id");

                    b.HasIndex("codigo")
                        .IsUnique();

                    b.ToTable("Titulo");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("direccion");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int")
                        .HasColumnName("id_ciudad");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int")
                        .HasColumnName("id_departamento");

                    b.HasKey("Id");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("contrasena");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("correo");

                    b.Property<int>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("id_rol");

                    b.HasKey("Id");

                    b.HasIndex("Correo")
                        .IsUnique();

                    b.HasIndex("IdRol");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Egresado", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("IdResidencia");

                    b.HasOne("API_Talento_E_Cundi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Egresado_Titulo", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Egresado", "Egresado")
                        .WithMany("Titulos")
                        .HasForeignKey("IdEgresado")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Titulo", "Titulo")
                        .WithMany("Egresado_Titulos")
                        .HasForeignKey("IdTitulo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Egresado");

                    b.Navigation("Titulo");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Empresa", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("IdUbicacionEmpresa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.HabilidadPregunta", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Habilidad", "Habilidad")
                        .WithMany("HabilidadPreguntas")
                        .HasForeignKey("HabilidadId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Pregunta", "Pregunta")
                        .WithMany("HabilidadesPregunta")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Habilidad");

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Inscripcion", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Egresado", "Egresado")
                        .WithMany("Inscripciones")
                        .HasForeignKey("IdEgresado")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Oferta", "Oferta")
                        .WithMany("Inscripciones")
                        .HasForeignKey("IdOferta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Egresado");

                    b.Navigation("Oferta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Notificacion", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Usuario", "Usuario")
                        .WithMany("Notificaciones")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Oferta", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Empresa", "Empresa")
                        .WithMany("Ofertas")
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Modalidad", "Modalidad")
                        .WithMany("Ofertas")
                        .HasForeignKey("IdModalidad")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("IdUbicacionOferta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Modalidad");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Opcion", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Pregunta", "Pregunta")
                        .WithMany("Opciones")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Pregunta", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Test", "Test")
                        .WithMany("Preguntas")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.RespuestaEgresado", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Opcion", "Opcion")
                        .WithMany("RespuestasEgresado")
                        .HasForeignKey("IdOpcionRespuesta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Pregunta", "Pregunta")
                        .WithMany("RespuestasEgresado")
                        .HasForeignKey("IdPregunta")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.TestEgresado", "TestEgresado")
                        .WithMany("RespuestasEgresado")
                        .HasForeignKey("IdTestEgresado")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Opcion");

                    b.Navigation("Pregunta");

                    b.Navigation("TestEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.TestEgresado", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Egresado", "Egresado")
                        .WithMany("TestsEgresado")
                        .HasForeignKey("EgresadoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("API_Talento_E_Cundi.Models.Test", "Test")
                        .WithMany("TestEgresados")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Egresado");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Usuario", b =>
                {
                    b.HasOne("API_Talento_E_Cundi.Models.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Egresado", b =>
                {
                    b.Navigation("Inscripciones");

                    b.Navigation("TestsEgresado");

                    b.Navigation("Titulos");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Empresa", b =>
                {
                    b.Navigation("Ofertas");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Habilidad", b =>
                {
                    b.Navigation("HabilidadPreguntas");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Modalidad", b =>
                {
                    b.Navigation("Ofertas");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Oferta", b =>
                {
                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Opcion", b =>
                {
                    b.Navigation("RespuestasEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Pregunta", b =>
                {
                    b.Navigation("HabilidadesPregunta");

                    b.Navigation("Opciones");

                    b.Navigation("RespuestasEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Test", b =>
                {
                    b.Navigation("Preguntas");

                    b.Navigation("TestEgresados");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.TestEgresado", b =>
                {
                    b.Navigation("RespuestasEgresado");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Titulo", b =>
                {
                    b.Navigation("Egresado_Titulos");
                });

            modelBuilder.Entity("API_Talento_E_Cundi.Models.Usuario", b =>
                {
                    b.Navigation("Notificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}