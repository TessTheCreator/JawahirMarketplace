using Microsoft.AspNetCore.Mvc;

namespace Jawahir.Components
{
    public class SearchBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
