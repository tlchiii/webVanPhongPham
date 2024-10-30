using Microsoft.AspNetCore.Mvc;

namespace VanPhongPham.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}
