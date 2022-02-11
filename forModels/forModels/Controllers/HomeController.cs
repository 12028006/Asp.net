using Microsoft.AspNetCore.Mvc;
using forModels.Models;
namespace forModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Name = "shubham",
                Address = "india"
            };
        }
    }
}
