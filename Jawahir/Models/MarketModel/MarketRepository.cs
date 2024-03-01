using Jawahir.Models.CartModel;
using Jawahir.Models.ProductModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace Jawahir.Models.MarketModel
{
	public class MarketRepository : IMarketRepository
	{
		private readonly JawahirDbContext _db;

		public MarketRepository(JawahirDbContext db)
		{
			_db = db;
		}

		public Market createNewMarket(string ApplicationUserId)
		{
			Market userMarket = new Market();
			userMarket.MarketName = "My new Market";
			userMarket.MarketDescription = "Add products to sell in your market";
			userMarket.ApplicationUserId = ApplicationUserId;

			_db.Markets.Add(userMarket);
			_db.SaveChanges();
			return userMarket;

		}

		public Market getUserMarket(string ApplicationUserId) => _db.Markets.SingleOrDefault(m => m.ApplicationUserId == ApplicationUserId);

		/*
		public List<Product> GetUserProductsByUserId(int marketId)
		{
			List<Product> Products = new List<Product>();

		return Products ??=
					   _db.Products.Where(p => p.Market.MarketId == marketId)
						   .ToList();
		}
		*/

		public List<Product> GetUserProductsByUserId(Market market)
		{
			var products = _db.Products
				.Where(p => p.Market == market)
				.ToList();

			return products;
		}
	}
}
