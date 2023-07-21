using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class AdminPropertiesByAreaController : Controller
    {
        private readonly IPropertiesByAreaDal _propertiesByAreaDal;

        public AdminPropertiesByAreaController(IPropertiesByAreaDal propertiesByAreaDal)
        {
            _propertiesByAreaDal = propertiesByAreaDal;
        }

        public IActionResult Index()
        {
            var values = _propertiesByAreaDal.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var values = _propertiesByAreaDal.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(PropertiesByArea propertiesByArea)
        {
            _propertiesByAreaDal.Update(propertiesByArea);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PropertiesByArea propertiesByArea)
        {
            _propertiesByAreaDal.Insert(propertiesByArea);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            _propertiesByAreaDal.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
