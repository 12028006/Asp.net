using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecordManage.Models;
using System.Data.Entity;

namespace RecordManage.Controllers
{
    public class RecordController : Controller
    {
        // GET: Record
        private mvcCRUDDBEntities db = new mvcCRUDDBEntities();

        // GET: Patient
        public ActionResult Index()
        {
            return View(db.TblPatients.ToList());

        }
        public JsonResult AddPatient(TblPatient tblPatient)
        {
            try
            {
                db.TblPatients.Add(tblPatient);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return Json(tblPatient, JsonRequestBehavior.AllowGet);

        }
        public JsonResult UpdatePatient(TblPatient tblPatient)
        {

            string status = "success";
            try
            {
                db.Entry(tblPatient).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                status = ex.Message;

            }
            return Json(tblPatient, JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeletePatient(int PatientId)
        {
            string status = "success";
            try
            {

                var pateint = db.TblPatients.Find(PatientId);
                db.TblPatients.Remove(pateint);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                status = ex.Message;

            }
            return Json(status, JsonRequestBehavior.AllowGet);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}