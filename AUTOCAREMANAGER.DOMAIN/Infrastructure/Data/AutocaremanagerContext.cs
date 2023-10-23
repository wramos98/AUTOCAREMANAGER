using System;
using System.Collections.Generic;
using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AUTOCAREMANAGER.DOMAIN.Infrastructure.Data;

public partial class AutocaremanagerContext : DbContext
{
    public AutocaremanagerContext()
    {
    }

    public AutocaremanagerContext(DbContextOptions<AutocaremanagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbActServicio> TbActServicio { get; set; }

    public virtual DbSet<TbArticulo> TbArticulo { get; set; }

    public virtual DbSet<TbArticuloTaller> TbArticuloTaller { get; set; }

    public virtual DbSet<TbEmpleado> TbEmpleado { get; set; }

    public virtual DbSet<TbFactVentaCab> TbFactVentaCab { get; set; }

    public virtual DbSet<TbFactVentaDet> TbFactVentaDet { get; set; }

    public virtual DbSet<TbSocioDeNegocio> TbSocioDeNegocio { get; set; }

    public virtual DbSet<TbTaller> TbTaller { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    public virtual DbSet<TbVehiculo> TbVehiculo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ACERNITRO5;Database=AUTOCAREMANAGER;integrated security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbActServicio>(entity =>
        {
            entity.HasKey(e => e.ActId).HasName("PK__tb_actSe__AF1624FC531B860E");

            entity.ToTable("tb_actServicio");

            entity.Property(e => e.ActId).HasColumnName("ActID");
            entity.Property(e => e.DetalleReparacion).HasMaxLength(254);
            entity.Property(e => e.Estado).HasMaxLength(7);
            entity.Property(e => e.FecFin).HasColumnType("datetime");
            entity.Property(e => e.FecInicio).HasColumnType("datetime");

            entity.HasOne(d => d.CodVehiculoNavigation).WithMany(p => p.TbActServicio)
                .HasForeignKey(d => d.CodVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_actSer__CodVe__49C3F6B7");
        });

        modelBuilder.Entity<TbArticulo>(entity =>
        {
            entity.HasKey(e => e.CodArticulo).HasName("PK__tb_artic__BEC608375646CE78");

            entity.ToTable("tb_articulo");

            entity.Property(e => e.ArtInventariable).HasMaxLength(1);
            entity.Property(e => e.DesArticulo).HasMaxLength(254);
            entity.Property(e => e.Estado).HasMaxLength(1);
            entity.Property(e => e.Fabricante).HasMaxLength(254);
            entity.Property(e => e.ImpVenta).HasMaxLength(8);
            entity.Property(e => e.TipoServicio).HasMaxLength(1);
            entity.Property(e => e.UnidadMedida).HasMaxLength(40);
        });

        modelBuilder.Entity<TbArticuloTaller>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_articulo_taller");

            entity.HasOne(d => d.CodArticuloNavigation).WithMany()
                .HasForeignKey(d => d.CodArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_articu__CodAr__403A8C7D");

            entity.HasOne(d => d.CodTallerNavigation).WithMany()
                .HasForeignKey(d => d.CodTaller)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_articu__CodTa__412EB0B6");
        });

        modelBuilder.Entity<TbEmpleado>(entity =>
        {
            entity.HasKey(e => e.CodEmpleado).HasName("PK__tb_emple__35FE54AB6DFEE486");

            entity.ToTable("tb_empleado");

            entity.Property(e => e.Apellidos).HasMaxLength(100);
            entity.Property(e => e.Cargo).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(1);
            entity.Property(e => e.Nombres).HasMaxLength(100);
            entity.Property(e => e.NumIdent).HasMaxLength(32);
            entity.Property(e => e.UserCode).HasColumnName("USER_CODE");

            entity.HasOne(d => d.CodTallerNavigation).WithMany(p => p.TbEmpleado)
                .HasForeignKey(d => d.CodTaller)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_emplea__CodTa__3C69FB99");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.TbEmpleado)
                .HasForeignKey(d => d.UserCode)
                .HasConstraintName("FK__tb_emplea__USER___3B75D760");
        });

        modelBuilder.Entity<TbFactVentaCab>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("PK__tb_factV__3EF1888D340D271B");

            entity.ToTable("tb_factVenta_cab");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.ActId).HasColumnName("ActID");
            entity.Property(e => e.CodSn).HasColumnName("CodSN");
            entity.Property(e => e.Comentarios).HasMaxLength(254);
            entity.Property(e => e.CondicionPago).HasMaxLength(100);
            entity.Property(e => e.DocTotal).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.FecDocumento).HasColumnType("datetime");
            entity.Property(e => e.FecVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Moneda).HasMaxLength(3);
            entity.Property(e => e.NumCorrelativo).HasMaxLength(8);
            entity.Property(e => e.NumSerieFiscal).HasMaxLength(4);
            entity.Property(e => e.ProxFecMant).HasColumnType("datetime");

