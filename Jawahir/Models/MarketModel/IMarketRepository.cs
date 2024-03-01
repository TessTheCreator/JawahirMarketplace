using Jawahir.Models.ProductModel;

namespace Jawahir.Models.MarketModel
{
	public interface IMarketRepository
	{

        public Market createNewMarket(string ApplicationUserId);
        public Market getUserMarket(string userId);
        public List<Product> GetUserProductsByUserId(Market market);


    }
}
