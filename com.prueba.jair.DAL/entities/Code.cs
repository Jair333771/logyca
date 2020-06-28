using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.prueba.jair.DAL.entities
{
    [Table("Codes")]
    public class Code
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="El id del propietario es requerido")]
        public int OwnerId { get; set; }

        [Required(ErrorMessage = "El Prefijo es requerido")]
        public string Prefix { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Enterprise Owner { get; set; }
    }
}
