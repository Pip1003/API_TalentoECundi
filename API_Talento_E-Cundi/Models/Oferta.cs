using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Oferta")]
    public class Oferta
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_empresa")]
        [Required]
        public int IdEmpresa { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Column("cargo")]
        [Required]
        [StringLength(60)]
        public string cargo { get; set; }

        [Column("id_modalidad")]
        public int IdModalidad { get; set; }

        [ForeignKey("IdModalidad")]
        public Modalidad Modalidad { get; set; }

        [Column("id_ubicacion_oferta")]
        [Required]
        public int IdUbicacionOferta { get; set; }

        [ForeignKey("IdUbicacionOferta")]
        public Ubicacion Ubicacion { get; set; }

        [Column("descripcion")]
        [Required]
        public string Descripcion { get; set; }

        [Column("fecha_publicacion")]
        public DateTime FechaPublicacion { get; set; } = DateTime.Now;

        [Column("fecha_cierre")]
        [Required]
        public DateTime FechaCierre { get; set; }

        [Column("estado")]
        [StringLength(1)]
        public string Estado { get; set; }

        [Column("salario",TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Salario { get; set; }

        [Column("tipo_contrato")]
        [Required]
        [StringLength(20)]
        public string TipoContrato { get; set; }

        [Column("experiencia_requerida")]
        [Required]
        [StringLength(100)]
        public string ExperienciaRequerida { get; set; }

        [Column("hora_trabajo")]
        public string Jornada { get; set; }

        [Column("vacantes_disponibles")]
        [Required]
        public int VacantesDisponibles { get; set; }

        [Column("habilidades")]
        [StringLength(100)]
        public string? Habilidades { get; set; }

        [Column("idiomas")]
        [StringLength(100)]
        public string? Idiomas { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
