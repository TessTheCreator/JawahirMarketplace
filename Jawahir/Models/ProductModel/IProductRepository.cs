namespace Jawahir.Models.ProductModel
{
	public interface IProductRepository
	{
		List<Product> GetAllProducts();
		void AddNewProduct(Product product);
		public List<Product> SearchProducts(string searchString);


    }
}
