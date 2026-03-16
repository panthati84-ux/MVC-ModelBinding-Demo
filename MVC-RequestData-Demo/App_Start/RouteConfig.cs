using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_RequestData_Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "RouteExample",
                url: "Employee/RouteExample/{id}",
                defaults: new { controller = "Employee", action = "RouteExample", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}