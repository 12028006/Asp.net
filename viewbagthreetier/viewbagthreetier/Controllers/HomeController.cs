using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viewbagthreetier.Models;

namespace viewbagthreetier.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee() {
                Id = 1,
                Name = "shubham",
                Address = "ujjain"
            };

            TempData["id"] = emp.Id;
            TempData["name"] = emp.Name;
            TempData["Address"] = emp.Address;
            return new RedirectResult(@"~\Hometwo\");
        }
    }
}