using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("HabilidadPregunta")] 
    public class HabilidadPregunta
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("habilidad_id")]
        [Required]
        public int HabilidadId { get; set; }

        [ForeignKey("HabilidadId")]
        public Habilidad Habilidad { get; set; }

        [Column("pregunta_id")]
        [Required]
        public int PreguntaId { get; set; }

        [ForeignKey("PreguntaId")]
        public Pregunta Pregunta { get; set; }
    }
}
