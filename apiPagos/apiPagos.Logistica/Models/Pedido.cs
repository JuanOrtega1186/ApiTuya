using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPagos.Logistica.Models
{
    public class Pedido
    {
        [Key]
        public int id { get; set; }

        public string direccion { get; set; }

        public string nombre { get; set; }

        public DateTime fecha_entrega { get; set; }
    }
}
