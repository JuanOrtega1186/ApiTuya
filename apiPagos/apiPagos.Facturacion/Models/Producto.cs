using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPagos.Facturacion.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        public DateTime fecha_hora { get; set; }

    }
}
