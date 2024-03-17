using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebsiteThietBiDienTu.Data;
using WebsiteThietBiDienTu.Models;

namespace WebsiteThietBiDienTu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPasswordHasher<Khachhang> _passwordHasher;
        private readonly IPasswordHasher<Nhanvien> _nvpasswordHasher;

        public HomeController(ApplicationDbContext context, IPasswordHasher<Khachhang> passwordHasher, IPasswordHasher<Nhanvien> passnhanvien)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _nvpasswordHasher = passnhanvien;
        }
        public void GetInfo()
        {
            ViewData["soluong"] = GetCartItems().Count();

            ViewBag.danhmuc = _context.Danhmuc.ToList();

            if (HttpContext.Session.GetString("khachhang") != "")
            {
                ViewBag.khachhang = _context.Khachhang.FirstOrDefault(k => k.MaKh.ToString() == HttpContext.Session.GetString("khachhang"));
            }
            if (HttpContext.Session.GetString("nhanvien") != "")
            {
                ViewBag.nhanvien = _context.Nhanvien.FirstOrDefault(n => n.Email == HttpContext.Session.GetString("nhanvien"));
            }


        }
        // GET: Home
        public async Task<IActionResult> Index()
        {
            GetInfo();
            var applicationDbContext = _context.Sanpham.Include(s => s.MaDmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Home/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            GetInfo();
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
            ViewBag.sanphamcolienquan = _context.Sanpham.Where(m => m.MaMh != id).Include(s => s.MaDmNavigation);
            return View(sanpham);
        }
        //Get Category of Product
        public async Task<IActionResult> CategoryName(int id)
        {
            GetInfo();
            var applicationDbContext = _context.Sanpham
                .Where(p => p.MaDm == id)
                .Include(m => m.MaDmNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // Đọc danh sách CartItem từ session
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("shopcart");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Lưu danh sách CartItem trong giỏ hàng vào session
        void SaveCartSession(List<CartItem> list)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(list);
            session.SetString("shopcart", jsoncart);
        }

        // Xóa session giỏ hàng
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove("shopcart");
        }

        // Cho hàng vào giỏ
        public async Task<IActionResult> AddToCart(int id)
        {
            var mathang = await _context.Sanpham
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (mathang == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }
            var cart = GetCartItems();
            var item = cart.Find(p => p.SanPham.MaMh == id);
            if (item != null)
            {
                item.SoLuong++;
            }
            else
            {
                cart.Add(new CartItem() { SanPham = mathang, SoLuong = 1 });
            }
            SaveCartSession(cart);

            return RedirectToAction(nameof(ViewCart));
        }

        // Chuyển đến view xem giỏ hàng
        public IActionResult ViewCart()
        {
            GetInfo();
            return View(GetCartItems());
        }

        //Xóa mặt hàng khỏi giỏ hàng
        public IActionResult RemoveItem(int id)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.SanPham.MaMh == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        //Cập nhật số lượng
        public IActionResult UpdateItem(int id, int quantity)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.SanPham.MaMh == id);
            if (item != null)
            {
                item.SoLuong = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }

        public IActionResult Register()
        {
            GetInfo();
            return View();
        }
        //POST
        [HttpPost]
        public IActionResult Register(string email, string matkhau, string hoten, string dienthoai, string diachi, string phuongxa, string quanhuyen, string tinh)
        {
            //kiểm tra khách hàng đã đăng ký chưa
            var nd = _context.Khachhang.FirstOrDefault(nd => nd.Email == email);
            var mk = _context.Khachhang.FirstOrDefault(m => m.MatKhau == matkhau);
            if (nd != null)
            {
                //               ViewBag.khachhang = _context.Khachhang.FirstOrDefault(k => k.Email == HttpContext.Session.GetString("khachhang"));
                return RedirectToAction(nameof(Register));
            }
            else
            {
                //lưu thông tin khách hàng;
                var kh = new Khachhang();
                kh.Email = email;
                kh.MatKhau = _passwordHasher.HashPassword(kh, matkhau);
                kh.Ten = hoten;
                kh.DienThoai = dienthoai;
                _context.Add(kh);
                _context.SaveChanges();

                var dc = new Diachi();
                dc.MaKh = kh.MaKh;
                dc.DiaChi1 = diachi;
                dc.PhuongXa = phuongxa;
                dc.QuanHuyen = quanhuyen;
                dc.TinhThanh = tinh;
                dc.MacDinh = 1;
                _context.Add(dc);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            GetInfo();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string matkhau)
        {
            var kh = await _context.Khachhang
                .FirstOrDefaultAsync(m => m.Email == email);
            var nv = await _context.Nhanvien
                .FirstOrDefaultAsync(m => m.Email == email);
            if (kh != null && _passwordHasher.VerifyHashedPassword(kh, kh.MatKhau, matkhau) == PasswordVerificationResult.Success)
            {
                HttpContext.Session.SetString("khachhang", kh.MaKh.ToString());
                return RedirectToAction(nameof(Index));
            }
            else if (nv != null && _nvpasswordHasher.VerifyHashedPassword(nv, nv.MatKhau, matkhau) == PasswordVerificationResult.Success)
            {
                HttpContext.Session.SetString("nhanvien", email);
                return RedirectToAction("Index", "Main");
            }
            //khong ton tai khach hang chuyen ve login
            return RedirectToAction(nameof(Login));
        }

    }
}
