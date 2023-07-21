using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.ViewComponents.Default
{
    public class _PropertiesByAreaPartial:ViewComponent
    {
        private readonly IPropertiesByAreaDal _propertiesByAreaDal;

        public _PropertiesByAreaPartial(IPropertiesByAreaDal propertiesByAreaDal)
        {
            _propertiesByAreaDal = propertiesByAreaDal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _propertiesByAreaDal.GetAll();
            return View(values);
        }
    }
}
