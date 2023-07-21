using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
