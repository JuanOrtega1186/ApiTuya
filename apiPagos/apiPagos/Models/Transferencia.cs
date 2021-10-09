using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPagos.Models
{
    public class Transferencia
    {
        [Key]
        public int id { get; set; }

        public string cuentaOrigen { get; set; }

        public string cuentaDestino { get; set; }

        public decimal valor { get; set; }

        public decimal comision { get; set; }

        public DateTime fecha_hora { get; set; }

    }
}
