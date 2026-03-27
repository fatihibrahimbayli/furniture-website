using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.ViewComponents
{
    public class ClientsViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
