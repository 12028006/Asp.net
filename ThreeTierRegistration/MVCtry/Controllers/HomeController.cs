using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataBaseLayer.DBoperation;

namespace MVCtry.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        ManageRegistration ManageReg = new ManageRegistration();

        [HttpPost]
        public void AddReg(FormCollection Form)
        {
            RegistrationModel RegModel = new RegistrationModel()
            {

                Address = Form["txtAddress"],
                City = Form["txtCity"],
                Cno = Form["txtCno"],
                DoB = Convert.ToDateTime(Form["txtDoB"]),
                FullName = Form["txtName"],
                Gender = Form["rdbGender"],
          
            };
            ManageReg.AddReg(RegModel);
            Response.Write("success saved !");
        }
    }
}