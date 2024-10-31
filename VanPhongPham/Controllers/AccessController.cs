using Microsoft.AspNetCore.Mvc;

namespace VanPhongPham.Controllers
{
    public class AccessController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }

    }
}
