using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace com.prueba.jair.DAL.entities
{
    public class Enterprise
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        public long Nit { get; set; }

        [Required(ErrorMessage = "El Gln es requerido")]
        public decimal Gln { get; set; }

        public virtual ICollection<Code> CodeList { get; set; }
    }
}
