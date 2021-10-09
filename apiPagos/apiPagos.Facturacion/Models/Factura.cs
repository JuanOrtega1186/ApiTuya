using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPagos.Facturacion.Models
{
    public class Factura
    {
        [Key]
        public int id { get; set; }

        public string nombre { get; set; }

        public decimal valor { get; set; }

        public DateTime fecha_realizacion { get; set; }

    }
}
