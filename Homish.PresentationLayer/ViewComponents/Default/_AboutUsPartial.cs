using Homish.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.ViewComponents.Default
{
    public class _AboutUsPartial:ViewComponent
    {
        private readonly IAboutUsDal _aboutUsDal;

        public _AboutUsPartial(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutUsDal.GetById("64ba94a4437784feafcb12c8");
            return View(values);
        }
    }
}
