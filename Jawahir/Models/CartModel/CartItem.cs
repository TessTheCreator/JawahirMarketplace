using Jawahir.Models.ProductModel;

namespace Jawahir.Models.CartModel
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        Product ProductId { get; set; }
        public int CartId { get; set; }
    }
}
