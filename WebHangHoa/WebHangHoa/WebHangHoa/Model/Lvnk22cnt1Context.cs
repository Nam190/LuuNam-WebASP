using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebHangHoa.Model;

public partial class Lvnk22cnt1Context : DbContext
{
    public Lvnk22cnt1Context()
    {
    }

    public Lvnk22cnt1Context(DbContextOptions<Lvnk22cnt1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LUUNAM\\SQLEXPRESS01;Database=lvnk22cnt1;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__CHI_TIET__D3B9D30C65CBCDB4");

            entity.ToTable("CHI_TIET_DON_HANG");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SoLuong).HasColumnName("So_luong");

            entity.HasOne(d => d.Order).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__CHI_TIET___Order__2E1BDC42");

            entity.HasOne(d => d.Product).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CHI_TIET___Produ__2F10007B");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__DON_HANG__C3905BAFE5534A76");

            entity.ToTable("DON_HANG");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.NgayDatHang)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_dat_hang");
            entity.Property(e => e.TongGia)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Tong_gia");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_thai");

            entity.HasOne(d => d.Customer).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__DON_HANG__Custom__29572725");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__KHACH_HA__A4AE64B8CEB5B938");

            entity.ToTable("KHACH_HANG");

            entity.HasIndex(e => e.TaiKhoan, "UQ__KHACH_HA__52AE88F56CEA4973").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(200)
                .HasColumnName("Dia_chi");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Dien_thoai");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh).HasColumnName("Gioi_tinh");
            entity.Property(e => e.HoTen)
                .HasMaxLength(100)
                .HasColumnName("Ho_ten");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Mat_khau");
            entity.Property(e => e.NgayCapNhat)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_cap_nhat");
            entity.Property(e => e.NgaySinh)
                .HasColumnType("datetime")
                .HasColumnName("Ngay_sinh");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tai_khoan");
            entity.Property(e => e.TichDiem).HasColumnName("Tich_diem");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_thai");
        });

        modelBuilder.Entity<QuanTri>(entity =>
        {
            entity.HasKey(e => e.TaiKhoan).HasName("PK__QUAN_TRI__52AE88F41212F778");

            entity.ToTable("QUAN_TRI");

            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tai_khoan");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Mat_khau");
            entity.Property(e => e.TrangThai).HasColumnName("Trang_thai");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__SAN_PHAM__B40CC6EDEF9D8A09");

            entity.ToTable("SAN_PHAM");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Anh)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MoTa)
                .HasMaxLength(150)
                .HasColumnName("Mo_ta");
            entity.Property(e => e.SoLuongTonKho).HasColumnName("So_luong_ton_kho");
            entity.Property(e => e.TenSanPham)
                .HasMaxLength(100)
                .HasColumnName("Ten_san_pham");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
