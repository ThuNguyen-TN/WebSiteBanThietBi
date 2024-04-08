using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteThietBiDienTu.Data;
using WebsiteThietBiDienTu.Models;

namespace WebsiteThietBiDienTu.Controllers
{
    public class TintucsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TintucsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tintucs
        public async Task<IActionResult> Index(string searchString)
        {
            return View(await _context.Tintuc.ToListAsync());
            //var data = from p in _context.Tintuc.FirstOrDefault(p => p.MaTin)
            //           select p;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    data = data.Where(p => p.TieuDe.Contains(searchString));
            //}

            //return View(data);
        }

        // GET: Tintucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tintuc = await _context.Tintuc
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tintuc == null)
            {
                return NotFound();
            }

            return View(tintuc);
        }

        // GET: Tintucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tintucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTin,TieuDe,TomTat,NoiDung,HinhAnh,NgayDang")] Tintuc tintuc, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                tintuc.HinhAnh = Upload(file);
                _context.Add(tintuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tintuc);
        }

        // GET: Tintucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tintuc = await _context.Tintuc.FindAsync(id);
            if (tintuc == null)
            {
                return NotFound();
            }
            return View(tintuc);
        }

        // POST: Tintucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile file,[Bind("MaTin,TieuDe,TomTat,NoiDung,HinhAnh,NgayDang")] Tintuc tintuc)
        {
            if (id != tintuc.MaTin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        tintuc.HinhAnh = Upload(file);
                    }
                    _context.Update(tintuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TintucExists(tintuc.MaTin))
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
            return View(tintuc);
        }

        // GET: Tintucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tintuc = await _context.Tintuc
                .FirstOrDefaultAsync(m => m.MaTin == id);
            if (tintuc == null)
            {
                return NotFound();
            }

            return View(tintuc);
        }

        // POST: Tintucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tintuc = await _context.Tintuc.FindAsync(id);
            _context.Tintuc.Remove(tintuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TintucExists(int id)
        {
            return _context.Tintuc.Any(e => e.MaTin == id);
        }

        public string Upload(IFormFile file)
        {
            string uploadFileName = null;
            if (file != null)
            {
                // phát sinh tên file mới: chuỗi ngẫu nhiên_tên ảnh
                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // chép file về thư mục lưu trữ ảnh
                var path = $"wwwroot\\images\\news\\{uploadFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            }
            return uploadFileName; // trả về tên file
        }
    }
}
