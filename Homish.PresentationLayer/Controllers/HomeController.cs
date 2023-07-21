using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Concrate;
using Homish.DataAccessLayer.Repository;
using Homish.EntityLayer;
using Homish.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homish.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPropertyDal _propertyDal;

        public HomeController(ILogger<HomeController> logger, IPropertyDal propertyDal)
        {
            _logger = logger;
            _propertyDal = propertyDal;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Property property)
        {
            _propertyDal.Insert(property);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
