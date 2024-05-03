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
       
    }
}
