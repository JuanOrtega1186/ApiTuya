using apiPagos.Context;
using apiPagos.Models;
using apiPagos.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiPagos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly IFacturaServicio facturaServicio;
        private readonly IPedidoServicio pedidoServicio;


        // Inyectar 2 dependencias "base de datos + Negocio"
        public TransferenciaController(AppDbContext context, IFacturaServicio facturaServicio, IPedidoServicio pedidoServicio)
        {
            this.context = context;
            this.facturaServicio = facturaServicio;
            this.pedidoServicio = pedidoServicio;
        }


        // GET: api/<TransferenciaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                
                return Ok(context.transferencia.ToList());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<TransferenciaController>/5
        [HttpGet("{id}",Name = "GetTransferencia")]
        public ActionResult Get(int id)
        {
            try
            {
                var tranferencia = context.transferencia.FirstOrDefault(f => f.id == id);
                return Ok(tranferencia);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<TransferenciaController>
        [HttpPost]
        public ActionResult Post([FromBody] Transferencia transferencia)
        {
            try
            {
               context.transferencia.Add(transferencia);
               context.SaveChanges();
               var facturaResponse = facturaServicio.ProcesarFactura(new Factura() { id = transferencia.id, fecha_realizacion = transferencia.fecha_hora});
                pedidoServicio.ProcesarPedido(new Pedido() { direccion = "roberto gomez bolaños", fecha_entrega = DateTime.Now, nombre = "robert" });
                return CreatedAtRoute("GetTransferencia", new { id = transferencia.id }, transferencia);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<TransferenciaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Transferencia transferencia)
        {
            try
            {
               if (transferencia.id == id) 
                {
                    context.Entry(transferencia).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetTransferencia", new { id = transferencia.id }, transferencia);
                }
                else 
                {
                    return BadRequest();
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<TransferenciaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
               var tranferencia = context.transferencia.FirstOrDefault(f => f.id == id);
                if(tranferencia != null)
                {
                    context.transferencia.Remove(tranferencia);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
