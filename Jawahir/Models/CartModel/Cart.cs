using Jawahir.Models.MarketModel;
using Jawahir.Models.ProductModel;

namespace Jawahir.Models.CartModel
{
	public class Cart
	{
		public int CartId { get; set; }
		public string CartItems { get; set;} = string.Empty;
        public string ApplicationUserId { get; set; }


    }
}
