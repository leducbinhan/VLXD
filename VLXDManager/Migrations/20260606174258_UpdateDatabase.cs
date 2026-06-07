using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VLXDManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VatTu_DanhMucLoai_MaLoai",
                table: "VatTu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucLoai",
                table: "DanhMucLoai");

            migrationBuilder.RenameTable(
                name: "DanhMucLoai",
                newName: "DanhMucLoai");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaNhap",
                table: "VatTu",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaBan",
                table: "VatTu",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "DonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "DonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DaThanhToan",
                table: "DonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConLai",
                table: "DonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChietKhau",
                table: "DonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietNhapKho",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietNhapKho",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietDonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietDonHang",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucLoai",
                table: "DanhMucLoai",
                column: "MaLoai");

            migrationBuilder.CreateTable(
                name: "ThanhVien",
                columns: table => new
                {
                    MaTV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTVCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LuongCoBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhVien", x => x.MaTV);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_VatTu_DanhMucLoai_MaLoai",
                table: "VatTu",
                column: "MaLoai",
                principalTable: "DanhMucLoai",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VatTu_DanhMucLoai_MaLoai",
                table: "VatTu");

            migrationBuilder.DropTable(
                name: "ThanhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucLoai",
                table: "DanhMucLoai");

            migrationBuilder.RenameTable(
                name: "DanhMucLoai",
                newName: "DanhMucLoai");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaNhap",
                table: "VatTu",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiaBan",
                table: "VatTu",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TongTien",
                table: "DonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "DonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DaThanhToan",
                table: "DonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConLai",
                table: "DonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ChietKhau",
                table: "DonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietNhapKho",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietNhapKho",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietDonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DonGia",
                table: "ChiTietDonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucLoai",
                table: "DanhMucLoai",
                column: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_VatTu_DanhMucLoai_MaLoai",
                table: "VatTu",
                column: "MaLoai",
                principalTable: "DanhMucLoai",
                principalColumn: "MaLoai",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
