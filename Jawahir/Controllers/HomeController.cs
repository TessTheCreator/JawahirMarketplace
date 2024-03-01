using Jawahir.Models;
using Jawahir.Models.CategoryModel;
using Jawahir.Models.ProductModel;
using Jawahir.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jawahir.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;

        }

        public IActionResult Index()
        {
            List<Category> RecommendedCategories = _categoryRepository.GetCategories();
            List<Product> RecommendedProducts = _productRepository.GetAllProducts();
            HomeViewModel model = new HomeViewModel(RecommendedProducts, RecommendedCategories);
            return View(model);
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