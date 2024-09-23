using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [MaxLength(60)]
        public string Nombre { get; set; }

        [Column("tiempo_minutos")]
        public int TiempoMinutos { get; set; }

        public ICollection<Pregunta> Preguntas { get; set; }

        public ICollection<TestEgresado> TestEgresados{ get; set; }
    }
}
