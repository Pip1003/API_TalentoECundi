using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Opcion")]
    public class Opcion
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("contenido")]
        [Required]
        public string Contenido { get; set; }

        [Column("respuesta")]
        [Required]
        public bool Respuesta { get; set; }

        [Column("pregunta_id")]
        public int PreguntaId { get; set; }

        [ForeignKey("PreguntaId")]
        public Pregunta Pregunta { get; set;}

        public ICollection<RespuestaEgresado> RespuestasEgresado { get; set; }
    }
}
