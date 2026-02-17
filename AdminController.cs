using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        // Default Routing
        public IActionResult DefaultRoute()
        {
            return View();
        }

        // Custom Routing
        public IActionResult CustomRoute()
        {
            return View();
        }

        // Attribute Routing
        [Route("Admin/SpecialPage")]
        public IActionResult AttributeRoute()
        {
            return View();
        }
    }
}
