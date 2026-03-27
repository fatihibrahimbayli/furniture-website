using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class PopularProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
