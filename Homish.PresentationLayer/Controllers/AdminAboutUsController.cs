using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class AdminAboutUsController : Controller
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AdminAboutUsController(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values=  _aboutUsDal.GetById("64ba94a4437784feafcb12c8");
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(AboutUs aboutUs)
        {
            _aboutUsDal.Update(aboutUs);
            return RedirectToAction("Index");
        }
    }
}
