using Jawahir.Models.ProductModel;

namespace Jawahir.Models.CartModel
{
    public class CartItem
    {
        Product ProductId { get; set; }
        public int CartId { get; set; }
    }
}
