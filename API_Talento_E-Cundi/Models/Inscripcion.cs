using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Inscripcion")]
    public class Inscripcion
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_oferta")]
        [Required]
        public int IdOferta { get; set; }

        [ForeignKey("IdOferta")]
        public Oferta Oferta { get; set; }

        [Column("id_egresado")]
        [Required]
        public int IdEgresado { get; set; }

        [ForeignKey("IdEgresado")]
        public Egresado Egresado { get; set; }

        [Column("fecha_inscripcion")]
        public DateTime FechaInscripcion { get; set; }

        [Column("estado")]
        public string Estado { get; set; }
    }
}
