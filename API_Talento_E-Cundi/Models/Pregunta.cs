using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Pregunta")]
    public class Pregunta
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("contenido")]
        [Required]
        public string Contenido { get; set; }

        [Column("imagen")]
        public byte[]? Imagen { get; set; }

        [Column("test_id")]
        public int TestId { get; set; }

        [ForeignKey("TestId")]
        public Test Test { get; set; }

        public ICollection<HabilidadPregunta> HabilidadesPregunta  { get; set; }

        public ICollection<Opcion> Opciones { get; set; }

        public ICollection<RespuestaEgresado> RespuestasEgresado { get; set; }

    }
}
