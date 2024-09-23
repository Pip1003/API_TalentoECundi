using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("TestEgresado")]
    public class TestEgresado
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("egresado_id")]
        public int EgresadoId { get; set; }

        [ForeignKey("EgresadoId")]
        public Egresado Egresado { get; set; }

        [Required]
        [Column("test_id")]
        public int TestId { get; set; }

        [ForeignKey("TestId")]
        public Test Test { get; set; }

        [Column("TotalCorrectas")]
        public int TotalCorrectas { get; set; }

        [Column("Precision", TypeName = "decimal(4, 2)")]
        public double Precision { get; set; }

        [Column("puntaje", TypeName = "decimal(4, 2)")]
        public int Puntaje { get; set; }

        [Column("fecha_inicio")]
        public DateTime FechaInicio { get; set; }

        [Column("fecha_fin")]
        public DateTime? FechaFin { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        public ICollection<RespuestaEgresado> RespuestasEgresado { get; set; }

    }
}
