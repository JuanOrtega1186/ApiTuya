using apiPagos.Logistica.Context;
using apiPagos.Logistica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiPagos.Logistica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticaController : ControllerBase
    {
        private readonly AppDbContext context;

        public LogisticaController(AppDbContext context)
        {
            this.context = context;
        }


        // POST api/<LogisticaController>
        [HttpPost]
        public ActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
               context.pedido.Add(pedido);
               context.SaveChanges();
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
