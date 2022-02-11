using Microsoft.AspNetCore.Mvc;

namespace ConditionalStatement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
