using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string postusingpara(string firstname, string lastname)
        {
            return "My name is " + firstname + " " +lastname;
        }

        [HttpPost]
        public string postusingrequest()
        {
            string firstname = Request["firstname"];
            string lastname = Request["lastname"];
            return "from request = " + firstname + lastname;
        }

        [HttpPost]
        public string postusingformcollection( FormCollection form)
        {
            string firstname = form["firstname"];
            string lastname = form["lastname"];
            return "from form collection = " + firstname + lastname;
        }
        [HttpPost]
        public string passusingmodels(myemp emp)
        {
            return "from usig strongly binding = " + emp.firstname + emp.lastname;
        }

    }
}