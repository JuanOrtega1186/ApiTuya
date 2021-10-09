using apiPagos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace apiPagos.Servicios
{
    public class PedidoServicio: IPedidoServicio
    {
        public async Task ProcesarPedido(Pedido pedido)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(String.Format("https://{0}", "localhost:44321"));
                httpClient.DefaultRequestHeaders.Accept.Clear();
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(pedido), Encoding.UTF8);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await httpClient.PostAsync("/api/Logistica", httpContent);
            }
       
        }
    }
}
