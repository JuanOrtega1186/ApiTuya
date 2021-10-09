using apiPagos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace apiPagos.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }


        public virtual DbSet<Transferencia> transferencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Transferencia>(entity =>
            {
                entity.HasKey(e => e.id).HasName("PK_Transferencia");

                entity.ToTable("transferencia");

                entity.Property(e => e.cuentaOrigen)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.comision).IsRequired();
                entity.Property(e => e.valor).IsRequired();

                entity.Property(e => e.cuentaDestino)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.fecha_hora).HasColumnType("datetime").IsRequired();

            });

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
