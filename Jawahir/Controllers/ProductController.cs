using Jawahir.Models;
using Jawahir.Models.CategoryModel;
using Jawahir.Models.MarketModel;
using Jawahir.Models.ProductModel;
using Jawahir.Models.User;
using Jawahir.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jawahir.Controllers
{
	public class ProductController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IProductRepository _products;
		private readonly IMarketRepository _markets;
		private readonly ICategoryRepository _categories;

		public ProductController(UserManager<ApplicationUser> userManager, IProductRepository products, IMarketRepository markets, ICategoryRepository categories)
		{
			_userManager = userManager;
			_products = products;
			_markets = markets;
			_categories = categories;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AddNewProduct()
		{
			NewProductViewModel model = new NewProductViewModel();

			List<SelectListItem> items = new List<SelectListItem>();
			foreach (var category in _categories.GetCategories())
			{
				items.Add(new SelectListItem { Value = category.CategoryId.ToString(), Text = category.Name.ToString() });
			}
			SelectList categories = new SelectList(items, "Value", "Text");
			model.Categories = categories;

			return View(model);
		}


		[HttpPost]
		public IActionResult AddNewProduct(NewProductViewModel userProductData)
		{
			string userId = _userManager.GetUserId(User);
			Market userMarket = _markets.getUserMarket(userId);

			Product userProduct = new Product();
			userProduct.ProductName = userProductData.Product.ProductName;
			userProduct.ProductDescription = userProductData.Product.ProductDescription;
			userProduct.CategoryId = userProductData.SelectedCategoryId;
			userProduct.Market = userMarket;

			_products.AddNewProduct(userProduct);

			return RedirectToAction("Index", "Market");
		}

		public IActionResult ShowProductDetails(Product product) 
		{
			Category category = _categories.GetCategoryById(product.CategoryId);
			ProductDetailsViewModel model = new ProductDetailsViewModel(product, category);

			
			return View(model);
		}
	}
}
