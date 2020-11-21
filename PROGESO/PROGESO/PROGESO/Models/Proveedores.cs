using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROGESO.Models
{
    public class Proveedores
    {

        [Key]
        public int ced_juridica { get; set; }
        [Required]
   
        public string nombre { get; set; }

    }
}
