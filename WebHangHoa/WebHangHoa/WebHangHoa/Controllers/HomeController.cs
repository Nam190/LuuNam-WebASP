using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebHangHoa.Model;

namespace WebTinTuc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Lvnk22cnt1Context _context = new Lvnk22cnt1Context();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(string category = "All", string searchTerm = "")
        {
            var products = _context.SanPhams.AsQueryable();

            if (category != "All")
            {
                products = products.Where(p => p.CategoryId == int.Parse(category));
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.TenSanPham.Contains(searchTerm));
            }

            ViewBag.SelectedCategory = category;
            ViewBag.SearchTerm = searchTerm; 

            return View(products.ToList());
        }

        public IActionResult Tintuc()
        {
            return View();
        }


        public IActionResult KhuyenMai()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
