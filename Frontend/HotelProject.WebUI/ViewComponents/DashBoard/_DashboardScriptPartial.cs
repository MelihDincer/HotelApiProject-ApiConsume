using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.DashBoard
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
