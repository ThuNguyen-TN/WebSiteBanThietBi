using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteThietBiDienTu.Data;
using WebsiteThietBiDienTu.Models;

namespace WebsiteThietBiDienTu.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public void GetInfo()
        {
            ViewData["Sanpham"] = _context.Sanpham.Count();
            ViewData["Donhang"] = _context.Hoadon.Count();
            ViewData["Khachhang"] = _context.Khachhang.Count();
            ViewData["Doanhthu"] = _context.Hoadon.Sum(hd => hd.TongTien).ToString("n0").Replace(",", ".");
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.Nhanvien.Include(n => n.MaCvNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        private bool NhanvienExists(int id)
        {
            GetInfo();
            return _context.Nhanvien.Any(e => e.MaNv == id);
        }
        
        [HttpPost]
        public async Task<IActionResult> ThongKeHoaDon(DateTime Ngaybatdau, DateTime Ngayketthuc)
        {
            var lstHD = _context.Hoadon.Include(m => m.MaKhNavigation).Where(d => d.Ngay >= Ngaybatdau && d.Ngay <= Ngayketthuc && d.TrangThai.Equals("Đã giao hàng"));
            int tongtien = 0;
            foreach (Hoadon hd in lstHD)
            {
                tongtien += hd.TongTien;
            }
            ViewData["ngaybatdau"] = Ngaybatdau.Month.ToString() + "/" + Ngaybatdau.Day.ToString() + "/" + Ngaybatdau.Year.ToString();
            ViewData["ngayketthuc"] = Ngayketthuc.Month.ToString() + "/" + Ngayketthuc.Day.ToString() + "/" + Ngayketthuc.Year.ToString();
            ViewData["tongtien"] = tongtien.ToString("n0");
            GetInfo();
            return View(lstHD);
        }
        public async Task<IActionResult> ThongKe()
        {
            var applicationDbContext = _context.Hoadon.Include(h => h.MaDcNavigation).Include(h => h.MaKhNavigation);
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
