using apiPagos.Facturacion.Context;
using apiPagos.Facturacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiPagos.Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturacionController : ControllerBase
    {
        private readonly AppDbContext context;
        
        public FacturacionController(AppDbContext context)
        {
            this.context = context;
        }

        // POST api/<FacturacionController>
        [HttpPost]
        public ActionResult Post([FromBody] Factura factura)
        {
            try
            {
               
                context.factura.Add(factura);
               context.SaveChanges();
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
