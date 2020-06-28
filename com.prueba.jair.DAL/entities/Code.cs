using System.ComponentModel.DataAnnotations;

namespace com.prueba.jair.DAL.entities
{
    public class Code
    {
        [Key]
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
