using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class SofaCollectionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
