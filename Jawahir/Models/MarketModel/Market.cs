using Jawahir.Models.ProductModel;
using Jawahir.Models.User;

namespace Jawahir.Models.MarketModel
{
    public class Market
    {
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string MarketDescription { get; set; }
        public List<Product> Products { get; set;}
        public string ApplicationUserId { get; set; }

    }
}


