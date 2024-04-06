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
    public class SanphamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SanphamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sanphams
        public async Task<IActionResult> Index(int pg=1,string sortOrder="",string searchString="")
        {

            //var applicationDbContext = _context.Sanpham.Include(s => s.MaDmNavigation);


            //return View(await applicationDbContext.ToArrayAsync());

            //var query = _context.Sanpham.Include(s => s.MaDmNavigation);

            //const int pageSize = 8;
            //if (pg < 1)
            //    pg = 1;

            //var pager = new Pager(query.Count(), pg, pageSize);
            //int recSkip = (pg - 1) * pageSize;
            //var data = await query.Skip(recSkip).Take(pager.PageSize).ToListAsync();

            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["GiaSortParm"] = sortOrder == "Gia" ? "gia_desc" : "Gia";
            ViewData["QuantitySortParm"] = sortOrder == "SoLuong" ? "soluong_desc" : "SoLuong";
            var data = from p in _context.Sanpham.Include(p => p.MaDmNavigation)
                       select p;

            //const int pageSize = 8;
            //if (pg < 1)
            //    pg = 1;

            //var pager = new Pager(data.Count(), pg, pageSize);
            //int recSkip = (pg - 1) * pageSize;
            if (!String.IsNullOrEmpty(searchString))
            {
                data = data.Where(p => p.Ten.Contains(searchString));
            }
            //if(searchString != null)
            //{
            //    pg = 1;
            //}
            switch (sortOrder)
            {
                case "name_desc":
                    data = data.OrderByDescending(p => p.Ten);
                    break;
                case "Gia":
                    data = data.OrderBy(p => p.GiaBan);
                    break;
                case "gia_desc":
                    data = data.OrderByDescending(p => p.GiaBan);
                    break;
                case "SoLuong":
                    data = data.OrderBy(p => p.SoLuong);
                    break;
                case "soluong_desc":
                    data = data.OrderByDescending(p => p.SoLuong);
                    break;
                default:
                    data = data.OrderBy(p => p.Ten);
                    break;
            }

            return View(data);


        }

        // GET: Sanphams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // GET: Sanphams/Create
        public IActionResult Create()
        {
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten");
            return View();
        }

        // POST: Sanphams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Sanpham sanpham, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                sanpham.HinhAnh = Upload(file);
                _context.Add(sanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", sanpham.MaDm);
            return View(sanpham);
        }

        // GET: Sanphams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", sanpham.MaDm);
            return View(sanpham);
        }

        // POST: Sanphams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,IFormFile file, [Bind("MaMh,Ten,GiaGoc,GiaBan,SoLuong,MoTa,HinhAnh,MaDm,LuotXem,LuotMua")] Sanpham sanpham)
        {
            if (id != sanpham.MaMh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        sanpham.HinhAnh = Upload(file);
                    }
                    _context.Update(sanpham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanphamExists(sanpham.MaMh))
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
            ViewData["MaDm"] = new SelectList(_context.Danhmuc, "MaDm", "Ten", sanpham.MaDm);
            return View(sanpham);
        }

        // GET: Sanphams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanpham = await _context.Sanpham
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (sanpham == null)
            {
                return NotFound();
            }

            return View(sanpham);
        }

        // POST: Sanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanpham = await _context.Sanpham.FindAsync(id);
            _context.Sanpham.Remove(sanpham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanphamExists(int id)
        {
            return _context.Sanpham.Any(e => e.MaMh == id);
        }
        public string Upload(IFormFile file)
        {
            string uploadFileName = null;
            if (file != null)
            {
                // phát sinh tên file mới: chuỗi ngẫu nhiên_tên ảnh
                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                // chép file về thư mục lưu trữ ảnh
                var path = $"wwwroot\\images\\products\\{uploadFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

            }
            return uploadFileName; // trả về tên file
        }
    }
}
