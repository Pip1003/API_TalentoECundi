using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Rol")]
    public class Rol
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }  
    }
}
