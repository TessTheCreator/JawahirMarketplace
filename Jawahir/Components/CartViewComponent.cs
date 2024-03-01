using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
