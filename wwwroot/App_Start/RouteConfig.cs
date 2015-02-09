using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace wwwroot
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Padrinos",
               url: "Padrinos/{id}",
               defaults: new { controller = "Boda", action = "Padrinos", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Damas",
               url: "Damas/{id}",
               defaults: new { controller = "Boda", action = "Damas", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Damo",
               url: "Damo/{id}",
               defaults: new { controller = "Boda", action = "Damo", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
