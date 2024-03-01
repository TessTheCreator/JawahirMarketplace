using Jawahir.Models.CategoryModel;
using Jawahir.Models.MarketModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO.Pipelines;

namespace Jawahir.Models.ProductModel
{
	public class ProductRepository : IProductRepository
	{
		private readonly JawahirDbContext _db;

		public ProductRepository(JawahirDbContext db)
		{
			_db = db;
		}

		public List<Product> GetAllProducts()
		{
				return _db.Products.ToList();
		}

		public void AddNewProduct(Product product)
		{	
				_db.Products.Add(product);
				_db.SaveChanges();
		}


        public List<Product> SearchProducts(string searchString)
        {
            string searchLower = searchString.ToLower();

            return _db.Products
                .Where(product => product.ProductName.ToLower().Contains(searchLower))
                .ToList();
        }

        
    }
}
