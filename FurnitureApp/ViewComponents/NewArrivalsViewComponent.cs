using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class NewArrivalsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
