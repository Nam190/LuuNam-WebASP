using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTinTuc.DTO;
using WebHangHoa.Model;


namespace WebTinTuc.Controllers
{
    public class DetailController : Controller
    {
        Lvnk22cnt1Context _context = new Lvnk22cnt1Context();
        public IActionResult Detail(int? id)
        {
            var viewModel = _context.SanPhams.FirstOrDefault(x => x.ProductId == id);
            return View(viewModel);
        }
       
    }
       
}
