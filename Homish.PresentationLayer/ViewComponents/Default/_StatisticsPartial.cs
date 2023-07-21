using Homish.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.ViewComponents.Default
{
    public class _StatisticsPartial:ViewComponent
    {
        private readonly IStatisticsDal _statisticsDal;

        public _StatisticsPartial(IStatisticsDal statisticsDal)
        {
            _statisticsDal = statisticsDal;
        }

        public IViewComponentResult Invoke()
        {
            var value = _statisticsDal.GetById("64ba9de97573dd836123977a");
            return View(value);
        }
    }
}
