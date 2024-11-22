using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PIA_PROGRAMACIONWEB.Models.dbModels;

public partial class ProgramacionWebContext : IdentityDbContext<ApplicationUser,IdentityRole<int>,int>
{
    public ProgramacionWebContext()
    {
    }

    public ProgramacionWebContext(DbContextOptions<ProgramacionWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AsistenciaEnsayo> AsistenciaEnsayos { get; set; }

    public virtual DbSet<AsistenciaEvento> AsistenciaEventos { get; set; }

    public virtual DbSet<Audicione> Audiciones { get; set; }

    public virtual DbSet<Carrusel> Carrusels { get; set; }

    public virtual DbSet<CatalogoSeccione> CatalogoSecciones { get; set; }

    public virtual DbSet<Contactano> Contactanos { get; set; }

    public virtual DbSet<Ensayo> Ensayos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<ReporteAsistenciaEvento> ReporteAsistenciaEventos { get; set; }

    public virtual DbSet<SeccionAcercaNosotrosYportafolio> SeccionAcercaNosotrosYportafolios { get; set; }

    public virtual DbSet<TipoEvento> TipoEventos { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AsistenciaEnsayo>(entity =>
        {
            entity.HasOne(d => d.IdEnsayoNavigation).WithMany(p => p.AsistenciaEnsayos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__IdEns__3E1D39E1");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AsistenciaEnsayos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__IdUsu__3F115E1A");
        });

        modelBuilder.Entity<AsistenciaEvento>(entity =>
        {
            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.AsistenciaEventos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__IdEve__3A4CA8FD");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.AsistenciaEventos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asistenci__IdUsu__3B40CD36");
        });





        modelBuilder.Entity<Audicione>(entity =>
        {
            entity.HasKey(e => e.IdAudicion).HasName("PK__Audicion__13AB881757467878");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Audiciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Audiciones_Usuario");
        });

        modelBuilder.Entity<Carrusel>(entity =>
        {
            entity.HasKey(e => e.IdImagen).HasName("PK__Carrusel__B42D8F2AFC5C7BA3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Carrusels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Carrusel_Usuario");
        });

        modelBuilder.Entity<CatalogoSeccione>(entity =>
        {
            entity.HasKey(e => e.IdCatalogo).HasName("PK__Catalogo__FD0AC26CA326B181");
        });

        modelBuilder.Entity<Contactano>(entity =>
        {
            entity.HasKey(e => e.IdContacto).HasName("PK__Contacta__A4D6BBFA80CAA33B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Contactanos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contactanos_Usuario");
        });

        modelBuilder.Entity<Ensayo>(entity =>
        {
            entity.HasKey(e => e.IdEnsayo).HasName("PK__Ensayos__56CD569CFE656BA0");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Eventos__034EFC0404815ECE");

            entity.HasOne(d => d.IdTipoEventoNavigation).WithMany(p => p.Eventos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Eventos_TipoEvento");
        });

        modelBuilder.Entity<ReporteAsistenciaEvento>(entity =>
        {
            entity.HasKey(e => e.IdReporte).HasName("PK__ReporteA__F9561136A76D2508");

            entity.Property(e => e.FechaReporte).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.ReporteAsistenciaEventos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ReporteAs__IdEve__51300E55");
        });

        modelBuilder.Entity<SeccionAcercaNosotrosYportafolio>(entity =>
        {
            entity.HasKey(e => e.IdSeccion).HasName("PK__SeccionA__CD2B049FE983C9D2");

            entity.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.SeccionAcercaNosotrosYportafolios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SeccionAc__IdCat__498EEC8D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SeccionAcercaNosotrosYportafolios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeccionAcercaNosotrosYPortafolio_Usuario");
        });

        modelBuilder.Entity<TipoEvento>(entity =>
        {
            entity.HasKey(e => e.IdTipoEvento).HasName("PK__TipoEven__CDB3A3BEB64D03F2");
        });





        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
