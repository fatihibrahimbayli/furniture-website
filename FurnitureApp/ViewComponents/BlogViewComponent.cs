using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