            entity.HasOne(d => d.Act).WithMany(p => p.TbFactVentaCab)
                .HasForeignKey(d => d.ActId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_factVe__ActID__4E88ABD4");

            entity.HasOne(d => d.CodEmpleadoNavigation).WithMany(p => p.TbFactVentaCab)
                .HasForeignKey(d => d.CodEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_factVe__CodEm__4CA06362");

            entity.HasOne(d => d.CodSnNavigation).WithMany(p => p.TbFactVentaCab)
                .HasForeignKey(d => d.CodSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_factVe__CodSN__4D94879B");
        });

        modelBuilder.Entity<TbFactVentaDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_factVenta_det");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.Precio).HasColumnType("numeric(19, 6)");
            entity.Property(e => e.Subtotal).HasColumnType("numeric(19, 6)");

            entity.HasOne(d => d.CodArticuloNavigation).WithMany()
                .HasForeignKey(d => d.CodArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_factVe__CodAr__5165187F");

            entity.HasOne(d => d.Doc).WithMany()
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_factVe__DocID__5070F446");
        });

        modelBuilder.Entity<TbSocioDeNegocio>(entity =>
        {
            entity.HasKey(e => e.CodSn).HasName("PK__tb_socio__F4162117215C2CB0");

            entity.ToTable("tb_socio_de_negocio");

            entity.Property(e => e.CodSn).HasColumnName("CodSN");
            entity.Property(e => e.Direccion).HasMaxLength(254);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Estado).HasMaxLength(1);
            entity.Property(e => e.NumIdent).HasMaxLength(32);
            entity.Property(e => e.PersonaContacto).HasMaxLength(100);
            entity.Property(e => e.RazonSocial).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(32);
            entity.Property(e => e.UserCode).HasColumnName("USER_CODE");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.TbSocioDeNegocio)
                .HasForeignKey(d => d.UserCode)
                .HasConstraintName("FK__tb_socio___USER___440B1D61");
        });

        modelBuilder.Entity<TbTaller>(entity =>
        {
            entity.HasKey(e => e.CodTaller).HasName("PK__tb_talle__BCCE6CE47AD27100");

            entity.ToTable("tb_taller");

            entity.Property(e => e.Ciudad).HasMaxLength(254);
            entity.Property(e => e.DesTaller).HasMaxLength(200);
            entity.Property(e => e.Direccion).HasMaxLength(254);
            entity.Property(e => e.País).HasMaxLength(254);
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.UserCode).HasName("PK__tb_usuar__A039F1EF70A39452");

            entity.ToTable("tb_usuario");

            entity.Property(e => e.UserCode).HasColumnName("USER_CODE");
            entity.Property(e => e.Apellidos).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirmaUsuario).HasMaxLength(100);
            entity.Property(e => e.Nombres).HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(254)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.TipoUsuario).HasMaxLength(1);
        });

        modelBuilder.Entity<TbVehiculo>(entity =>
        {
            entity.HasKey(e => e.CodVehiculo).HasName("PK__tb_vehic__75D37F6C74267688");

            entity.ToTable("tb_vehiculo");

            entity.Property(e => e.Año).HasMaxLength(4);
            entity.Property(e => e.CodSn).HasColumnName("CodSN");
            entity.Property(e => e.FecUltMant).HasColumnType("datetime");
            entity.Property(e => e.Marca).HasMaxLength(32);
            entity.Property(e => e.Modelo).HasMaxLength(100);
            entity.Property(e => e.Placa).HasMaxLength(7);

            entity.HasOne(d => d.CodSnNavigation).WithMany(p => p.TbVehiculo)
                .HasForeignKey(d => d.CodSn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_vehicu__CodSN__46E78A0C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
