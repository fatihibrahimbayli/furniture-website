using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class FeatureViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
