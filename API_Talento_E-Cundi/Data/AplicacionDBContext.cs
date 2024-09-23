    using Microsoft.EntityFrameworkCore;
    using API_Talento_E_Cundi.Models;

    namespace API_Talento_E_Cundi.Data
{
    public class AplicacionDBContext : DbContext
    {
        public AplicacionDBContext(DbContextOptions<AplicacionDBContext> options) : base(options)
        {
        }

        public DbSet<Egresado> Egresado { get; set; }
        public DbSet<Egresado_Titulo> Egresado_Titulo { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<Modalidad> Modalidad { get; set; }
        public DbSet<Notificacion> Notificacion { get; set; }
        public DbSet<Oferta> Oferta { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Titulo> Titulo { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Egresado_Titulo>()
                .HasOne(et => et.Egresado)
                .WithMany(e => e.Titulos)
                .HasForeignKey(et => et.IdEgresado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Egresado_Titulo>()
                .HasOne(et => et.Titulo)
                .WithMany( t => t.Egresado_Titulos)
                .HasForeignKey(et => et.IdTitulo)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Empresa>()
                .HasOne(e => e.Ubicacion)
                .WithMany()
                .HasForeignKey(e => e.IdUbicacionEmpresa)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Oferta)
                .WithMany(o => o.Inscripciones)
                .HasForeignKey(i => i.IdOferta)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Egresado)
                .WithMany(e => e.Inscripciones)
                .HasForeignKey(i => i.IdEgresado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Notificacion>()
                .HasOne(n => n.Usuario)
                .WithMany(u => u.Notificaciones)
                .HasForeignKey(n => n.IdUsuario)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Oferta>()
                .HasOne(o => o.Ubicacion)
                .WithMany()
                .HasForeignKey(o => o.IdUbicacionOferta)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Oferta>()
                .HasOne(o => o.Modalidad)
                .WithMany(m => m.Ofertas)
                .HasForeignKey(o => o.IdModalidad)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Oferta>()
                .HasOne(o => o.Empresa)
                .WithMany( e => e.Ofertas)
                .HasForeignKey(o => o.IdEmpresa)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(u => u.IdRol)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HabilidadPregunta>()
                .HasOne(hp => hp.Habilidad)
                .WithMany(h => h.HabilidadPreguntas)
                .HasForeignKey(hp => hp.HabilidadId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HabilidadPregunta>()
                .HasOne(hp => hp.Pregunta)
                .WithMany(p => p.HabilidadesPregunta)
                .HasForeignKey(hp => hp.PreguntaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Opcion>()
                .HasOne(o => o.Pregunta)
                .WithMany(p => p.Opciones)
                .HasForeignKey(o => o.PreguntaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pregunta>()
                .HasOne(p => p.Test)
                .WithMany(t => t.Preguntas)
                .HasForeignKey(p => p.TestId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RespuestaEgresado>()
                .HasOne(re => re.TestEgresado)
                .WithMany( te => te.RespuestasEgresado)
                .HasForeignKey(re => re.IdTestEgresado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RespuestaEgresado>()
                .HasOne(re => re.Pregunta)
                .WithMany(p => p.RespuestasEgresado)
                .HasForeignKey(re => re.IdPregunta)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RespuestaEgresado>()
                .HasOne(re => re.Opcion)
                .WithMany(o => o.RespuestasEgresado)
                .HasForeignKey(re => re.IdOpcionRespuesta)
                .OnDelete(DeleteBehavior.NoAction);     

            modelBuilder.Entity<TestEgresado>()
                .HasOne(te => te.Egresado)
                .WithMany(e => e.TestsEgresado)
                .HasForeignKey(te => te.EgresadoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TestEgresado>()
                .HasOne(te => te.Test)
                .WithMany(t => t.TestEgresados)
                .HasForeignKey(te => te.TestId)
                .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Correo)
                .IsUnique();

            modelBuilder.Entity<Egresado>()
                .HasIndex(e => e.CodigoEstudiante)
                .IsUnique();    

            modelBuilder.Entity<Egresado>()
                .HasIndex(e => e.Documento)
                .IsUnique();

            modelBuilder.Entity<Empresa>()
                .HasIndex(e => e.Nit)
                .IsUnique();

            modelBuilder.Entity<Titulo>()
                .HasIndex(t => t.codigo)
                .IsUnique();

        }
    }
}
