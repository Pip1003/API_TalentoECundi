using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Modalidad")]
    public class Modalidad
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("nombre")]
        public string Nombre { get; set; }

        public ICollection<Oferta> Ofertas { get; set; }
    }
}
