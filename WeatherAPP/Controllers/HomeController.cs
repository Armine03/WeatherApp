using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherAPP.Models;

namespace WeatherAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Your application WeatherJS page.";

            return View();
        }
        public ActionResult WeatherJS()
        {
            ViewBag.Message = "Your application WeatherJS page.";

            return View();
        }
        public ActionResult WeatherorNot()
        {
            return View();
        }
        public JsonResult GetWeather()
        {
            Weather weath = new Weather();

            return Json(weath.getWeatherForcast(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWeatherByCity(string city)
        {
            Weather weath = new Weather();

            return Json(weath.getWeatherForcastByCity(city), JsonRequestBehavior.AllowGet);
        }
    }
}