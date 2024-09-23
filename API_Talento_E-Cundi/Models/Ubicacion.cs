using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Talento_E_Cundi.Models
{
    [Table("Ubicacion")]
    public class Ubicacion
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("id_ciudad")]
        [Required]
        public int IdCiudad { get; set; }

        [Column("id_departamento")]
        [Required]
        public int IdDepartamento { get; set; }

        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }
    }
}
