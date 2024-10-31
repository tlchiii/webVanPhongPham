using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VanPhongPham.Models;

namespace VanPhongPham.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        QLVanPhongPhamContext db = new QLVanPhongPhamContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listSanPham = db.SanPhams.ToList();

            return View(listSanPham);
        }


        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        public IActionResult ChiTietSanPham(string masp)
        {
            var sanpham = db.SanPhams.SingleOrDefault(x => x.MaSanPham == masp);
            var images = db.HinhAnhSanPhams.Where(x => x.MaSanPham == masp).ToList();
            ViewBag.images = images;
            return View(masp);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
