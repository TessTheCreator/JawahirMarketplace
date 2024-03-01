using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
