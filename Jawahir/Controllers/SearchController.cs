using Jawahir.Models.ProductModel;
using Jawahir.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductRepository _products;

        public SearchController(IProductRepository products)
        {
            _products = products;
        }

        public IActionResult Index(string searchString)
        {

            List<Product> productsList = _products.SearchProducts(searchString);
            SearchProductsViewModel productListObj = new SearchProductsViewModel(productsList);

            return View(productListObj);
        }
    }
}
