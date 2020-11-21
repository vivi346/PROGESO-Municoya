using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROGESO.Models
{
    public class Producto
    {

        [Key]

        [Display(Name = "cod del Producto")]
        public int cod_prod { get; set; }

        [Required]
        [Display(Name = "Descripcion del Producto")]
        public string descripcion { get; set; }
    }
}
