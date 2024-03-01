using Jawahir.Models.CategoryModel;
using Jawahir.Models.ProductModel;


namespace Jawahir.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        public HomeViewModel(List<Product> products, List<Category> categories)
        {
            Categories = categories;
            Products = products;
        }
    }
}
