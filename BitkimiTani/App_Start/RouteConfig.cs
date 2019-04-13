using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BitkimiTani
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //Controller da degerleri göndermeye için;
            //Burdan 
            // routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            // kadar al

            routes.MapRoute(
                name: "Bitki Adlari",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BitkiAdi", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
