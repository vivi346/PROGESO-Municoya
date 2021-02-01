using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROGESO.Models
{
    public class EncDepartamento
    {
        [Key]

        public int Id { get; set; }

        [Required]

        [Display(Name = "Correo")]
        [EmailAddress(ErrorMessage = "Dirección de correo invalida")]
        public string Correo { get; set; }

        [Required]

        [Display(Name = "Nombre")]

        public string Nombre { get; set; }

        [Required]

        [Display(Name = "Apellido1")]

        public string Apellido1 { get; set; }

        [Required]

        [Display(Name = "Apellido2")]

        public string Apellido2 { get; set; }


        [Required]

        [Display(Name = "Nombre Departamento")]

        public int DepartamentID { get; set; }

        [ForeignKey("DepartamentID")]

        public virtual Departament Departament { get; set; }

    }
}
