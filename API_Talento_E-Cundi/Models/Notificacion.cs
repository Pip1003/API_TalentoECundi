using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Notificacion")]
    public class Notificacion
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_usuario")]
        [Required]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Column("titulo")]
        [Required]
        [StringLength(20)]
        public string Titulo { get; set; }

        [Column("mensaje")]
        [StringLength(150)]
        [Required]
        public string Mensaje { get; set; }

        [Column("fecha")]
        public string Fecha { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");

        [Column("estado")]
        public string Estado { get; set; }
    }
}
