using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBManage.Models;
using System.Web.Mvc;

namespace DBManage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentContext sc = new StudentContext();
            Student singlestu = sc.Students.Where<>
            return View();
        }
    }
}