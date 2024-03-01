using Jawahir.Enums;
using Jawahir.Models.SubCategoryModel;
using static Jawahir.Enums.CategoryName;

namespace Jawahir.Models.CategoryModel
{
    public class CategoryRepository : ICategoryRepository
	{
		private readonly JawahirDbContext _db;

		public CategoryRepository(JawahirDbContext db)
        {
            _db = db;
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList();
        } 

        public Category? GetCategoryById(int CategoryId)
        {
			return _db.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
        }

        public List<SubCategory> GetSubCategories()
        {
            return _db.SubCategories.ToList();
        }
    }
}
