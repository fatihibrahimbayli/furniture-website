using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
