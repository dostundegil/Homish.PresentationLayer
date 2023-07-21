using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentationLayer.Controllers
{
    public class AdminStatisticsController : Controller
    {
        private readonly IStatisticsDal _statisticsDal;

        public AdminStatisticsController(IStatisticsDal statisticsDal)
        {
            _statisticsDal = statisticsDal;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _statisticsDal.GetById("64ba9de97573dd836123977a");
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Statistics statistics)
        {
            _statisticsDal.Update(statistics);
            return RedirectToAction("Index");
        }
    }
}
