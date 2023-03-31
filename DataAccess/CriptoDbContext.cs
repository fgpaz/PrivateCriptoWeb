using Microsoft.EntityFrameworkCore;
using Models;
using Models.DAOs;

namespace DataAccess;

public class CriptoDbContext : DbContext
{
    public CriptoDbContext()
    {
    }

    public CriptoDbContext(DbContextOptions<CriptoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CriptoBase?> CriptoBases { get; set; } = null!;

    public virtual DbSet<ExchangeRateDAO?> ExchangeRates { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CriptoBaseDAO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CriptoBa__3214EC075201D7F0");

            entity.ToTable("CriptoBase");

            entity.Property(e => e.ComprarUsdt).HasColumnName("comprar_USDT");
            entity.Property(e => e.Exchange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exchange");
            entity.Property(e => e.Fecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecha");
            entity.Property(e => e.VenderUsdt).HasColumnName("vender_USDT");
        });

        modelBuilder.Entity<ExchangeRateDAO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exchange__3214EC07973E03A6");

            entity.Property(e => e.BeloId).HasColumnName("Belo_Id");
            entity.Property(e => e.BuenbitId).HasColumnName("Buenbit_Id");
            entity.Property(e => e.FiwindId).HasColumnName("Fiwind_Id");
            entity.Property(e => e.LemonId).HasColumnName("Lemon_Id");
            entity.Property(e => e.LetsbitId).HasColumnName("Letsbit_Id");

            entity.HasOne(d => d.Belo).WithMany(p => p.ExchangeRateBelos)
                .HasForeignKey(d => d.BeloId)
                .HasConstraintName("FK__ExchangeR__Belo___267ABA7A");

            entity.HasOne(d => d.Buenbit).WithMany(p => p.ExchangeRateBuenbits)
                .HasForeignKey(d => d.BuenbitId)
                .HasConstraintName("FK__ExchangeR__Buenb__2A4B4B5E");

            entity.HasOne(d => d.Fiwind).WithMany(p => p.ExchangeRateFiwinds)
                .HasForeignKey(d => d.FiwindId)
                .HasConstraintName("FK__ExchangeR__Fiwin__286302EC");

            entity.HasOne(d => d.Lemon).WithMany(p => p.ExchangeRateLemons)
                .HasForeignKey(d => d.LemonId)
                .HasConstraintName("FK__ExchangeR__Lemon__29572725");

            entity.HasOne(d => d.Letsbit).WithMany(p => p.ExchangeRateLetsbits)
                .HasForeignKey(d => d.LetsbitId)
                .HasConstraintName("FK__ExchangeR__Letsb__276EDEB3");
        });
    }
}