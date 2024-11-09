using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebHangHoa.DTO;
using WebHangHoa.Model;


namespace WebTinTuc.Controllers
{
    public class LoginController : Controller
    {
        private Lvnk22cnt1Context _context;
        protected IHttpContextAccessor _contextAccessor;
        public LoginController(Lvnk22cnt1Context context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        // GET: Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LoginAdmin()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Tìm người dùng trong database
                var user = _context.KhachHangs.SingleOrDefault(u => u.TaiKhoan == model.Username && u.MatKhau == model.Password);
                if (user != null)
                {
                    // Đăng nhập thành công, lưu thông tin người dùng vào session
                    var data = new CustomerSession
                    {
                        UserId = user.CustomerId,
                        FullName = user.HoTen,
                        PhoneNumber = user.DienThoai
                    };
                    _contextAccessor.HttpContext.Session.SetString("Username", user.HoTen);
                    _contextAccessor.HttpContext.Session.SetString("user", JsonConvert.SerializeObject(data));
                    return RedirectToAction("Index", "Home");
                }
                // Đăng nhập thất bại
                ModelState.AddModelError(string.Empty, "Lỗi đăng nhập.");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registor(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.KhachHangs.SingleOrDefault(u => u.TaiKhoan == model.Username);
                if (user == null)
                {
                    var data = new KhachHang
                    {
                        HoTen = model.FullName,
                        TaiKhoan = model.Username,
                        MatKhau = model.Password,
                        Email = "example@gmail.com"
                    };
                    _context.KhachHangs.Add(data);
                    _context.SaveChanges();
                    ModelState.AddModelError(string.Empty, "Đăng ký thành công !");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Tài khoản đã tồn tại.");
                }

            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AuthenticationAdmin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.QuanTris.SingleOrDefault(u => u.TaiKhoan == model.Username && u.MatKhau == model.Password);
                if (user != null)
                {

                    HttpContext.Session.SetString("Username", user.TaiKhoan);
                    HttpContext.Session.SetString("UserId", user.TaiKhoan);
                    return RedirectToAction("Index", "SanPhams");

                }
                ModelState.AddModelError(string.Empty, "Lỗi đăng nhập");
            }
            return RedirectToAction("AuthenticationAdmin", "Login");
        }

    }
}
