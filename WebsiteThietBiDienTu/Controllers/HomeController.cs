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

            ViewBag.tintuc = _context.Tintuc.ToList();
            
        }
        // GET: Home
        public async Task<IActionResult> Index(string search = "")
        {
            GetInfo();
         
            var data = from p in _context.Sanpham.Include(p => p.MaDmNavigation)
                       select p;

            if (!String.IsNullOrEmpty(search))
            {
                data = data.Where(p => p.Ten.Contains(search));
                var searchResult = await data.ToListAsync();

                if (searchResult.Any()) // Kiểm tra xem có kết quả tìm kiếm hay không
                {
                    return View("SearchResultView", searchResult); // Trả về view tìm kiếm nếu có kết quả
                }
                else
                {
                    return View("SearchResultView");
                }
            }

            return View(await data.ToListAsync());

        }
        public IActionResult SearchResultView()
        {
            GetInfo();
            return View();
        }
        public IActionResult CardCarousel()
        {
            GetInfo();
            return View();
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
            var product = _context.Sanpham.Find(id);
            if (product != null)
            {
                product.LuotXem++;
                _context.SaveChanges();
            }
            if (product.SoLuong == 0)
            {
                return RedirectToAction("OutOfStock");
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
            //var mathang = await _context.Sanpham
            //    .FirstOrDefaultAsync(m => m.MaMh == id);
            //if (mathang == null)
            //{
            //    return NotFound("Sản phẩm không tồn tại");
            //}
            //var cart = GetCartItems();
            //var item = cart.Find(p => p.SanPham.MaMh == id);
            //if (item != null)
            //{
            //    item.SoLuong++;
            //}
            //else
            //{
            //    cart.Add(new CartItem() { SanPham = mathang, SoLuong = 1 });
            //}
            //SaveCartSession(cart);

            //return RedirectToAction(nameof(ViewCart));
            var mathang = await _context.Sanpham.FirstOrDefaultAsync(m => m.MaMh == id);
            
            if (mathang == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }

            // Kiểm tra xem người dùng đã đăng nhập hay chưa
            if (HttpContext.Session.GetString("khachhang") == null || HttpContext.Session.GetString("khachhang") == " ")
            {
                // Nếu chưa đăng nhập, chuyển hướng đến trang đăng nhập
                return RedirectToAction(nameof(Login));
            }

            // Nếu đã đăng nhập, tiếp tục thêm sản phẩm vào giỏ hàng
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
                if(quantity <= item.SanPham.SoLuong)
                {
                    item.SoLuong = quantity;
                    
                }
                else
                {
                    TempData["ErrorMessage"] = "Sn pham nay chi con lai" + item.SanPham.SoLuong+ "sna pham.Vui long lua chon san pham khac";
                    
                }
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
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(matkhau))
            {
                // Hoặc redirect đến trang login với thông báo lỗi
                return RedirectToAction(nameof(Login));
            }
            
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
                return RedirectToAction("Index", "Admin");
            }
            //khong ton tai khach hang chuyen ve login
            return RedirectToAction(nameof(Login));
        }
        public IActionResult Logout()
        {
            GetInfo();
            if (HttpContext.Session.GetString("khachhang") != null)
            {
                HttpContext.Session.SetString("khachhang", " ");
            }
            else
            {
                HttpContext.Session.SetString("nhanvien", " ");
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetString("khachhang") == "" || HttpContext.Session.GetString("khachhang") == null)
            {
                GetInfo();
                return View(GetCartItems());

            }
            else
            {
                int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
                List<Diachi> lstDiaChi = _context.Diachi.Where(d => d.MaKh == makh).ToList();
                ViewBag.diachi = lstDiaChi;
                GetInfo();
                return View(GetCartItems());
            }
        }
        public async Task<IActionResult> CreateBill(int id, string hoten, string email, string sodienthoai, string diachi, string phuongxa, string huyen, string tinh, int madiachi)
        {
            GetInfo();
            //Xử lý thông tin khách hàng(khách mới)
            Khachhang kh;
            Diachi dc;

            if (id != 0)
            {

                kh = _context.Khachhang.FirstOrDefault(k => k.MaKh == id);
                dc = _context.Diachi.FirstOrDefault(d => d.MaDc == madiachi);
            }
            else
            {

                kh = new Khachhang();
                kh.Ten = hoten;
                kh.Email = email;
                kh.DienThoai = sodienthoai;
                _context.Add(kh);
                await _context.SaveChangesAsync();

                dc = new Diachi();
                dc.MaKh = kh.MaKh;
                dc.DiaChi1 = diachi;
                dc.PhuongXa = phuongxa;
                dc.QuanHuyen = huyen;
                dc.TinhThanh = tinh;
                _context.Add(dc);
                await _context.SaveChangesAsync();

            }

            //Hóa đơn
            var hd = new Hoadon();
            hd.Ngay = DateTime.Now;
            hd.MaKh = kh.MaKh;
            hd.MaDc = dc.MaDc;
            _context.Add(hd);
            await _context.SaveChangesAsync();

            //thêm chi tiết hóa đơn
            var cart = GetCartItems();

            int thanhtien = 0;
            int tongtien = 0;
            foreach (var i in cart)
            {

                var ct = new Cthoadon();
                ct.MaHd = hd.MaHd;
                ct.MaMh = i.SanPham.MaMh;
                thanhtien = i.SanPham.GiaBan * i.SoLuong;
                tongtien += thanhtien;
                ct.DonGia = i.SanPham.GiaBan;
                ct.SoLuong = (short)i.SoLuong;
                ct.ThanhTien = thanhtien;
                _context.Add(ct);

                var product = _context.Sanpham.Find(i.SanPham.MaMh);
                product.SoLuong -= (short)i.SoLuong;
                product.LuotMua++;

            }
            await _context.SaveChangesAsync();


            //cập nhật tổng tiền hóa đơn
            hd.TongTien = tongtien;
            _context.Update(hd);
            await _context.SaveChangesAsync();

            //xóa giỏ hàng
            ClearCart();
            GetInfo();



            return View(hd);
        }
        public IActionResult Customer()
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var lstDiaChi = _context.Diachi.FirstOrDefault(d => d.MaKh == makh);
            //var order = _context.Hoadon.FirstOrDefault(hd => hd.MaKh == makh);
            //if (order != null || order.TrangThai == "Chờ xác nhận")
            //{
            //    var cthoadons = _context.Cthoadon.Where(ct => ct.MaHd == order.MaHd).ToList();
            //    _context.Cthoadon.RemoveRange(cthoadons);
            //    _context.SaveChanges();

            //    // Sau đó mới xóa hóa đơn chính
            //    _context.Hoadon.Remove(order);
            //    _context.SaveChanges();
            //}

            ViewBag.hoadon = _context.Hoadon.Where(h => h.MaKh == makh).Include(m=>m.MaKhNavigation).ToList();
            ViewBag.cthoadon = _context.Cthoadon.Where(h => h.MaHdNavigation.MaKh == makh).Include(m=>m.MaHdNavigation).Include(m=>m.MaMhNavigation).ToList();
           
            GetInfo();
            return View(lstDiaChi);

        }
        public async Task<IActionResult> EditCustomer()
        {
            GetInfo();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditCustomer(int id, string email, string matkhau, string hoten, string sodienthoai)
        {
            var kt = _context.Khachhang.FirstOrDefault(k => k.Email == email && k.MaKh != id && k.MatKhau != null);
            
            if (kt != null)
            {
                GetInfo();
                return RedirectToAction(nameof(EditCustomer));
            }
            var kh = _context.Khachhang.FirstOrDefault(kh => kh.MaKh == id);
            kh.Ten = hoten;
            kh.Email = email;
            kh.DienThoai = sodienthoai;
            if (matkhau != null)
            {
                kh.MatKhau = _passwordHasher.HashPassword(kh, matkhau);
            }
            _context.Update(kh);
            await _context.SaveChangesAsync();

            GetInfo();
            return RedirectToAction(nameof(Customer));
        }
        public IActionResult ChangeAddress()
        {
            GetInfo();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeAddress(string diachi, string phuongxa, string quanhuyen, string tinhthanh)
        {
            int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
            var dc = _context.Diachi.FirstOrDefault(d => d.MaKh == makh);
            dc.DiaChi1 = diachi;
            dc.PhuongXa = phuongxa;
            dc.QuanHuyen = quanhuyen;
            dc.TinhThanh = tinhthanh;
            dc.MacDinh = 1;
            _context.Update(dc);
            await _context.SaveChangesAsync();

            GetInfo();
            return RedirectToAction(nameof(Customer));
        }
        //public IActionResult OutOfStock()
        //{
        //    GetInfo();
        //    return View();
        //}
        public async Task<IActionResult> OutOfStock(int? id)
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
           
            return View(sanpham);
        }

        public async Task<IActionResult> TinTuc(int? id)
        { 
            GetInfo();
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
            ViewBag.tintuc = _context.Tintuc.Where(m => m.MaTin != id).ToList();
            return View(tintuc);
        }
        public IActionResult TrangTinTuc()
        {
            GetInfo();
            return View();
        }
        //public async Task<IActionResult> GetOrderDetail()
        //{
        //    int makh = int.Parse(HttpContext.Session.GetString("khachhang"));
        //    GetInfo();
        //    var applicationDbContext = _context.Hoadon
        //        .Where(p => p.MaKh == makh)
        //        .Include(m => m.MaDcNavigation);
        //    return View(await applicationDbContext.ToListAsync());
        //}
        public IActionResult LienHe()
        {
            GetInfo();
            return View();
        }
        public IActionResult About()
        {
            GetInfo();
            return View();
        }
    }
}
