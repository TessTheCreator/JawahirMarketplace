using Jawahir.Models.CategoryModel;
using Jawahir.Models.ProductModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jawahir.ViewModels
{
    public class NewProductViewModel
    {
		public Product Product {  get; set; }
		[BindProperty]
		public SelectList Categories { get; set; }
        public int SelectedCategoryId { get; set; }

        public NewProductViewModel()
        {
            //SelectedCategoryId = 1;

		}
    }
}
