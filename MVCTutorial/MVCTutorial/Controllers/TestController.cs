using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            Employe employee = db.Employes.SingleOrDefault(x => x.EmployeeId == 1);

            EmployeeViewModel vm = new EmployeeViewModel();

            vm.EmployeeId = employee.EmployeeId;
            vm.Name = employee.Name;
            vm.Address = employee.Address;

            return View(vm);
        }
    }
}