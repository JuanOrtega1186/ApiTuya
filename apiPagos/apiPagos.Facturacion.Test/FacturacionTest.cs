using apiPagos.Facturacion.Context;
using apiPagos.Facturacion.Controllers;
using apiPagos.Facturacion.Models;
using apiPagos.Facturacion.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace apiPagos.Facturacion.Test
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
            // Arrange

            //var options = new DbContextOptionsBuilder<AppDbContext>()
            //.UseInMemoryDatabase(databaseName: "PagosSimulator")
            //.Options;

            //Moq.Mock<IFacturaServicio> facturaServicioMock = new Moq.Mock<IFacturaServicio>();
            //using (var context = new AppDbContext(options))
            //{
            //    TransferenciaController transferenciaController = new TransferenciaController(context, facturaServicioMock.Object);
            //    ResumentPuntos resumentPuntos = new ResumentPuntos();
            //    resumentPuntos.id = 1;
            //    facturaServicioMock.Setup(c => c.ProcesarFactura(It.IsAny<Factura>())).Returns(Task.FromResult(resumentPuntos));

            //    // Action
            //    var result = transferenciaController.Post(new Transferencia());

            //    // Assert
            //    var createdAtRoute = result as CreatedAtRouteResult;
            //    Assert.IsNotNull(createdAtRoute);
            //}
        }
    }
}