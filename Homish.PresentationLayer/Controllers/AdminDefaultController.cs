using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class AdminDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
