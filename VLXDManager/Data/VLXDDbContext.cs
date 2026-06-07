using Microsoft.EntityFrameworkCore;
using VLXDManager.Models;

namespace VLXDManager.Data
{
    public class VLXDDbContext : DbContext
    {
        public VLXDDbContext(DbContextOptions<VLXDDbContext> options) : base(options) { }

        public DbSet<ThanhVien> ThanhVien { get; set; }
        public DbSet<DanhMucLoai> DanhMucLoai { get; set; }
        public DbSet<VatTu> VatTu { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public DbSet<NhapKho> NhapKho { get; set; }
        public DbSet<ChiTietNhapKho> ChiTietNhapKho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapping tên bảng
            modelBuilder.Entity<ThanhVien>().ToTable("ThanhVien");
            modelBuilder.Entity<DanhMucLoai>().ToTable("DanhMucLoai");
            modelBuilder.Entity<VatTu>().ToTable("VatTu");
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
            modelBuilder.Entity<DonHang>().ToTable("DonHang");
            modelBuilder.Entity<ChiTietDonHang>().ToTable("ChiTietDonHang");
            modelBuilder.Entity<NhapKho>().ToTable("NhapKho");
            modelBuilder.Entity<ChiTietNhapKho>().ToTable("ChiTietNhapKho");

            // VatTu config
            modelBuilder.Entity<VatTu>(entity =>
            {
                entity.HasIndex(e => e.MaHang).IsUnique();
                entity.Property(e => e.GiaNhap).HasColumnType("decimal(12,2)");
                entity.Property(e => e.GiaBan).HasColumnType("decimal(12,2)");
            });

            // KhachHang config
            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.MaKHCode).IsUnique();
            });

            // DonHang config
            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasIndex(e => e.SoDH).IsUnique();
                entity.Property(e => e.TongTien).HasColumnType("decimal(12,2)");
                entity.Property(e => e.ChietKhau).HasColumnType("decimal(12,2)");
                entity.Property(e => e.ThanhTien).HasColumnType("decimal(12,2)");
                entity.Property(e => e.DaThanhToan).HasColumnType("decimal(12,2)");
                entity.Property(e => e.ConLai).HasColumnType("decimal(12,2)");

                entity.HasOne(d => d.KhachHang)
                    .WithMany(k => k.DonHang)
                    .HasForeignKey(d => d.MaKH)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            // ChiTietDonHang config
            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.Property(e => e.DonGia).HasColumnType("decimal(12,2)");
                entity.Property(e => e.ThanhTien).HasColumnType("decimal(12,2)");
            });

            // ChiTietNhapKho config
            modelBuilder.Entity<ChiTietNhapKho>(entity =>
            {
                entity.Property(e => e.DonGia).HasColumnType("decimal(12,2)");
                entity.Property(e => e.ThanhTien).HasColumnType("decimal(12,2)");
            });
        }
    }
}