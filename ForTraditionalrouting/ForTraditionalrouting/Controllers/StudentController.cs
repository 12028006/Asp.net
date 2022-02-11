using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForTraditionalrouting.Models;

namespace ForTraditionalrouting.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        // GET: Student
        [Route("")]
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }

        [Route("{id:int}")]
        public ActionResult GetOneStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        [Route("{id}/address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View();
        }
        [Route("{id}")]
        public string  serve(string id)
        {
            return id;
        }

        [Route("~/aboutus")]
        public string result()
        {
            return "this is about us";
        }

        public List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "1 Student",
                    Class = "first",
                    Address = new Address()
                    {
                        Address1 = "this is student 1 address",
                        City = "Student 1 city",
                        HomeNumber ="student 1"
                     }

                },
                 new Student()
                {
                    Id = 2,
                    Name = "2 Student",
                    Class = "Two",
                    Address = new Address()
                    {
                        Address1 = "this is student 2 address",
                        City = "Student 2 city",
                        HomeNumber ="student 2"
                     }

                }
            };
        }
    }
}