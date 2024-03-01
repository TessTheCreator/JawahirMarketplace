using Jawahir.Enums;

namespace Jawahir.Models.SubCategoryModel
{
    public class SubCategory
    {

        public int SubCategoryId { get; set; }
        public SubCategoryName Name { get; set; }
        public int CategoryId { get; set; }

    }
}
