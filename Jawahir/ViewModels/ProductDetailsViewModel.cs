using Jawahir.Models.CategoryModel;
using Jawahir.Models.ProductModel;

namespace Jawahir.ViewModels
{
	public class ProductDetailsViewModel
	{
		Product product;
		Category category;

		public ProductDetailsViewModel(Product product, Category category)
		{
			this.product = product;
			this.category = category;
		}
	}
}
