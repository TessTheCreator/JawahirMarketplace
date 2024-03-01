using Jawahir.Models.MarketModel;
using Jawahir.Models.ProductModel;

namespace Jawahir.Models.CartModel
{
	public class Cart
	{
		public int CartId { get; set; }
		public List<CartItem> CartItems { get; set;} = new List<CartItem>();
        public string ApplicationUserId { get; set; }


    }
}
