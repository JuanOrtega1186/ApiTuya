using apiPagos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPagos.Servicios
{
    public interface IPedidoServicio
    {

        Task ProcesarPedido(Pedido pedido);
    }
}
