namespace Jawahir.Models.ProductModel
{
	public class ProductType
	{
		public int ProductTypeId { get; set; }
		public string ProductTypeName { get; set; } = string.Empty;
		public string ProductTypeSize { get; set; } = string.Empty;
		public string ProductTypePrice { get; set; }
		public Product Product {  get; set; }
	}
}
