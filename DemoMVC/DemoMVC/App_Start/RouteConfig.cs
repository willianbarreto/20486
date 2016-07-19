using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Default2", "cl/{id}", new
            //{
            //    controller = "Cliente",
            //    action = "Details"
            //});

            //routes.MapRoute("Default3", "{controller}/{action}/{id}/{cor}",
            //    new { controller = "Cliente", action = "NovaRota" }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Cliente", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}