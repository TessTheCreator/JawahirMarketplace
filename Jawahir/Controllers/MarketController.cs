using Jawahir.Models.MarketModel;
using Jawahir.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Controllers
{
    [Authorize]
    public class MarketController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IMarketRepository _marketRepository;

		public MarketController(UserManager<ApplicationUser> userManager, IMarketRepository marketRepository)
		{
			
			_userManager = userManager;
			_marketRepository = marketRepository;
		}


		public IActionResult Index()
		{
			string userId = _userManager.GetUserId(User);

			Market userMarket = _marketRepository.getUserMarket(userId) ?? _marketRepository.createNewMarket(userId);
			userMarket.Products = _marketRepository.GetUserProductsByUserId(userMarket);

			return View(userMarket);
		}
	}
}
