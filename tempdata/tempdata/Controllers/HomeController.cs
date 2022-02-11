using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tempdata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["key"] = "this is index data";
            return View();
        }
        public ActionResult Index2()
        {
            //ViewBag.mykey = TempData["key"];
           // TempData.Keep();

            ViewBag.mykey = TempData.Peek("key");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.mykey = TempData["key"];
            return View();
        }
    }
}