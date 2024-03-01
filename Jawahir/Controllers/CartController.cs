using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
