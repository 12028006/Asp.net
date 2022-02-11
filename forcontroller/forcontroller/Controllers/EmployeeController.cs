using Microsoft.AspNetCore.Mvc;


namespace forcontroller.Controllers
{
    public class EmployeeController : Controller
    {
       public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if(id == 1)
            {
                profile = "Employee 1 Profile ";
            }
            else if(id == 2)
            {
                profile = "Employee 2 Profile ";
            }
            else
            {
                profile = "No record Found";
            }
             
            return profile;
        }
        public string Address(int id, string department)
        {
            return "id = " + id + " and dept = " + department;
        }
        public string Work(string place, string? role = null)
        {
            return "Place is  = " + place + " and Role will be  = " + role;
        }
    }
}
