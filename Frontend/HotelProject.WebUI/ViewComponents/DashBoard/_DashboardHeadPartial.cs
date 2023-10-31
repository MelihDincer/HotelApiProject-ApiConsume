using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.DashBoard
{
    public class _DashboardHeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}