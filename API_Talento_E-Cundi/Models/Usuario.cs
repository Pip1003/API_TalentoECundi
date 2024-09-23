using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("correo")]
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Correo { get; set; }

        [Column("contrasena")]
        [Required]
        [StringLength(20)]
        public string Contrasena { get; set; }

        [Column("id_rol")]
        [Required]
        public int IdRol { get; set; }
        public Rol Rol { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }
     }
}
