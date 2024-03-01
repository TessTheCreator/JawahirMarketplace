using Jawahir.Models.ProductModel;

namespace Jawahir.ViewModels
{
    public class SearchProductsViewModel
    {
        public List<Product> Products { get; set; }

        public SearchProductsViewModel(List<Product> products)
        {
            Products = products;
            
        }
    }
}
