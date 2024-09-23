using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Habilidad")]
    public class Habilidad
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        public ICollection<HabilidadPregunta> HabilidadPreguntas { get; set; }
    }
}
