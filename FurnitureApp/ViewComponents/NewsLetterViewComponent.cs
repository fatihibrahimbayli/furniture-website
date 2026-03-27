using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class NewsLetterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
