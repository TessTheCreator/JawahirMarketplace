using Jawahir.Models.SubCategoryModel;

namespace Jawahir.Models.CategoryModel
{
    public interface ICategoryRepository
    {
		public List<Category> GetCategories();
		public Category? GetCategoryById(int CategoryId);
		public List<SubCategory> GetSubCategories();


	}
}
