using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfKutyakUniqueEF.mvvm.models;

public partial class KutyakGoodUniqueContext : DbContext
{
    public KutyakGoodUniqueContext()
    {
    }

    public KutyakGoodUniqueContext(DbContextOptions<KutyakGoodUniqueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kutya> Kutyas { get; set; }

    public virtual DbSet<Kutyafajtak> Kutyafajtaks { get; set; }

    public virtual DbSet<Kutyanevek> Kutyaneveks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlite("Data Source=d:\\database\\kutyak\\kutyak_good_unique.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kutya>(entity =>
        {
            entity.ToTable("kutya");

            entity.Property(e => e.Eletkor).HasColumnName("eletkor");
            entity.Property(e => e.Fajtaid).HasColumnName("fajtaid");
            entity.Property(e => e.Nevid).HasColumnName("nevid");
            entity.Property(e => e.Utolsoell)
                .HasColumnType("STRING")
                .HasColumnName("utolsoell");

            entity.HasOne(d => d.Fajta).WithMany(p => p.Kutyas)
                .HasForeignKey(d => d.Fajtaid)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Nev).WithMany(p => p.Kutyas)
                .HasForeignKey(d => d.Nevid)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Kutyafajtak>(entity =>
        {
            entity.ToTable("kutyafajtak");

            entity.HasIndex(e => e.Eredetinev, "IX_kutyafajtak_eredetinev").IsUnique();

            entity.HasIndex(e => e.Nev, "IX_kutyafajtak_nev").IsUnique();

            entity.Property(e => e.Eredetinev)
                .HasColumnType("VARCHAR")
                .HasColumnName("eredetinev");
            entity.Property(e => e.Nev)
                .HasColumnType("VARCHAR")
                .HasColumnName("nev");
        });

        modelBuilder.Entity<Kutyanevek>(entity =>
        {
            entity.ToTable("kutyanevek");

            entity.HasIndex(e => e.Kutyanev, "IX_kutyanevek_kutyanev").IsUnique();

            entity.Property(e => e.Kutyanev)
                .HasColumnType("VARCHAR")
                .HasColumnName("kutyanev");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
