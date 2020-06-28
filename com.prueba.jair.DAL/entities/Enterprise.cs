using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.prueba.jair.DAL.entities
{
    [Table("Enterprises")]
    public class Enterprise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        public long Nit { get; set; }

        [Required(ErrorMessage = "El Gln es requerido")]
        public long Gln { get; set; }

        public virtual ICollection<Code> CodeList { get; set; }
    }
}
