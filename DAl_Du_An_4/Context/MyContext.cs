using System;
using System.Collections.Generic;
using DAl_Du_An_4.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAl_Du_An_4.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chitietsanpham> Chitietsanphams { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sizeaonam> Sizeaonams { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Theloai> Theloais { get; set; }

    public virtual DbSet<Xuatxu> Xuatxus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source==LAPTOP-00AEOH4E\\SQLEXPRES ;Initial Catalog= BAN_AO_NAM ;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chitietsanpham>(entity =>
        {
            entity.HasKey(e => e.Mactsp).HasName("PK__CHITIETS__F501C2F593DB2254");

            entity.HasOne(d => d.MamauNavigation).WithMany(p => p.Chitietsanphams).HasConstraintName("FK__CHITIETSA__MAMAU__5AEE82B9");

            entity.HasOne(d => d.MasizeNavigation).WithMany(p => p.Chitietsanphams).HasConstraintName("FK__CHITIETSA__MASIZ__5CD6CB2B");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Chitietsanphams).HasConstraintName("FK__CHITIETSAN__MASP__59063A47");

            entity.HasOne(d => d.MatlNavigation).WithMany(p => p.Chitietsanphams).HasConstraintName("FK__CHITIETSAN__MATL__59FA5E80");

            entity.HasOne(d => d.MaxxNavigation).WithMany(p => p.Chitietsanphams).HasConstraintName("FK__CHITIETSAN__MAXX__5BE2A6F2");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahd).HasName("PK__HOADON__603F20CE1B492EF7");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons).HasConstraintName("FK__HOADON__MANV__4CA06362");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.Mahdct).HasName("PK__HOADONCH__1A700082BAA238BD");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHIT__MAHD__534D60F1");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHIT__MAKH__5535A963");

            entity.HasOne(d => d.MakmNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHIT__MAKM__5629CD9C");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Hoadonchitiets).HasConstraintName("FK__HOADONCHIT__MASP__5441852A");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh).HasName("PK__KHACHHAN__603F592C00CA9E96");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.Makm).HasName("PK__KHUYENMA__603F592B6428B9D3");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamau).HasName("PK__MAUSAC__7B7346CF4A951FCD");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__NHANVIEN__603F5114D57804B0");

            entity.HasOne(d => d.MatkNavigation).WithMany(p => p.Nhanviens).HasConstraintName("FK__NHANVIEN__MATK__49C3F6B7");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__SANPHAM__60228A329CC526BE");
        });

        modelBuilder.Entity<Sizeaonam>(entity =>
        {
            entity.HasKey(e => e.Masize).HasName("PK__SIZEAONA__3DD4402B5A26B2B3");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Matk).HasName("PK__TAIKHOAN__60237216A84C9135");
        });

        modelBuilder.Entity<Theloai>(entity =>
        {
            entity.HasKey(e => e.Matl).HasName("PK__THELOAI__60237217FC19124C");
        });

        modelBuilder.Entity<Xuatxu>(entity =>
        {
            entity.HasKey(e => e.Maxx).HasName("PK__XUATXU__6022928E87B63331");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
