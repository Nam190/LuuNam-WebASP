using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebHangHoa.DTO;
using WebHangHoa.Model;
namespace WebHangHoa.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            var giohang = GetGioHang();
            return View(giohang);
        }
        public Lvnk22cnt1Context db = new Lvnk22cnt1Context();
        protected IHttpContextAccessor _contextAccessor;
        public CartController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public IActionResult CheckOut()
        {
            var giohang = GetGioHang();
            return View(giohang);
        }

        public IActionResult ThemVaoGio(int SanPhamID)
        {
            var giohang = GetGioHang();

            // Kiểm tra xem sản phẩm khách đang chọn đã có trong giỏ hàng chưa
            if (giohang.FirstOrDefault(m => m.SanPhamID == SanPhamID) == null)
            {
                var sp = db.SanPhams.FirstOrDefault(x => x.ProductId == SanPhamID);  // Tìm sản phẩm theo SanPhamID

                var newItem = new CartViewModel()
                {
                    SanPhamID = SanPhamID,
                    TenSanPham = sp.TenSanPham,
                    Hinh =  sp.Anh,
                    SoLuong = 1,
                    DonGia = sp.Gia
                };
                giohang.Add(newItem);  // Thêm CartItem vào giỏ
                TempData["SuccessMessage"] = "Thêm giỏ hàng thành công!";
            }
            else
            {
                // Nếu sản phẩm đã có trong giỏ hàng thì tăng số lượng lên
                var cartItem = giohang.FirstOrDefault(m => m.SanPhamID == SanPhamID);
                cartItem.SoLuong++;
            }

            SaveGioHang(giohang);

            return Redirect(Request.Headers["Referer"].ToString());
        }


        public IActionResult XoaKhoiGio(int SanPhamID)
        {
            var giohang = GetGioHang();
            var itemXoa = giohang.FirstOrDefault(m => m.SanPhamID.Equals(SanPhamID));
            if (itemXoa != null)
            {
                giohang.Remove(itemXoa);
            }
            SaveGioHang(giohang);

            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult GiamSoLuong(int SanPhamID)
        {
            var giohang = GetGioHang();
            var item = giohang.FirstOrDefault(m => m.SanPhamID.Equals(SanPhamID));
            if (item != null)
            {
                item.SoLuong -= 1;
                if (item.SoLuong == 0)
                {
                    giohang.Remove(item);
                }
            }
            SaveGioHang(giohang);

            return Redirect(Request.Headers["Referer"].ToString());
        }
        public List<CartViewModel> GetGioHang()
        {
            var session = HttpContext.Session.GetString("giohang");
            if (session == null)
            {
                return new List<CartViewModel>();
            }
            return JsonConvert.DeserializeObject<List<CartViewModel>>(session);
        }
        public void ClearCart()
        {
            _contextAccessor.HttpContext.Session.Remove("giohang");
        }
        private void SaveGioHang(List<CartViewModel> giohang)
        {
            HttpContext.Session.SetString("giohang", JsonConvert.SerializeObject(giohang));

        }

        [HttpPost]
        public ActionResult SubmitForm(DonHang model)
        {
            var userData = _contextAccessor.HttpContext.Session.GetString("user");
            if (userData == null)
            {
                return RedirectToAction("Login", "Login"); // Redirect to login page
            }

            var currentUser = JsonConvert.DeserializeObject<CustomerSession>(userData);

            if (ModelState.IsValid)
            {
                var khachhang = db.KhachHangs.FirstOrDefault(x => x.CustomerId == currentUser.UserId);
                khachhang.DiaChi = Request.Form["Address"];
                khachhang.DienThoai = Request.Form["Phone"];

                model.CustomerId = currentUser.UserId;

                List<CartViewModel> giohang = GetGioHang();
                decimal? price = 0;
                foreach (var item in giohang)
                {
                    price += item.DonGia * item.SoLuong;
                }
                model.TongGia = price;
                model.NgayDatHang = DateTime.Now;
                db.DonHangs.Add(model);
                db.SaveChanges();
                var id = model.OrderId;

                foreach (var item in giohang)
                {
                    ChiTietDonHang detail = new ChiTietDonHang();
                    detail.OrderId = model.OrderId;
                    detail.ProductId = item.SanPhamID;
                    detail.SoLuong = item.SoLuong;
                    db.ChiTietDonHangs.Add(detail);
                }
                db.SaveChanges();

                TempData["SuccessMessage"] = "Đặt hàng thành công!";
                ClearCart();

                return RedirectToAction("Index", "Home");
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }

}
