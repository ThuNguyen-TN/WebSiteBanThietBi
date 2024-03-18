using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebsiteThietBiDienTu.Models;

namespace WebsiteThietBiDienTu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebsiteThietBiDienTu.Models.Sanpham> Sanpham { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Khachhang> Khachhang { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Danhmuc> Danhmuc { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Hoadon> Hoadon { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Cthoadon> Cthoadon { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Nhanvien> Nhanvien { get; set; }
        public DbSet<WebsiteThietBiDienTu.Models.Diachi> Diachi { get; set; }
    }
}
