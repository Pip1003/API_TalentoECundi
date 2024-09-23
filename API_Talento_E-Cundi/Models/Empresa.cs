using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        [Column("nit")]
        [Required]
        [StringLength(30)]
        public string Nit { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Column("telefono")]
        [StringLength(15)]
        public string? Telefono { get; set; }

        [Column("correo_contacto")]
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string CorreoContacto { get; set; }

        [Column("pagina_web")]
        [StringLength(100)]
        public string PaginaWeb { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("logo")]
        public byte[]? Logo { get; set; }

        [Column("banner")]
        public byte[]? Banner { get; set; }

        [Column("id_ubicacion_empresa")]
        public int IdUbicacionEmpresa { get; set; }

        [ForeignKey("IdUbicacionEmpresa")]
        public Ubicacion Ubicacion { get; set; }

        public ICollection<Oferta> Ofertas { get; set; }
    }
}
