
using Jawahir.Models;
using Jawahir.Models.CategoryModel;
using Jawahir.Models.SubCategoryModel;
using Jawahir.Enums;
using Microsoft.AspNetCore.Builder;
using System.Drawing;
using System.IO.Pipelines;

namespace Training_Project.Models.SeedData
{
	public class DbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			JawahirDbContext db = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<JawahirDbContext>();

			if (!db.Categories.Any())
			{
				db.AddRange
				(
					new Category { Name = Jawahir.Enums.CategoryName.Clothing },
					new Category { Name = Jawahir.Enums.CategoryName.Furniture },
					new Category { Name = Jawahir.Enums.CategoryName.Electronics }

				);
			}

			if (!db.SubCategories.Any())
			{
				db.AddRange
				(
					//Clothing
					new SubCategory { Name = SubCategoryName.Shirt, CategoryId = 1 },
					new SubCategory { Name = SubCategoryName.Pants, CategoryId = 1 },
					new SubCategory { Name = SubCategoryName.Shoes, CategoryId = 1 },

					//Furniture
					new SubCategory { Name = SubCategoryName.CoffeeTable, CategoryId = 2 },
					new SubCategory { Name = SubCategoryName.Beds, CategoryId = 2 },
					new SubCategory { Name = SubCategoryName.Couches, CategoryId = 2 },

					//Electronics
					new SubCategory { Name = SubCategoryName.Tvs, CategoryId = 3 },
					new SubCategory { Name = SubCategoryName.Computers, CategoryId = 3 },
					new SubCategory { Name = SubCategoryName.Phones, CategoryId = 3 }


				);
			}

			if (!db.Features.Any())
			{
				db.AddRange
				(
					//COLOR
					new Feature { FeatureName = "Color", Value = "Blue" },
					new Feature { FeatureName = "Color", Value = "Green" },
					new Feature { FeatureName = "Color", Value = "Pink" },
					new Feature { FeatureName = "Color", Value = "Red" },

					//METRIC SIZE (M)
					new Feature { FeatureName = "MetricSize", Value = "2x4" },
					new Feature { FeatureName = "MetricSize", Value = "2x5" },
					new Feature { FeatureName = "MetricSize", Value = "2x6" },

					//CLOTHING SIZE 
					new Feature { FeatureName = "ShirtSize", Value = "XS" },
					new Feature { FeatureName = "ShirtSize", Value = "S" },
					new Feature { FeatureName = "ShirtSize", Value = "M" },
					new Feature { FeatureName = "ShirtSize", Value = "L" },
					new Feature { FeatureName = "ShirtSize", Value = "XL" }

				);
			}

			db.SaveChanges();

		}


	}
}

