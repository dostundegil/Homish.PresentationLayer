using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class AdminPropertyController : Controller
    {
        private readonly IPropertyDal _propertyDal;

        public AdminPropertyController(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public IActionResult Index()
        {
            var values = _propertyDal.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var values = _propertyDal.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Edit(Property property)
        {
            _propertyDal.Update(property);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Property property)
        {
            _propertyDal.Insert(property);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            _propertyDal.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
