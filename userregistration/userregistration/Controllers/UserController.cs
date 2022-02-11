using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using userregistration.Models;

namespace userregistration.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddorEdit(int id = 0)
        {
            UserR usermodel = new UserR();
            return View(usermodel);
        }
      
       
    }
}