using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Titulo")]
    public class Titulo
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("codigo")]
        public string codigo { get; set; }

        [Column("categoria")]
        public string Categoria { get; set; }

        public ICollection<Egresado_Titulo> Egresado_Titulos { get; set; }

    }
}
