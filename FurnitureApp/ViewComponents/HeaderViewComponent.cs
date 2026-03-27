using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
