using Jawahir.Models.CategoryModel;
using Jawahir.Models.MarketModel;
using System.ComponentModel;

namespace Jawahir.Models.ProductModel

{
	public class Product
	{
		public int ProductId { get; set; }

		[DisplayName("Product Name")]
		public string ProductName { get; set; }
		public string? ProductDescription { get; set; }
		
		public string? ProductImage { get; set; }

		public decimal ProductRating { get; set; } = 0.0m;
		public int CategoryId { get; set; } 

		public Market? Market { get; set; }
	}
}
