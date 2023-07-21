using Homish.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class DefaultPropertiesController : Controller
    {
        private readonly IPropertyDal _propertyDal;

        public DefaultPropertiesController(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public IActionResult Index()
        {
            var values = _propertyDal.GetAll();
            return View(values);
        }
    }
}
