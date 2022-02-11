using Microsoft.AspNetCore.Mvc;

namespace forcontroller.Controllers
{
    public class HomeController : Controller
    {
       public string Index()
        {
            return "hello from shubham patidar";
        }

        public string Name()
        {
            return "My name is shubham patidar";
        }
    }
}
