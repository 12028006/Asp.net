using Microsoft.AspNetCore.Mvc;

namespace HtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
