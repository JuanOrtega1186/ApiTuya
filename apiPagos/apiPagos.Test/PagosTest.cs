using apiPagos.Context;
using apiPagos.Controllers;
using apiPagos.Models;
using apiPagos.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace apiPagos.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPostReturns_OK()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                  .UseInMemoryDatabase(databaseName: "PagosSimulator")
                  .Options;

            Moq.Mock<IFacturaServicio> facturaServicioMock = new Moq.Mock<IFacturaServicio>();
            Moq.Mock<IPedidoServicio> pedidoServicioMock = new Moq.Mock<IPedidoServicio>();
            using (var context = new AppDbContext(options))
            {
                TransferenciaController transferenciaController = new TransferenciaController(context, facturaServicioMock.Object, pedidoServicioMock.Object);
               
                facturaServicioMock.Setup(c => c.ProcesarFactura(It.IsAny<Factura>()));
                pedidoServicioMock.Setup(c => c.ProcesarPedido(It.IsAny<Pedido>()));

                // Action
                var result = transferenciaController.Post(new Transferencia());

                // Assert
                var createdAtRoute = result as CreatedAtRouteResult;
                Assert.IsNotNull(createdAtRoute);
            }
        }
    }
}