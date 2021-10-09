using apiPagos.Facturacion.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace apiPagos.Facturacion.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }


        public virtual DbSet<Factura> factura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

     

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
