using Homish.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.ViewComponents.Default
{
    public class _WhatWeOfferPartial:ViewComponent
    {
        private readonly IPropertyDal _propertyDal;

        public _WhatWeOfferPartial(IPropertyDal propertyDal)
        {
            _propertyDal = propertyDal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _propertyDal.Take2Property();
            return View(values);
        }
    }
}
