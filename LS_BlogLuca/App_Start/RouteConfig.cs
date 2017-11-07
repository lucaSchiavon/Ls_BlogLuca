using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LS_BlogLuca
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Privacy_Localized",
             url: "{lang}/About",
             defaults: new { controller = "About", action = "Index" },
             constraints: new { lang = "it|en" }
         );

            routes.MapRoute(
            name: "Home_Localized",
            url: "{lang}/Home",
            defaults: new { controller = "Home", action = "Index" },
            constraints: new { lang = "it|en" },
             namespaces: new string[] { "LS_BlogLuca.Controllers" }
        );

            routes.MapRoute(
         name: "Contact_Localized",
         url: "{lang}/Contact",
         defaults: new { controller = "Contact", action = "Index" },
         constraints: new { lang = "it|en" }
     );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                   namespaces: new string[] { "LS_BlogLuca.Controllers" }
            );

          
        }
    }
}
