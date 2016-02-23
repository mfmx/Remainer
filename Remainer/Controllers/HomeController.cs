using Remainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Remainer.Controllers
{
    public class HomeController : Controller
    {
        RestaurantLocationContext _db = new RestaurantLocationContext();
        public ActionResult Index()
        {
            var model = _db.RestaurantLocations.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}