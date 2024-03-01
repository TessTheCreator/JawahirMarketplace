
using Jawahir.Models.CartModel;
using Jawahir.Models.CategoryModel;
using Jawahir.Models.MarketModel;
using Jawahir.Models.ProductModel;
using Jawahir.Models.SubCategoryModel;
using Jawahir.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jawahir.Models
{
    public class JawahirDbContext : IdentityDbContext<ApplicationUser>
	{

		public JawahirDbContext(DbContextOptions options) :base(options)
		{

		}

		public DbSet<Market> Markets { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Feature> Features { get; set; }

	}
}
