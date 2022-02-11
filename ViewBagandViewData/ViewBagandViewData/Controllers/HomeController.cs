using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagandViewData.Models;

namespace ViewBagandViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MycustomProperty = "shubham patidar";
            ViewBag.MyList = new List<string>() { "jhon","Mark","kim","rock"};

            List<Employee> emplist = new List<Employee>() { new Employee() { Email = "a@gamil.com", Id = 1, Name = "john" },
                new Employee() { Email = "a@gamil.com", Id = 1, Name = "john" },
                new Employee() { Email = "a@gamil.com", Id = 1, Name = "john" }
            };
            ViewBag.Myemplist = emplist;
            return View();
        }
        public ActionResult Demo()
        {
            ViewData["Mylist"] = "this is my list of wish";
            return View();
        }
    }
}