using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ForTraditionalrouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

           /* routes.MapRoute(
                name: "allStudents",
                url: "students",
                defaults: new { controller = "Student", action = "GetAllStudent" }
                );
            routes.MapRoute(
                name: "Student",
                url: "students/{id}",
                defaults: new { controller = "Student", action = "GetOneStudent" }
                );
            routes.MapRoute(
                name: "AddressStudent",
                url: "students/{id}/Address",
                defaults: new { controller = "Student", action = "GetStudentAddress" }
                ); */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "GetAllStudent", id = UrlParameter.Optional }
            );
        }
    }
}
