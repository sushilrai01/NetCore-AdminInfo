using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NetCoreAdminInfo.Entity;

public partial class DriverManagementContext : DbContext
{
    public DriverManagementContext()
    {
    }

    public DriverManagementContext(DbContextOptions<DriverManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivityTable> ActivityTables { get; set; }

    public virtual DbSet<AdminDetail> AdminDetails { get; set; }

    public virtual DbSet<DriverTable> DriverTables { get; set; }

    public virtual DbSet<GenderTable> GenderTables { get; set; }

    public virtual DbSet<HobbyTable> HobbyTables { get; set; }

    public virtual DbSet<MapDocAdmin> MapDocAdmins { get; set; }

    public virtual DbSet<MapDriverHob> MapDriverHobs { get; set; }

    public virtual DbSet<MapImgDriver> MapImgDrivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IDK5662;Database=DriverManagement;user=sa;password=1234;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivityTable>(entity =>
        {
            entity.HasKey(e => e.IsActive);

            entity.ToTable("ActivityTable");

            entity.Property(e => e.Available)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<AdminDetail>(entity =>
        {
            entity.HasKey(e => e.AdminId);

            entity.ToTable("AdminDetail");

            entity.Property(e => e.Hobby).IsUnicode(false);
            entity.Property(e => e.ImagePath).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DriverTable>(entity =>
        {
            entity.HasKey(e => e.DriverId);

            entity.ToTable("DriverTable");

            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocFilePath).IsUnicode(false);
            entity.Property(e => e.Hobby).IsUnicode(false);
            entity.Property(e => e.ImageFilePath).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Gender).WithMany(p => p.DriverTables)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_DriverTable_GenderTable");

            entity.HasOne(d => d.IsActiveNavigation).WithMany(p => p.DriverTables)
                .HasForeignKey(d => d.IsActive)
                .HasConstraintName("FK_DriverTable_ActivityTable");
        });

        modelBuilder.Entity<GenderTable>(entity =>
        {
            entity.HasKey(e => e.GenderId);

            entity.ToTable("GenderTable");

            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HobbyTable>(entity =>
        {
            entity.HasKey(e => e.HobbyId);

            entity.ToTable("HobbyTable");

            entity.Property(e => e.Hobby)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MapDocAdmin>(entity =>
        {
            entity.HasKey(e => e.MapId);

            entity.ToTable("MapDocAdmin");

            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
        });

        modelBuilder.Entity<MapDriverHob>(entity =>
        {
            entity.HasKey(e => e.MapId);

            entity.ToTable("MapDriverHob");
        });

        modelBuilder.Entity<MapImgDriver>(entity =>
        {
            entity.HasKey(e => e.ImageId);

            entity.ToTable("MapImgDriver");

            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Filepath).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
