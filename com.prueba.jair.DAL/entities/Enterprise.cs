using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace com.prueba.jair.DAL.entities
{
    public class Enterprise
    {
        public Enterprise ()
        {
            this.CodeList = new HashSet<Code>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        public decimal Nit { get; set; }

        [Required(ErrorMessage = "El Gln es requerido")]
        public decimal Gln { get; set; }

        public virtual ICollection<Code> CodeList { get; set; }
    }
}
