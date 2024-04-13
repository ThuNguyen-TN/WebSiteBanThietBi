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
    public class HoadonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoadonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hoadons
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Hoadon.Include(h => h.MaDcNavigation).Include(h => h.MaKhNavigation);
            return View(await applicationDbContext.ToListAsync());

        }

        // GET: Hoadons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .Include(h => h.MaDcNavigation)
                .Include(h => h.MaKhNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoadon == null)
            {
                return NotFound();
            }
            //ViewBag.cthd =await _context.Cthoadon.Where(cthd => cthd.MaHdNavigation.MaHd == id).Include(hd => hd.MaHdNavigation).Include(mh => mh.MaMhNavigation).Include(kh => kh.MaHdNavigation.MaKhNavigation).FirstOrDefaultAsync();
            ViewBag.cthd = await _context.Cthoadon
                            .Where(cthd => cthd.MaHdNavigation.MaHd == id)
                            .Include(hd => hd.MaHdNavigation)
                            .Include(mh => mh.MaMhNavigation)
                            .Include(kh => kh.MaHdNavigation.MaKhNavigation)
                            .ToListAsync();
            return View(hoadon);
        }

        // GET: Hoadons/Create
        public IActionResult Create()
        {
            ViewData["MaDc"] = new SelectList(_context.Set<Diachi>(), "MaDc", "DiaChi1");
            ViewData["MaKh"] = new SelectList(_context.Khachhang, "MaKh", "Ten");
            return View();
        }

        // POST: Hoadons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHd,Ngay,TongTien,MaKh,MaDc,TrangThai")] Hoadon hoadon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoadon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDc"] = new SelectList(_context.Set<Diachi>(), "MaDc", "DiaChi1", hoadon.MaDc);
            ViewData["MaKh"] = new SelectList(_context.Khachhang, "MaKh", "Ten", hoadon.MaKh);
            return View(hoadon);
        }

        // GET: Hoadons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            ViewData["MaDc"] = new SelectList(_context.Set<Diachi>(), "MaDc", "DiaChi1", hoadon.MaDc);
            ViewData["MaKh"] = new SelectList(_context.Khachhang, "MaKh", "Ten", hoadon.MaKh);
            return View(hoadon);
        }

        // POST: Hoadons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHd,Ngay,TongTien,MaKh,MaDc,TrangThai")] Hoadon hoadon)
        {
            if (id != hoadon.MaHd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoadon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoadonExists(hoadon.MaHd))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDc"] = new SelectList(_context.Set<Diachi>(), "MaDc", "DiaChi1", hoadon.MaDc);
            ViewData["MaKh"] = new SelectList(_context.Khachhang, "MaKh", "Ten", hoadon.MaKh);
            return View(hoadon);
        }

        // GET: Hoadons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = await _context.Hoadon
                .Include(h => h.MaDcNavigation)
                .Include(h => h.MaKhNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoadon == null)
            {
                return NotFound();
            }

            return View(hoadon);
        }

        // POST: Hoadons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoadon = await _context.Hoadon.FindAsync(id);
            _context.Hoadon.Remove(hoadon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoadonExists(int id)
        {
            return _context.Hoadon.Any(e => e.MaHd == id);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string newStatus)
        {
            //1: cho xac nha
            //2: dang chuan bi hang
            //3: dang giao
            var order = _context.Hoadon.FirstOrDefault(o => o.MaHd == id);
            if (order != null)
            {
                order.TrangThai = newStatus;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
