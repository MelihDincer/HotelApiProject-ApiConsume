using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public IActionResult HeadPartial()
        {
            return View();
        }

        public IActionResult PreloaderPartial()
        {
            return View();
        }
        public IActionResult NavheaderPartial()
        {
            return View();
        }

        public IActionResult HeaderPartial()
        {
            return View();
        }
        public IActionResult SidebarPartial()
        {
            return View();
        }
        public IActionResult FooterPartial()
        {
            return View();
        }
        public IActionResult ScriptPartial()
        {
            return View();
        }
    }
}
