using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROGESO.Models
{
    public class ProductoProveedor
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("ced_juridica")]
        public virtual Proveedores Proveedores { get; set; }
        [Display(Name = "Ced_Juridica")]
        public int ced_juridica { get; set; }

        [ForeignKey("cod_prod")]
        public virtual Producto Producto { get; set; }
        [Display(Name = "Cod_Prod")]
        public int cod_prod { get; set; }

        [Required]
        [Display(Name = "Precio del Producto")]
        public float precio { get; set; }

        [Required]
        [Display(Name = "Cantidad del Producto")]
        public int cantidad { get; set; }

        [Display(Name = "Fecha Compra")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCompra { get; set; }

    }
}
