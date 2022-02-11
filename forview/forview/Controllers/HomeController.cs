using Microsoft.AspNetCore.Mvc;

namespace forview.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/views/myview/mynewview.cshtml");
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ActionResult Withoutview()
        {
            return View();
        }
    }
}
