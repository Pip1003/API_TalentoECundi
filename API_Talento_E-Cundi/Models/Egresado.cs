using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Egresado")]
    public class Egresado
    {
        [Required]
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Required]
        [Column("codigo_estudiante")]
        [StringLength(20)]
        public string CodigoEstudiante { get; set; }

        [Required]
        [Column("documento")]
        [StringLength(20)]
        public string Documento { get; set; }

        [Required]
        [Column("nombres")]
        [StringLength(100)]
        public string Nombres { get; set; }

        [Required]
        [Column("apellidos")]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Column("telefono")]
        [StringLength(15)]
        public string? Telefono { get; set; }

        [Column("id_residencia")]
        public int? IdResidencia { get; set; }

        [ForeignKey("IdResidencia")]
        public Ubicacion? Ubicacion { get; set; }

        [Column("genero")]
        [StringLength(1)]
        public string? Genero { get; set; }

        [Column("fecha_nacimiento")]
        public System.DateTime? FechaNacimiento { get; set; }

        [Column("ano_graduacion")]
        public int? AnoGraduacion { get; set; }

        [Column("imagen_perfil")]
        public byte[]? ImagenPerfil { get; set; }

        [Column("curriculum")]
        public byte[]? Curriculum { get; set; }

        public ICollection<Egresado_Titulo> Titulos { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }

        public ICollection<TestEgresado> TestsEgresado { get; set; }
    }
}
