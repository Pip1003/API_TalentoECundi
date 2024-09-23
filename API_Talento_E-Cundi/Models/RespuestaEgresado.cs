using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("RespuestaEgresado")]
    public class RespuestaEgresado
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_test_egresado")]
        public int IdTestEgresado { get; set; }

        [ForeignKey("IdTestEgresado")]
        public TestEgresado TestEgresado { get; set; }

        [Column("id_pregunta")]
        public int IdPregunta { get; set; }

        [ForeignKey("IdPregunta")]
        public Pregunta Pregunta { get; set; }

        [Column("id_opcion_respuesta")]
        public int IdOpcionRespuesta { get; set; }

        [ForeignKey("IdOpcionRespuesta")]
        public Opcion Opcion { get; set; }
    }
}
