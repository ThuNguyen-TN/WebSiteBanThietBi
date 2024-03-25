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

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Nhanvien.Include(n => n.MaCvNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        private bool NhanvienExists(int id)
        {
            return _context.Nhanvien.Any(e => e.MaNv == id);
        }
    }
}
