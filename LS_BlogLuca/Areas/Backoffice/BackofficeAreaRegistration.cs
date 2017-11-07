using System.Web.Mvc;

namespace LS_BlogLuca.Areas.Backoffice
{
    public class BackofficeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Backoffice";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
               "Backoffice_Home",
               "Backoffice/Home/{action}/{id}",
               new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "LS_BlogLuca.Areas.Backoffice.Controllers" }
           );
            context.MapRoute(
                "Backoffice_default",
                "Backoffice/{controller}/{action}/{id}",
                new { controller="Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}