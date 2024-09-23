using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Egresado_Titulo")]
    public class Egresado_Titulo
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_egresado")]
        [Required]
        public int IdEgresado { get; set; }

        [ForeignKey("IdEgresado")]
        public Egresado Egresado { get; set; }

        [Column("id_titulo")]
        [Required]
        public int IdTitulo { get; set; }

        [ForeignKey("IdTitulo")]
        public Titulo Titulo { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

    }
}
