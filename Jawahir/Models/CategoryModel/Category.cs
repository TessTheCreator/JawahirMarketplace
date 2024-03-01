using System.Security.Cryptography.X509Certificates;
using Jawahir.Enums;
using static Jawahir.Enums.CategoryName;

namespace Jawahir.Models.CategoryModel
{

    public class Category
	{
        public int CategoryId { get; set; }
        public CategoryName Name { get; set; }
    }
}

